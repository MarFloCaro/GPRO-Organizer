// Decompiled with JetBrains decompiler
// Type: go.Forms.TrackNote
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Utils;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class TrackNote : Form
  {
    public string note = "";
    private int index;
    private Button button1;
    private Button button2;
    private TextBox textBox1;

    public TrackNote(int index, string trackName)
    {
      this.InitializeComponent();
      this.index = index;
      this.Text = "GPRO Organizer Track Note : " + trackName;
      this.textBox1.Text = Datas.TrackNotes[index];
    }

    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (TrackNote));
      this.button1 = new Button();
      this.button2 = new Button();
      this.textBox1 = new TextBox();
      this.SuspendLayout();
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.Location = new Point(344, 440);
      this.button1.Name = "button1";
      this.button1.TabIndex = 0;
      this.button1.Text = "&Ok";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button2.Location = new Point(264, 440);
      this.button2.Name = "button2";
      this.button2.TabIndex = 1;
      this.button2.Text = "&Cancel";
      this.button2.Click += new EventHandler(this.button2_Click);
      this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.textBox1.Location = new Point(8, 8);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = ScrollBars.Vertical;
      this.textBox1.Size = new Size(408, 424);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "";
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(424, 470);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Icon = Properties.Resources.Car;
      this.Name = nameof (TrackNote);
      this.Text = nameof (TrackNote);
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Datas.TrackNotes[this.index] = this.textBox1.Text;
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();
  }
}
