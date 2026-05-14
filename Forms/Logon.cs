using go.Utils;
using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace go.Forms
{
    public class Logon : Form
    {
        private static bool _isLoginSuccessful;

        public TextBox boxUsername;
        public TextBox boxPassword;

        private CheckBox _rememberPasswordCheckBox;
        private Label _usernameLabel;
        private Label _passwordLabel;
        private Button _okButton;
        private Button _cancelButton;
        private go.Comms.Communication _comms;

        public (string user, string pass) Credentials { get; private set; }
        
        public Logon(go.Comms.Communication comms)
        {
            InitializeComponent();

            GetRegistrySettings();

            _comms = comms;

        }

/*        [STAThread]
        private static void Main()
        {
            // try read cached credentials
            // if empty => show dialog
            // else tryLogin
            //GetRegistrySettings();

            var app = new Logon();
            Application.Run((Form)app);

            if (_isLoginSuccessful)
            {
                Application.Run(new MainForm());
            }
        }
*/

        public string ConvertToHtmlEncoding(string input) => HttpUtility.UrlEncode(input);

        public bool ShouldTryLogin()
        {
            // try read cached credentials
            // if empty => show dialog

            var result = this.ShowDialog();
            return result == DialogResult.OK;
        }

        public bool TryLogin()
        {
            Console.WriteLine("Trying to Login");
            Datas.Communications.rememberPassword = _rememberPasswordCheckBox.Checked;
            Datas.Username = boxUsername.Text;
            Datas.Password = boxPassword.Text;
            string s = "textLogin=" + this.ConvertToHtmlEncoding(Datas.Username) + "&textPassword=" +
                       this.ConvertToHtmlEncoding(Datas.Password) + "&Logon=Login";
            HttpWebRequest httpWebRequest1 =
                (HttpWebRequest) WebRequest.Create(go.Utils.Util.URI + "Login.asp?Redirect=gpro.asp");
            httpWebRequest1.CookieContainer = new CookieContainer();
            httpWebRequest1.UserAgent = "GO";
            httpWebRequest1.Method = "POST";
            httpWebRequest1.ContentType = "application/x-www-form-urlencoded";
            byte[] bytes = new UTF8Encoding().GetBytes(s);
            httpWebRequest1.ContentLength = (long) bytes.Length;
            Stream requestStream = httpWebRequest1.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();

            var response1 =
                new StreamReader(httpWebRequest1.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd();
            Console.WriteLine(response1);

            if (response1.IndexOf("To access the site you have to sign in first") > 0)
            {
                return false;
            }

            Datas.Communications.IsLoggedIn = true;
            _isLoginSuccessful = true;
            return true;
        }

        private void InitializeComponent()
        {
            this._usernameLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._rememberPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _usernameLabel
            // 
            this._usernameLabel.Location = new System.Drawing.Point(8, 8);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(56, 23);
            this._usernameLabel.TabIndex = 0;
            this._usernameLabel.Text = "Username";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.Location = new System.Drawing.Point(8, 32);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(56, 23);
            this._passwordLabel.TabIndex = 1;
            this._passwordLabel.Text = "Password";
            // 
            // boxUsername
            // 
            this.boxUsername.Location = new System.Drawing.Point(72, 8);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(104, 20);
            this.boxUsername.TabIndex = 0;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(72, 32);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.PasswordChar = '*';
            this.boxPassword.Size = new System.Drawing.Size(104, 20);
            this.boxPassword.TabIndex = 1;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(8, 96);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 3;
            this._okButton.Text = global::Resources.Resources.Ok;
            this._okButton.Click += new System.EventHandler(OnOkButtonClick);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(96, 96);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 5;
            this._cancelButton.Text = global::Resources.Resources.Cancel;
            this._cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // _rememberPasswordCheckBox
            // 
            this._rememberPasswordCheckBox.Location = new System.Drawing.Point(16, 64);
            this._rememberPasswordCheckBox.Name = "_rememberPasswordCheckBox";
            this._rememberPasswordCheckBox.Size = new System.Drawing.Size(160, 24);
            this._rememberPasswordCheckBox.TabIndex = 2;
            this._rememberPasswordCheckBox.Text = global::Resources.Resources.RememberPassword;
            // 
            // Logon
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(184, 126);
            this.ControlBox = false;
            this.Controls.Add(this._rememberPasswordCheckBox);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._usernameLabel);
            this.Name = "Logon";
            this.Text = "GPRO Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void OnOkButtonClick(object sender, EventArgs e)
        {
            if (TryLogin())
            {
                Datas.Communications.username = boxUsername.Text;
                Datas.Communications.password = boxPassword.Text;
                SaveRegistrySettings();
                Datas.Communications.rememberPassword = _rememberPasswordCheckBox.Checked;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Login error", "OK");
            }
        }

        private void SaveRegistrySettings()
        {
            var registry = Registry.CurrentUser.CreateSubKey("Software\\go");
            registry.SetValue("Username", (object)Datas.Communications.username);
            if (Datas.Communications.rememberPassword)
                registry.SetValue("Password", (object)EncDec.Encrypt(Datas.Communications.password, "phdsp98q4tæqæræosalæx-lkdsvjipo.LKLDUSFÆIREp98 w3rp98y<ÆH æFp9843æiohfp9y<ftg"));
            else
                registry.SetValue("Password", (object)"none");
            registry.SetValue("AutoCheck", Datas.AutoCheck ? (object)"Yes" : (object)"No");
            registry.SetValue("KeepDataWithProgram", Datas.KeepDataWithApp ? (object)"Yes" : (object)"No");
            registry.Close();
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GetRegistrySettings()
        {
            //Datas.Communications.rememberPassword = false;
            RegistryKey subKey1 = Registry.CurrentUser.CreateSubKey("Software\\go");
            Datas.Username = (string)subKey1.GetValue("Username");
            string cipherText = (string)subKey1.GetValue("Password");
            if (cipherText != null)
            {
                if (cipherText != "none")
                {
                    try
                    {
                        Datas.Password = EncDec.Decrypt(cipherText, "phdsp98q4tæqæræosalæx-lkdsvjipo.LKLDUSFÆIREp98 w3rp98y<ÆH æFp9843æiohfp9y<ftg");
                        if (Datas.Password != "")
                            Datas.Communications.rememberPassword = true;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show("Unable to retrieve password from registry.", "Error loading password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Errlog.AddToLog("GetRegistrySettings: " + ex.Message);
                    }
                }
            }
            if ((string)subKey1.GetValue("AutoCheck") == "Yes")
            {
                Datas.AutoCheck = true;
                //this.CheckVersion();
            }
            else
                //this.statusBarPanelVersion.Text = "Version check disabled";
            if ((string)subKey1.GetValue("KeepDataWithProgram") == "Yes")
                Datas.KeepDataWithApp = true;
            subKey1.Close();

        }

    }
}
