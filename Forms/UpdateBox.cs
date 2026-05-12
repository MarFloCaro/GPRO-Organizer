 
// Type: go.Forms.UpdateBox
 
 
 

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class UpdateBox : Form
  {
    private Label label1;
    private LinkLabel linkLabel1;
    private Button buttonOk;
    private Button buttonUpdate;

    public UpdateBox() => this.InitializeComponent();

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UpdateBox));
      this.label1 = new Label();
      this.linkLabel1 = new LinkLabel();
      this.buttonOk = new Button();
      this.buttonUpdate = new Button();
      this.SuspendLayout();
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(268, 64);
      this.label1.TabIndex = 0;
      this.label1.Text = "There is a new version of Go available. Please go to the website and get the latest version.";
      this.linkLabel1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.linkLabel1.Location = new Point(32, 84);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(236, 23);
      this.linkLabel1.TabIndex = 1;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "http://www.mbjerg.dk/gpro";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.buttonOk.DialogResult = DialogResult.Cancel;
      this.buttonOk.Font = new Font("Microsoft Sans Serif", 8f);
      this.buttonOk.Location = new Point(148, 116);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new Size(88, 23);
      this.buttonOk.TabIndex = 1;
      this.buttonOk.Text = "Update &Later";
      this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
      this.buttonUpdate.Location = new Point(48, 116);
      this.buttonUpdate.Name = "buttonUpdate";
      this.buttonUpdate.Size = new Size(88, 23);
      this.buttonUpdate.TabIndex = 0;
      this.buttonUpdate.Text = "Update &Now";
      this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
      this.AcceptButton = (IButtonControl) this.buttonUpdate;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.buttonOk;
      this.ClientSize = new Size(292, 146);
      this.ControlBox = false;
      this.Controls.Add((Control) this.buttonUpdate);
      this.Controls.Add((Control) this.buttonOk);
      this.Controls.Add((Control) this.linkLabel1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = Resources.Resources.Car;
      this.Name = nameof (UpdateBox);
      this.Text = "New version available";
      this.ResumeLayout(false);
    }

    private void buttonOk_Click(object sender, EventArgs e) => this.Close();

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        this.VisitLink2();
      }
      catch
      {
        int num = (int) MessageBox.Show("Unable to open link that was clicked.");
      }
    }

    private void VisitLink2()
    {
      this.linkLabel1.LinkVisited = true;
      Process.Start("http://www.mbjerg.dk/gpro");
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
      this.linkLabel1_LinkClicked((object) null, (LinkLabelLinkClickedEventArgs) null);
      Application.Exit();
    }
  }
}
