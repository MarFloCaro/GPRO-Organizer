// Decompiled with JetBrains decompiler
// Type: go.Forms.PitstopsForm
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class PitstopsForm : GoForm
  {
    private Button button1;

    public PitstopsForm()
      : base("PitStopsForm")
    {
      this.InitializeComponent();
      this.ExtraInit();
      this.DisplayComponents();
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void ExtraInit()
    {
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.FullRowSelect = true;
      this.listView1.Location = new Point(0, 0);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(this.Width - 8, this.Height - 68);
      this.listView1.TabIndex = 0;
      this.listView1.View = View.Details;
      this.listView1.ContextMenu = this.contextMenu1;
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PitstopsForm));
      this.button1 = new Button();
      this.SuspendLayout();
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(144, 232);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(231, 259);
      this.Controls.Add((Control) this.button1);
      this.Icon = Resources.Car;
      this.MinimumSize = new Size(152, 258);
      this.Name = nameof (PitstopsForm);
      this.Text = "GPRO Organizer : Pitstops (BETA)";
      this.Controls.SetChildIndex((Control) this.button1, 0);
      this.Controls.SetChildIndex((Control) this.listView1, 0);
      this.ResumeLayout(false);
    }
  }
}
