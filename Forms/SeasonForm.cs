// Decompiled with JetBrains decompiler
// Type: go.Forms.SeasonForm
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using go.Utils;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class SeasonForm : GoForm
  {
    private Button button1;

    public SeasonForm()
      : base(nameof (SeasonForm))
    {
      this.InitializeComponent();
      this.ExtraInit();
      this.DisplayComponents();
      this.ListAll();
    }

    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (SeasonForm));
      this.button1 = new Button();
      this.SuspendLayout();
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(153, 269);
      this.button1.Name = "button1";
      this.button1.TabIndex = 1;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(241, 299);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.listView1);
      this.Icon = Properties.Resources.Car;
      this.MinimumSize = new Size(249, 333);
      this.Name = nameof (SeasonForm);
      this.Text = "GO: Season Tracks";
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void listView1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      this.listView1_DoubleClick(sender, (EventArgs) null);
    }

    private void listView1_DoubleClick(object sender, EventArgs e)
    {
      if (this.listView1.SelectedIndices.Count == 0)
        return;
      int selectedIndex = this.listView1.SelectedIndices[0];
      if (!Datas.Seasons[Datas.Seasons.Count - 1].Events[selectedIndex].isRaceUpdated)
        return;
      new RaceForm(Datas.Seasons[Datas.Seasons.Count - 1].Events[selectedIndex], Datas.Tracks[selectedIndex]).Show();
    }

    private void ExtraInit()
    {
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.FullRowSelect = true;
      this.listView1.Location = new Point(0, 0);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(this.Width - 8, this.Height - 72);
      this.listView1.TabIndex = 0;
      this.listView1.View = View.Details;
      this.listView1.KeyPress += new KeyPressEventHandler(this.listView1_KeyPress);
      this.listView1.DoubleClick += new EventHandler(this.listView1_DoubleClick);
      this.listView1.ContextMenu = this.contextMenu1;
    }

    protected override void ListAll()
    {
      this.listView1.Items.Clear();
      if (Datas.Seasons.Count == 0)
        return;
      for (int index = 0; index < Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events.Length; ++index)
      {
        ListViewItem listViewItem = new ListViewItem();
        foreach (ColumnInfo column in this.formInfo.columnInfo)
        {
          bool found = false;
          this.checkTrack(column, ref found, listViewItem, Datas.Seasons[Datas.INDEX_CURRENTSEASON].Events[index].Trackid - 1);
          if (!found)
          {
            if (column == ColumnInfo.StintRace)
              listViewItem.SubItems.Add((index + 1).ToString());
            else
              listViewItem.SubItems.Add("-");
          }
        }
        if (listViewItem.SubItems.Count > 1)
        {
          listViewItem.Text = listViewItem.SubItems[1].Text;
          listViewItem.SubItems.RemoveAt(0);
          if (index < Datas.Date.race)
            listViewItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Strikeout);
          this.listView1.Items.Add(listViewItem);
        }
      }
    }
  }
}
