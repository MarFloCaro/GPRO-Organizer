using go.Forms;
using go.Parsers;
using go.Utils;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace go.Comms
{
    public class Communication
    {
        private static RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline;
        public string username = "";
        public string managerName = "";
        public int managerID = -1;
        public string groupName = "";
        public string teamName = "";
        public string password = "";
        public bool rememberPassword;
        private int driverid;
        private int TechDid;
        public string nextRace = "";
        private CookieContainer cookieContainer = new CookieContainer();

        internal Communication()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Communication.SetAllowUnsafeHeaderParsing20();
        }


        internal Communication(bool rememberPassword, string managerName, string teamName)
          : this()
        {
            this.rememberPassword = rememberPassword;
            this.managerName = managerName;
            this.teamName = teamName;
        }

        public bool IsLoggedIn { get; set; }

        private bool _loginInProgress;

        public Func<(string username, string password)> CredentialProvider { get; set; }

        public static class AppInfo
        {
            public static string Version =>
                Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "0.0.0.0";

            public static string UserAgent =>
                $"GPRO-Organizer/{Version} (.NET {Environment.Version})";
        }

        private HttpWebRequest CreateRequest(string url, string method = "GET")
        {
            // Prevent accidental double-prefixing
            if (!url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                url = go.Utils.Util.URI + url;
            }

            HttpWebRequest request =
                (HttpWebRequest)WebRequest.Create(url);

            request.CookieContainer = this.cookieContainer;
            request.UserAgent = AppInfo.UserAgent;
            request.Method = method.ToUpperInvariant();

            request.Timeout = 20000;
            request.ReadWriteTimeout = 20000;

            request.AllowAutoRedirect = true;

            request.KeepAlive = true;

            request.AutomaticDecompression =
                DecompressionMethods.GZip |
                DecompressionMethods.Deflate;

            return request;
        }

        public void EnsureSession()
        {
            if (this.IsLoggedIn)
            {
                string homePage;
                homePage = GetHomePage();

                if (
                homePage.Contains("Sign in") ||
                homePage.Contains("To access the site you have to sign in first")
                )
                {
                    this.IsLoggedIn = false;
                }
                else
                {
                    return;
                }
            }

            if (_loginInProgress)
                return;

            this.Login("Ensure Session");
        }


        private void EnsureCredentials()
        {
            if (CredentialProvider == null)
                throw new Exception("No credential provider configured.");

            var creds = CredentialProvider();

            username = creds.username;
            password = creds.password;

            if (!string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(password))
            {
                return;
            }

            using (var login = new go.Forms.Logon(Datas.Communications))
            {
                if (login.ShowDialog() != DialogResult.OK)
                    throw new Exception("User cancelled login");
            }

            username = Datas.Username;
            password = Datas.Password;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("No credentials provided");
            }
        }


        private void ValidateLogin(string loginResponse)
        {
            if (
                loginResponse.Contains("Sign in") ||
                loginResponse.Contains("To access the site you have to sign in first")
            )
            {
                throw new Exception(
                    "Invalid username or password."
                );
            }

            if (
                !loginResponse.Contains("Logout") &&
                !loginResponse.Contains("Log out") &&
                !loginResponse.Contains(username)
            )
            {
                throw new Exception(
                    "Login validation failed."
                );
            }
        }


        private void ResetSession()
        {
            IsLoggedIn = false;

            username = "";
            password = "";

            Datas.Username = "";
            Datas.Password = "";

            rememberPassword = false;
        }


        private string GetHomePage()
        {
            HttpWebRequest homeRequest =
                this.CreateRequest("gpro.asp");

            using (HttpWebResponse response =
                (HttpWebResponse)homeRequest.GetResponse())
            using (StreamReader reader =
                new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }


        private void LoadAccountData(string homePage)
        {
            this.GetData(
                Regex.Replace(homePage, "[\r\t\n]", "")
            );
        }


        private void PerformLogin()
        {
            string loginUrl =
                go.Utils.Util.URI + "Login.asp?Redirect=gpro.asp";

            string postData =
                "textLogin=" + this.ConvertToHtmlEncoding(username) +
                "&textPassword=" + this.ConvertToHtmlEncoding(password) +
                "&Logon=Login";

            HttpWebRequest loginRequest =
                this.CreateRequest(loginUrl, "POST");

            loginRequest.ContentType =
                "application/x-www-form-urlencoded";

            byte[] bytes = Encoding.UTF8.GetBytes(postData);

            loginRequest.ContentLength = bytes.Length;

            using (Stream requestStream = loginRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }

            string loginResponse;

            using (HttpWebResponse response =
                (HttpWebResponse)loginRequest.GetResponse())
            using (StreamReader reader =
                new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                loginResponse = reader.ReadToEnd();
            }

            ValidateLogin(loginResponse);

            LoadAccountData(GetHomePage());
        }


        public void Login(string origin)
        {
            if (_loginInProgress)
                return;
        
            _loginInProgress = true;
        
            try
            {
                EnsureCredentials();
        
                PerformLogin();
        
                IsLoggedIn = true;
            }
            catch (Exception ex)
            {
                ResetSession();
        
                MessageBox.Show(
                    "Login failed.\n\n" + ex.Message,
                    "Authentication Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                _loginInProgress = false;
            }
        }


        private void CheckPage(string page)
        {
            if (page.IndexOf("Offices are currently closed!") > 0 && (page.IndexOf("Season Position") < 0 || page.IndexOf("Technical Director:") < 0) || page.IndexOf("Post-race update in progress:") > 0)
            {
                Exception exception = new Exception("Offices are currently closed");
                this.IsLoggedIn = false;
                throw exception;
            }
            if (page.IndexOf("<h1>Quick login</h1>") <= 0)
                return;
        }

        private static bool SetAllowUnsafeHeaderParsing20()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(SettingsSection));
            if (assembly != (Assembly)null)
            {
                System.Type type = assembly.GetType("System.Net.Configuration.SettingsSectionInternal");
                if (type != (System.Type)null)
                {
                    object obj = type.InvokeMember("Section", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetProperty, (Binder)null, (object)null, new object[0]);
                    if (obj != null)
                    {
                        FieldInfo field = type.GetField("useUnsafeHeaderParsing", BindingFlags.Instance | BindingFlags.NonPublic);
                        if (field != (FieldInfo)null)
                        {
                            field.SetValue(obj, (object)true);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public string GetVersion()
        {
            using (WebClient webClient = new WebClient())
            {
                using (StreamReader streamReader = new StreamReader(webClient.OpenRead("https://sourceforge.net/projects/gpro-organizer-2/best_release.json")))
                    return streamReader.ReadToEnd();
            }
        }

        public string GetReadme()
        {
            using (WebClient webClient = new WebClient())
            {
                using (StreamReader streamReader = new StreamReader(webClient.OpenRead("https://sourceforge.net/projects/gpro-organizer-2/files/README.txt")))
                    return streamReader.ReadToEnd();
            }
        }

        public string GetPage(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest =
                    this.CreateRequest(url);

                string end =
                    new StreamReader(
                        httpWebRequest.GetResponse().GetResponseStream(),
                        Encoding.UTF8
                    ).ReadToEnd();

                if (end.Contains("To access the site you have to sign in first"))
                {
                    this.IsLoggedIn = false;

                    throw new Exception(
                        "Session expired or authentication failed."
                    );
                }
                
                if (
                    end.Contains("Quick login") ||
                    end.Contains("sign in first") ||
                    end.Contains("Access denied") ||
                    end.Length < 5000
                )
                {
                    File.WriteAllText(
                        "debug_" + url.Replace("/", "_").Replace("?", "_") + ".html",
                        end
                    );
                }

                this.CheckPage(end);

                return Regex.Replace(
                    Regex.Replace(
                        Regex.Replace(
                            end,
                            "<ul(.*?)languages(.*?)>(.*?)</ul>",
                            string.Empty,
                            Communication.options
                        ),
                        "[\r\t\n]",
                        string.Empty,
                        Communication.options
                    ),
                    "[ ]{2,}",
                    " ",
                    Communication.options
                );
            }
            catch
            {
                int num = (int)MessageBox.Show("Error trying to communicate with GPRO site: " + url, "Comms error");
                throw;
            }
        }

        public void GetData(string homePage)
        {
            this.CheckPage(homePage);

            try
            {
                Date date = new Date();

                var match = Regex.Match(
                    homePage,
                    @"Season\s+(\d+),\s+Race\s+(\d+)"
                );

                if (!match.Success)
                {
                    throw new Exception("Could not parse season/race from homepage.");
                }

                date.season = int.Parse(match.Groups[1].Value);
                date.race = int.Parse(match.Groups[2].Value);

                Datas.Date = date;

                int startIndex3 = homePage.IndexOf("DriverProfile.asp") + 21;
                this.driverid = startIndex3 <= 21 ? 0 : int.Parse(homePage.Substring(startIndex3, homePage.IndexOf("\"", startIndex3) - startIndex3));
                if (homePage.IndexOf("TechDProfile.asp") > 0)
                {
                    int startIndex4 = homePage.IndexOf("TechDProfile.asp") + 20;
                    this.TechDid = int.Parse(homePage.Substring(startIndex4, homePage.IndexOf("\"", startIndex4) - startIndex4));
                }
                else
                    this.TechDid = 0;
                if (homePage.IndexOf("<a href=\"TeamProfile.asp?") > 0)
                {
                    int startIndex5 = homePage.IndexOf("<a href=\"TeamProfile.asp?");
                    int startIndex6 = homePage.IndexOf(">", startIndex5) + 1;
                    this.teamName = this.ConvertFromUrlEncoding(homePage.Substring(startIndex6, homePage.IndexOf("<", startIndex6) - startIndex6));
                }
                else
                    this.teamName = "";
                int startIndex7 = homePage.IndexOf("<a href=\"ManagerProfile.asp?IDM") + 32;
                this.managerID = int.Parse(homePage.Substring(startIndex7, homePage.IndexOf("\"", startIndex7) - startIndex7));
                int startIndex8 = homePage.IndexOf(">", startIndex7) + 1;
                this.managerName = this.ConvertFromUrlEncoding(homePage.Substring(startIndex8, homePage.IndexOf("<", startIndex8) - startIndex8));
                int startIndex9 = homePage.IndexOf("<a href=\"Q12History.asp?Group") + 30;
                this.groupName = this.ConvertFromUrlEncoding(homePage.Substring(startIndex9, homePage.IndexOf("\">", startIndex9) - startIndex9));
            }
            catch (Exception ex)
            {
                GenericParser.HandleError("Error trying to understand main page", ex, homePage);
            }
        }

        public int GetDriverID()
        {
            return this.driverid;
        }

        public int GetTechDID() => this.TechDid;

        public Date GetDate()
        {
            return Datas.Date;
        }

        private string ConvertToHtmlEncoding(string value) => Uri.EscapeDataString(value);

        public string ConvertToPageEncoding(string input) => WebUtility.HtmlEncode(input);

        public string ConvertFromUrlEncoding(string input) => WebUtility.HtmlDecode(input);
    }
}
