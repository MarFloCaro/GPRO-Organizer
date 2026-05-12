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
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

#nullable disable
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
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
            Communication.SetAllowUnsafeHeaderParsing20();
        }

        internal Communication(string username, string password)
          : this()
        {
            this.username = username;
            this.password = password;
        }

        internal Communication(bool rememberPassword, string managerName, string teamName)
          : this()
        {
            this.rememberPassword = rememberPassword;
            this.managerName = managerName;
            this.teamName = teamName;
        }

        public bool IsLoggedIn { get; set; }

        private void Login()
        {
            //var logon1 = new Logon();

            //logon1.boxUsername.Text = Datas.Username;
            //logon1.boxPassword.Text = Datas.Password;
            //Logon logon2 = logon1;
            //if (!Datas.Communications.rememberPassword || Datas.Password == "")
            //{
            //    logon2.ShowDialog();
            //    //if (!logon2.ShouldLogin)
            //    //{
            //    //    throw new Exception("Login cancelled by user");
            //    //}
            //}
            //Datas.Communications.rememberPassword = logon2._rememberPasswordCheckBox.Checked;
            //Datas.Username = logon2.boxUsername.Text;
            //Datas.Password = logon2.boxPassword.Text;
            string s = "textLogin=" + this.ConvertToHtmlEncoding(Datas.Username) + "&textPassword=" + this.ConvertToHtmlEncoding(Datas.Password) + "&Logon=Login";
            HttpWebRequest httpWebRequest1 = (HttpWebRequest)WebRequest.Create(go.Utils.Util.URI + "Login.asp?Redirect=gpro.asp");
            httpWebRequest1.CookieContainer = this.cookieContainer;
            httpWebRequest1.UserAgent = "GO";
            httpWebRequest1.Method = "POST";
            httpWebRequest1.ContentType = "application/x-www-form-urlencoded";
            byte[] bytes = new UTF8Encoding().GetBytes(s);
            httpWebRequest1.ContentLength = (long)bytes.Length;
            Stream requestStream = httpWebRequest1.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            if (new StreamReader(httpWebRequest1.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd().IndexOf("To access the site you have to sign in first") > 0)
            {
                this.IsLoggedIn = false;
                Datas.Communications.rememberPassword = false;
                //this.Login();
            }
            HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(go.Utils.Util.URI + "gpro.asp");
            httpWebRequest2.CookieContainer = this.cookieContainer;
            httpWebRequest2.UserAgent = "GO";
            httpWebRequest2.Method = "GET";
            httpWebRequest2.Timeout = 20000;
            this.GetData(Regex.Replace(new StreamReader(httpWebRequest2.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd(), "[\r\t\n]", ""));
            this.IsLoggedIn = true;
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
            this.Login();
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
                if (!this.IsLoggedIn)
                    this.Login();
                url = go.Utils.Util.URI + url;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.CookieContainer = this.cookieContainer;
                httpWebRequest.UserAgent = "GO";
                httpWebRequest.Method = "GET";
                httpWebRequest.Timeout = 20000;
                string end = new StreamReader(httpWebRequest.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd();
                if (end.IndexOf("To access the site you have to sign in first") > 0)
                {
                    this.IsLoggedIn = false;
                    return this.GetPage(url);
                }
                this.CheckPage(end);
                return Regex.Replace(Regex.Replace(Regex.Replace(end, "<ul(.*?)languages(.*?)>(.*?)</ul>", string.Empty, Communication.options), "[\r\t\n]", string.Empty, Communication.options), "[ ]{2,}", " ", Communication.options);
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
            Console.WriteLine(homePage);
            try
            {
                Date date = new Date();
                int startIndex1 = homePage.IndexOf("Season") + 7;
                if (homePage.IndexOf(",", startIndex1) == -1)
                {
                    date.season = Datas.Seasons.LastOrDefault<Season20>().Season;
                }
                else
                {
                    string s = homePage.Substring(startIndex1, homePage.IndexOf(",", startIndex1) - startIndex1);
                    try
                    {
                        date.season = int.Parse(s);
                    }
                    catch (FormatException ex)
                    {
                        date.season = Datas.Seasons.LastOrDefault<Season20>().Season;
                        if (date.season == 0)
                            date.season = 19;
                    }
                }
                if (homePage.IndexOf("<strong>End of Season") > 0)
                {
                    date.race = 18;
                }
                else
                {
                    int startIndex2 = homePage.IndexOf("Race", startIndex1) + 5;
                    string s = homePage.Substring(startIndex2, homePage.IndexOf(":", startIndex2) - startIndex2);
                    date.race = int.Parse(s);
                }
                if (Datas.Date.race != date.race || Datas.Date.season != date.season)
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
            if (!this.IsLoggedIn)
                this.Login();
            return this.driverid;
        }

        public int GetTechDID() => this.TechDid;

        public Date GetDate()
        {
            if (!this.IsLoggedIn)
                this.Login();
            return Datas.Date;
        }

        public string GetRaw(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.UserAgent = "GO";
            httpWebRequest.Method = "GET";
            return new StreamReader(httpWebRequest.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd();
        }

        public string ConvertToHtmlEncoding(string input) => HttpUtility.UrlEncode(input);

        public string ConvertToPageEncoding(string input) => HttpUtility.HtmlEncode(input);

        public string ConvertFromUrlEncoding(string input) => HttpUtility.HtmlDecode(input);
    }
}
