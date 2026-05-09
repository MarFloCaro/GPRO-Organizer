// Decompiled with JetBrains decompiler
// Type: go.Forms.Logon
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class Logon : Form
  {
    private Label label1;
    private Label label2;
    public TextBox boxUsername;
    public TextBox boxPassword;
    private Button button1;
    private Button button2;
    public CheckBox checkBoxRememberPassword;
    public bool logon;

    public Logon() => this.InitializeComponent();

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.boxUsername = new TextBox();
      this.boxPassword = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.checkBoxRememberPassword = new CheckBox();
      this.SuspendLayout();
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(56, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Username";
      this.label2.Location = new Point(8, 32);
      this.label2.Name = "label2";
      this.label2.Size = new Size(56, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password";
      this.boxUsername.Location = new Point(72, 8);
      this.boxUsername.Name = "boxUsername";
      this.boxUsername.Size = new Size(104, 20);
      this.boxUsername.TabIndex = 0;
      this.boxUsername.Text = "";
      this.boxPassword.Location = new Point(72, 32);
      this.boxPassword.Name = "boxPassword";
      this.boxPassword.PasswordChar = '*';
      this.boxPassword.Size = new Size(104, 20);
      this.boxPassword.TabIndex = 1;
      this.boxPassword.Text = "";
      this.button1.Location = new Point(8, 96);
      this.button1.Name = "button1";
      this.button1.TabIndex = 3;
      this.button1.Text = "Ok";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.Location = new Point(96, 96);
      this.button2.Name = "button2";
      this.button2.TabIndex = 5;
      this.button2.Text = "Cancel";
      this.button2.Click += new EventHandler(this.button2_Click);
      this.checkBoxRememberPassword.Location = new Point(16, 64);
      this.checkBoxRememberPassword.Name = "checkBoxRememberPassword";
      this.checkBoxRememberPassword.Size = new Size(160, 24);
      this.checkBoxRememberPassword.TabIndex = 2;
      this.checkBoxRememberPassword.Text = "Remember my password";
      this.checkBoxRememberPassword.CheckedChanged += new EventHandler(this.checkBoxRememberPassword_CheckedChanged);
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(184, 126);
      this.ControlBox = false;
      this.Controls.Add((Control) this.checkBoxRememberPassword);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.boxPassword);
      this.Controls.Add((Control) this.boxUsername);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Logon);
      this.Text = "GPRO Logon";
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.logon = true;
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.logon = false;
      this.Close();
    }

    private void checkBoxRememberPassword_CheckedChanged(object sender, EventArgs e)
    {
    }
  }
}
