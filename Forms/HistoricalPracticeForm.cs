// Decompiled with JetBrains decompiler
// Type: go.Forms.HistoricalPracticeForm
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using go.Utils;
using Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class HistoricalPracticeForm : GoForm
  {
    private bool updateDriver = true;
    private Button button1;
    private ComboBox comboBoxName;
    private Label label1;
    private TextBox textBoxTrack;
    private GroupBox groupBox1;
    private TextBox textBoxPracticeComments;
    private ComboBox comboBoxDriver;

    public HistoricalPracticeForm()
      : base("HistoricalPractice")
    {
      this.InitializeComponent();
      this.listView1.ListViewItemSorter = (IComparer) this.lvwColumnSorter;
      int index = Datas.Seasons.Count - 1;
      if (Datas.Tracks == null || Datas.Date == null)
        return;
      this.ExtraInit();
      this.DisplayComponents();
      if (Datas.Date.race <= 0 || Datas.Date.race >= 18 || Datas.Seasons[Datas.Seasons.Count - 1] == null || Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1] == null || Datas.Tracks[Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1].Trackid - 1] == null)
        return;
      this.textBoxTrack.Text = Datas.Tracks[Datas.Seasons[index].Events[Datas.Date.race - 1].Trackid - 1].name;
      this.comboBoxName.Text = this.textBoxTrack.Text;
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HistoricalPracticeForm));
      this.button1 = new Button();
      this.comboBoxName = new ComboBox();
      this.label1 = new Label();
      this.textBoxTrack = new TextBox();
      this.groupBox1 = new GroupBox();
      this.textBoxPracticeComments = new TextBox();
      this.comboBoxDriver = new ComboBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.listView1.Location = new Point(14, 80);
      this.listView1.Size = new Size(236, 122);
      this.listView1.TabIndex = 2;
      this.listView1.SelectedIndexChanged += new EventHandler(this.selectedIndexChanged);
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(771, 379);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.exit_Click);
      this.comboBoxName.Items.AddRange(new object[1]
      {
        (object) "All"
      });
      this.comboBoxName.Location = new Point(14, 32);
      this.comboBoxName.Name = "comboBoxName";
      this.comboBoxName.Size = new Size(96, 21);
      this.comboBoxName.TabIndex = 0;
      this.comboBoxName.Text = "Track";
      this.comboBoxName.SelectedIndexChanged += new EventHandler(this.SomethingChanged);
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(64, 16);
      this.label1.TabIndex = 18;
      this.label1.Text = "Next Race:";
      this.textBoxTrack.BorderStyle = BorderStyle.None;
      this.textBoxTrack.Location = new Point(72, 8);
      this.textBoxTrack.Name = "textBoxTrack";
      this.textBoxTrack.ReadOnly = true;
      this.textBoxTrack.Size = new Size(78, 13);
      this.textBoxTrack.TabIndex = 20;
      this.textBoxTrack.TabStop = false;
      this.textBoxTrack.Text = "Unknown";
      this.groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.groupBox1.Controls.Add((Control) this.textBoxPracticeComments);
      this.groupBox1.Location = new Point(14, 238);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(831, 135);
      this.groupBox1.TabIndex = 21;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Comments";
      this.textBoxPracticeComments.Location = new Point(6, 12);
      this.textBoxPracticeComments.Multiline = true;
      this.textBoxPracticeComments.Name = "textBoxPracticeComments";
      this.textBoxPracticeComments.ReadOnly = true;
      this.textBoxPracticeComments.ScrollBars = ScrollBars.Both;
      this.textBoxPracticeComments.Size = new Size(819, 117);
      this.textBoxPracticeComments.TabIndex = 0;
      this.comboBoxDriver.FormattingEnabled = true;
      this.comboBoxDriver.Location = new Point(143, 32);
      this.comboBoxDriver.Name = "comboBoxDriver";
      this.comboBoxDriver.Size = new Size(91, 21);
      this.comboBoxDriver.TabIndex = 1;
      this.comboBoxDriver.Text = "Driver";
      this.comboBoxDriver.SelectedIndexChanged += new EventHandler(this.comboBoxDriver_SelectedIndexChanged);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(859, 409);
      this.Controls.Add((Control) this.comboBoxDriver);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.textBoxTrack);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.comboBoxName);
      this.Controls.Add((Control) this.button1);
      this.Icon = Resources.Car;
      this.MinimumSize = new Size(632, 152);
      this.Name = nameof (HistoricalPracticeForm);
      this.Text = "GPRO Organizer : Historical Practice Rounds";
      this.Controls.SetChildIndex((Control) this.button1, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxName, 0);
      this.Controls.SetChildIndex((Control) this.label1, 0);
      this.Controls.SetChildIndex((Control) this.listView1, 0);
      this.Controls.SetChildIndex((Control) this.textBoxTrack, 0);
      this.Controls.SetChildIndex((Control) this.groupBox1, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxDriver, 0);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void UpdateList()
    {
      this.listView1.Items.Clear();
      if (Datas.Tracks == null || Datas.Seasons == null || Datas.Date == null)
        return;
      int selectedIndex1 = this.comboBoxName.SelectedIndex;
      int selectedIndex2 = this.comboBoxDriver.SelectedIndex;
      string str1 = "";
      string str2 = "";
      if (selectedIndex1 >= 0)
        str1 = (string) this.comboBoxName.Items[selectedIndex1];
      if (selectedIndex2 > 0)
        str2 = (string) this.comboBoxDriver.Items[selectedIndex2];
      this.comboBoxDriver.Items.Clear();
      this.comboBoxDriver.Items.Add((object) "All");
      foreach (Season20 season in Datas.Seasons)
      {
        if (season != null)
        {
          for (int index1 = 0; index1 < season.Events.Length; ++index1)
          {
            if (season.Events[index1] != null && season.Events[index1].Practise != null)
            {
              Practice3 practise = season.Events[index1].Practise;
              Staff staff = season.Events[index1].Staff;
              TechnicalDirector technicalDirector = season.Events[index1].TechnicalDirector;
              Car2 startcar = season.Events[index1].Startcar;
              Driver5 driver = season.Events[index1].Driver;
              if (driver.name != "" && !this.comboBoxDriver.Items.Contains((object) driver.name))
                this.comboBoxDriver.Items.Add((object) driver.name);
              TyreSupplier tyresupplier = season.Events[index1].Tyresupplier;
              int num = 0;
              foreach (PracticeRun run in practise.runs)
              {
                if (!run.netTime.Equals(TimeSpan.Zero))
                {
                  ++num;
                  ListViewItem listViewItem = new ListViewItem()
                  {
                    UseItemStyleForSubItems = false
                  };
                  foreach (ColumnInfo column in this.formInfo.columnInfo)
                  {
                    bool found = false;
                    this.checkTrack(column, ref found, listViewItem, season.Events[index1].Trackid - 1);
                    this.checkDriver(column, ref found, listViewItem, driver);
                    this.checkStaff(column, ref found, listViewItem, staff);
                    this.checkTechnicalDirector(column, ref found, listViewItem, technicalDirector);
                    if (startcar != null)
                      this.checkCar(column, ref found, listViewItem, startcar);
                    this.checkTyreSupplier(column, ref found, listViewItem, tyresupplier);
                    if (!found)
                    {
                      switch (column)
                      {
                        case ColumnInfo.StintSeason:
                          listViewItem.SubItems.Add(season.Season.ToString());
                          continue;
                        case ColumnInfo.StintRace:
                          listViewItem.SubItems.Add((index1 + 1).ToString());
                          continue;
                        case ColumnInfo.PracticeLapTime:
                          listViewItem.SubItems.Add(EnumToString.Time2PracExportString(run.lapTime, true));
                          continue;
                        case ColumnInfo.PracticeDriverMistake:
                          listViewItem.SubItems.Add(EnumToString.Time2PracExportString(run.driverMistake, true));
                          continue;
                        case ColumnInfo.PracticeNetTime:
                          listViewItem.SubItems.Add(EnumToString.Time2PracExportString(run.netTime, true));
                          continue;
                        case ColumnInfo.PracticeFrontWing:
                          listViewItem.SubItems.Add(run.setup.fWing.ToString());
                          continue;
                        case ColumnInfo.PracticeRearWing:
                          listViewItem.SubItems.Add(run.setup.rWing.ToString());
                          continue;
                        case ColumnInfo.PracticeEngine:
                          listViewItem.SubItems.Add(run.setup.engine.ToString());
                          continue;
                        case ColumnInfo.PracticeBrakes:
                          listViewItem.SubItems.Add(run.setup.brakes.ToString());
                          continue;
                        case ColumnInfo.PracticeGear:
                          listViewItem.SubItems.Add(run.setup.gear.ToString());
                          continue;
                        case ColumnInfo.PracticeSuspension:
                          listViewItem.SubItems.Add(run.setup.susp.ToString());
                          continue;
                        case ColumnInfo.PracticeTyreType:
                          listViewItem.SubItems.Add(EnumToString.Enum2String(run.setup.tyres));
                          continue;
                        case ColumnInfo.PracticeWeather:
                          listViewItem.SubItems.Add(EnumToString.Enum2String(practise.weather.skies));
                          continue;
                        case ColumnInfo.PracticeTemperature:
                          listViewItem.SubItems.Add(practise.weather.temperature.ToString());
                          continue;
                        case ColumnInfo.PracticeHumidity:
                          listViewItem.SubItems.Add(practise.weather.humidity.ToString());
                          continue;
                        case ColumnInfo.PracticeLapNumber:
                          listViewItem.SubItems.Add(num.ToString());
                          continue;
                        default:
                          listViewItem.SubItems.Add("-");
                          continue;
                      }
                    }
                  }
                  if (listViewItem.SubItems.Count > 1 && (selectedIndex1 <= 0 || !(Datas.Tracks[season.Events[index1].Trackid - 1].name != str1)) && (selectedIndex2 <= 0 || !(str2 != driver.name)))
                  {
                    listViewItem.Text = listViewItem.SubItems[1].Text;
                    listViewItem.SubItems.RemoveAt(0);
                    string text = "";
                    for (int index2 = 0; index2 < run.comments.Length; ++index2)
                    {
                      text += run.comments[index2];
                      if (index2 % 2 == 1 && index2 < run.comments.Length - 1)
                        text += "\r\n";
                      if (index2 % 2 == 0 && index2 < run.comments.Length - 1)
                        text += ": ";
                    }
                    listViewItem.SubItems.Add(text);
                    this.listView1.Items.Add(listViewItem);
                  }
                }
                else
                  break;
              }
            }
          }
        }
      }
      if (str2 == null)
        return;
      int num1 = this.comboBoxDriver.Items.IndexOf((object) str2);
      if (num1 == -1)
        num1 = 0;
      this.updateDriver = false;
      this.comboBoxDriver.SelectedIndex = num1;
      this.updateDriver = true;
    }

    private void SomethingChanged(object sender, EventArgs e) => this.UpdateList();

    private void exit_Click(object sender, EventArgs e) => this.Close();

    private void ExtraInit()
    {
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.FullRowSelect = true;
      this.listView1.Location = new Point(0, 56);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(this.Width - 8, this.Height - 260);
      this.listView1.TabIndex = 2;
      this.listView1.View = View.Details;
      this.listView1.ContextMenu = this.contextMenu1;
    }

    private void PrepareTrackNames()
    {
      this.comboBoxName.Items.Clear();
      foreach (Track track in Datas.Tracks)
        this.comboBoxName.Items.Add((object) track.name);
      ArrayList.Adapter((IList) this.comboBoxName.Items).Sort();
      this.comboBoxName.Items.Insert(0, (object) "All");
    }

    protected override void ListAll()
    {
      this.listView1.Items.Clear();
      this.PrepareTrackNames();
      base.ListAll();
      if (Datas.Tracks == null || Datas.Seasons == null || Datas.Date == null)
        return;
      this.UpdateList();
    }

    private void selectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listView1.SelectedIndices.Count == 0)
      {
        this.textBoxPracticeComments.Text = "";
      }
      else
      {
        ListViewItem selectedItem = this.listView1.SelectedItems[0];
        this.textBoxPracticeComments.Text = selectedItem.SubItems[selectedItem.SubItems.Count - 1].Text;
      }
    }

    private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.updateDriver)
        return;
      this.SomethingChanged(sender, e);
    }
  }
}
