// Decompiled with JetBrains decompiler
// Type: go.Forms.AboutForm
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Utils;
using Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class AboutForm : Form
  {
    private Label label1;
    private PictureBox pictureBox1;
    private Label label2;
    private Label label3;
    private LinkLabel linkLabel2;
    private Button button1;
    private Label label4;
    private TextBox textBoxVersion;

    public AboutForm()
    {
      this.InitializeComponent();
      this.textBoxVersion.Text = Datas.Version.ToString();
    }

    protected override void Dispose(bool disposing) => base.Dispose(disposing);

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.pictureBox1 = new PictureBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.textBoxVersion = new TextBox();
      this.linkLabel2 = new LinkLabel();
      this.button1 = new Button();
      this.label4 = new Label();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.Font = new Font("Arial", 32.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(70, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(40, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "G";
      this.pictureBox1.Image = (Image) Resources.CarPng;
      this.pictureBox1.Location = new Point(110, 8);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(32, 32);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.label2.Font = new Font("Segoe UI", 9f);
      this.label2.Location = new Point(61, 43);
      this.label2.Name = "label2";
      this.label2.Size = new Size(100, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "GPRO Organizer \u00B2";
      this.label3.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
      this.label3.Location = new Point(14, 67);
      this.label3.Name = "label3";
      this.label3.Size = new Size(69, 18);
      this.label3.TabIndex = 3;
      this.label3.Text = "Version :";
      this.textBoxVersion.BackColor = Color.White;
      this.textBoxVersion.BorderStyle = BorderStyle.None;
      this.textBoxVersion.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
      this.textBoxVersion.Location = new Point(83, 67);
      this.textBoxVersion.Name = "textBoxVersion";
      this.textBoxVersion.ReadOnly = true;
      this.textBoxVersion.Size = new Size((int) sbyte.MaxValue, 18);
      this.textBoxVersion.TabIndex = 4;
      this.textBoxVersion.TabStop = false;
      this.textBoxVersion.Text = "9.9.91.99999";
      this.textBoxVersion.TextAlign = HorizontalAlignment.Right;
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new Point(36, 99);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new Size(155, 13);
      this.linkLabel2.TabIndex = 6;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "GPro Organizer 2 - Sourceforge";
      this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Location = new Point(142, 148);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.Button1Click);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(45, 123);
      this.label4.Name = "label4";
      this.label4.Size = new Size(132, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "gpro.organizer@gmail.com";
      this.AutoScaleBaseSize = new Size(5, 13);
      this.BackColor = Color.White;
      this.ClientSize = new Size(222, 174);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.linkLabel2);
      this.Controls.Add((Control) this.textBoxVersion);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = Resources.Car;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AboutForm);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "About GO";
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
      this.linkLabel2.LinkVisited = true;
      Process.Start("https://sourceforge.net/projects/gpro-organizer-2/");
    }

    private void Button1Click(object sender, EventArgs e) => this.Close();
  }
}
