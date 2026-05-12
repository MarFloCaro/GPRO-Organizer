 
// Type: go.Forms.HistoricalTyreWearForm
 
 
 

using go.Enums;
using go.Utils;
using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class HistoricalTyreWearForm : GoForm
  {
    private const string formname = "TyreWear";
    private bool updateDriver = true;
    private Button button1;
    private Label label3;
    private Label label5;
    private ComboBox comboBoxTyres;
    private ComboBox comboBoxWear;
    private ComboBox comboBoxName;
    private Label label1;
    private Label label2;
    private TextBox textBoxTrack;
    private TextBox textBoxWear;
    private TextBox textBoxMinT;
    private TextBox textBoxMaxT;
    private TextBox textBoxMinH;
    private TextBox textBoxMaxH;
    private Label label4;
    private Label label6;
    private Label removeStintsLabel;
    private TextBox removeStintsWithLessLaps;
    private ComboBox comboBoxDriver;

    public HistoricalTyreWearForm()
      : base("TyreWear")
    {
      this.InitializeComponent();
      this.removeStintsWithLessLaps.Text = (string) Registry.CurrentUser.CreateSubKey("Software\\go\\GUI").GetValue("HistoricalTyreWearSkip");
      this.listView1.ListViewItemSorter = (IComparer) this.lvwColumnSorter;
      int index = Datas.Seasons.Count - 1;
      if (Datas.Tracks == null || Datas.Date == null)
        return;
      if (Datas.Date.race > 0 && Datas.Date.race < 18 && Datas.Seasons[Datas.Seasons.Count - 1] != null && Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1] != null && Datas.Tracks[Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1].Trackid - 1] != null)
      {
        this.textBoxTrack.Text = Datas.Tracks[Datas.Seasons[index].Events[Datas.Date.race - 1].Trackid - 1].name;
        this.textBoxWear.Text = EnumToString.Enum2String(Datas.Tracks[Datas.Seasons[index].Events[Datas.Date.race - 1].Trackid - 1].tyreWear);
      }
      switch (this.textBoxWear.Text)
      {
        case "Very low":
          this.comboBoxWear.SelectedIndex = 1;
          break;
        case "Low":
          this.comboBoxWear.SelectedIndex = 2;
          break;
        case "Medium":
          this.comboBoxWear.SelectedIndex = 3;
          break;
        case "High":
          this.comboBoxWear.SelectedIndex = 4;
          break;
        case "Very high":
          this.comboBoxWear.SelectedIndex = 5;
          break;
        default:
          this.comboBoxWear.SelectedIndex = 0;
          break;
      }
      this.ExtraInit();
      this.DisplayComponents();
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HistoricalTyreWearForm));
      this.button1 = new Button();
      this.comboBoxTyres = new ComboBox();
      this.label3 = new Label();
      this.label5 = new Label();
      this.textBoxMinT = new TextBox();
      this.textBoxMaxT = new TextBox();
      this.textBoxMinH = new TextBox();
      this.textBoxMaxH = new TextBox();
      this.comboBoxWear = new ComboBox();
      this.comboBoxName = new ComboBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.textBoxTrack = new TextBox();
      this.textBoxWear = new TextBox();
      this.label4 = new Label();
      this.label6 = new Label();
      this.removeStintsLabel = new Label();
      this.removeStintsWithLessLaps = new TextBox();
      this.comboBoxDriver = new ComboBox();
      this.SuspendLayout();
      this.listView1.Location = new Point(8, 80);
      this.listView1.Size = new Size(340, 41);
      this.listView1.TabIndex = 9;
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(876, 128);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 10;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.exit_Click);
      this.comboBoxTyres.Items.AddRange(new object[6]
      {
        (object) "All",
        (object) "Extra Soft",
        (object) "Soft",
        (object) "Medium",
        (object) "Hard",
        (object) "Rain"
      });
      this.comboBoxTyres.Location = new Point(264, 33);
      this.comboBoxTyres.Name = "comboBoxTyres";
      this.comboBoxTyres.Size = new Size(72, 21);
      this.comboBoxTyres.TabIndex = 2;
      this.comboBoxTyres.Text = "Tyres";
      this.comboBoxTyres.SelectedIndexChanged += new EventHandler(this.SomethingChanged);
      this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label3.Location = new Point(736, 36);
      this.label3.Name = "label3";
      this.label3.Size = new Size(56, 16);
      this.label3.TabIndex = 9;
      this.label3.Text = "< Temp <";
      this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label5.Location = new Point(864, 36);
      this.label5.Name = "label5";
      this.label5.Size = new Size(48, 16);
      this.label5.TabIndex = 11;
      this.label5.Text = "< Hum <";
      this.textBoxMinT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.textBoxMinT.Location = new Point(716, 32);
      this.textBoxMinT.Name = "textBoxMinT";
      this.textBoxMinT.Size = new Size(20, 20);
      this.textBoxMinT.TabIndex = 5;
      this.textBoxMinT.Text = "0";
      this.textBoxMinT.TextAlign = HorizontalAlignment.Right;
      this.textBoxMinT.TextChanged += new EventHandler(this.textBox_TextChanged);
      this.textBoxMinT.KeyUp += new KeyEventHandler(this.textBox_KeyUp);
      this.textBoxMinT.MouseDown += new MouseEventHandler(this.textBox_OnFocus);
      this.textBoxMaxT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.textBoxMaxT.Location = new Point(784, 32);
      this.textBoxMaxT.Name = "textBoxMaxT";
      this.textBoxMaxT.Size = new Size(24, 20);
      this.textBoxMaxT.TabIndex = 6;
      this.textBoxMaxT.Text = "99";
      this.textBoxMaxT.TextAlign = HorizontalAlignment.Right;
      this.textBoxMaxT.TextChanged += new EventHandler(this.textBox_TextChanged);
      this.textBoxMaxT.KeyUp += new KeyEventHandler(this.textBox_KeyUp);
      this.textBoxMaxT.MouseDown += new MouseEventHandler(this.textBox_OnFocus);
      this.textBoxMinH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.textBoxMinH.Location = new Point(844, 32);
      this.textBoxMinH.Name = "textBoxMinH";
      this.textBoxMinH.Size = new Size(20, 20);
      this.textBoxMinH.TabIndex = 7;
      this.textBoxMinH.Text = "0";
      this.textBoxMinH.TextAlign = HorizontalAlignment.Right;
      this.textBoxMinH.TextChanged += new EventHandler(this.textBox_TextChanged);
      this.textBoxMinH.KeyUp += new KeyEventHandler(this.textBox_KeyUp);
      this.textBoxMinH.MouseDown += new MouseEventHandler(this.textBox_OnFocus);
      this.textBoxMaxH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.textBoxMaxH.Location = new Point(908, 32);
      this.textBoxMaxH.Name = "textBoxMaxH";
      this.textBoxMaxH.Size = new Size(24, 20);
      this.textBoxMaxH.TabIndex = 8;
      this.textBoxMaxH.Text = "99";
      this.textBoxMaxH.TextAlign = HorizontalAlignment.Right;
      this.textBoxMaxH.TextChanged += new EventHandler(this.textBox_TextChanged);
      this.textBoxMaxH.KeyUp += new KeyEventHandler(this.textBox_KeyUp);
      this.textBoxMaxH.MouseDown += new MouseEventHandler(this.textBox_OnFocus);
      this.comboBoxWear.Items.AddRange(new object[6]
      {
        (object) "All",
        (object) "Very low",
        (object) "Low",
        (object) "Medium",
        (object) "High",
        (object) "Very high"
      });
      this.comboBoxWear.Location = new Point(176, 32);
      this.comboBoxWear.Name = "comboBoxWear";
      this.comboBoxWear.Size = new Size(72, 21);
      this.comboBoxWear.TabIndex = 1;
      this.comboBoxWear.Text = "Wear";
      this.comboBoxWear.SelectedIndexChanged += new EventHandler(this.SomethingChanged);
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
      this.label2.Location = new Point(200, 8);
      this.label2.Name = "label2";
      this.label2.Size = new Size(64, 16);
      this.label2.TabIndex = 19;
      this.label2.Text = "Track wear:";
      this.textBoxTrack.BorderStyle = BorderStyle.None;
      this.textBoxTrack.Location = new Point(72, 8);
      this.textBoxTrack.Name = "textBoxTrack";
      this.textBoxTrack.ReadOnly = true;
      this.textBoxTrack.Size = new Size(78, 13);
      this.textBoxTrack.TabIndex = 20;
      this.textBoxTrack.TabStop = false;
      this.textBoxTrack.Text = "Unknown";
      this.textBoxWear.BorderStyle = BorderStyle.None;
      this.textBoxWear.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBoxWear.Location = new Point(264, 8);
      this.textBoxWear.Name = "textBoxWear";
      this.textBoxWear.ReadOnly = true;
      this.textBoxWear.Size = new Size(78, 13);
      this.textBoxWear.TabIndex = 21;
      this.textBoxWear.TabStop = false;
      this.textBoxWear.Text = "Unknown";
      this.label4.Location = new Point(112, 36);
      this.label4.Name = "label4";
      this.label4.Size = new Size(64, 20);
      this.label4.TabIndex = 22;
      this.label4.Text = "Tyre wear:";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(648, 36);
      this.label6.Name = "label6";
      this.label6.Size = new Size(26, 13);
      this.label6.TabIndex = 33;
      this.label6.Text = "laps";
      this.removeStintsLabel.AutoSize = true;
      this.removeStintsLabel.Location = new Point(476, 35);
      this.removeStintsLabel.Name = "removeStintsLabel";
      this.removeStintsLabel.Size = new Size(141, 13);
      this.removeStintsLabel.TabIndex = 32;
      this.removeStintsLabel.Text = "Remove stints with less than";
      this.removeStintsWithLessLaps.Location = new Point(623, 31);
      this.removeStintsWithLessLaps.Name = "removeStintsWithLessLaps";
      this.removeStintsWithLessLaps.RightToLeft = RightToLeft.Yes;
      this.removeStintsWithLessLaps.Size = new Size(19, 20);
      this.removeStintsWithLessLaps.TabIndex = 4;
      this.removeStintsWithLessLaps.Text = "0";
      this.removeStintsWithLessLaps.TextAlign = HorizontalAlignment.Right;
      this.removeStintsWithLessLaps.TextChanged += new EventHandler(this.textBox_TextChanged);
      this.removeStintsWithLessLaps.KeyUp += new KeyEventHandler(this.textBox_KeyUp);
      this.removeStintsWithLessLaps.MouseDown += new MouseEventHandler(this.textBox_OnFocus);
      this.comboBoxDriver.FormattingEnabled = true;
      this.comboBoxDriver.Location = new Point(355, 33);
      this.comboBoxDriver.Name = "comboBoxDriver";
      this.comboBoxDriver.Size = new Size(91, 21);
      this.comboBoxDriver.TabIndex = 3;
      this.comboBoxDriver.Text = "Driver";
      this.comboBoxDriver.SelectedIndexChanged += new EventHandler(this.comboBoxDriver_SelectedIndexChanged);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(964, 158);
      this.Controls.Add((Control) this.comboBoxDriver);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.removeStintsLabel);
      this.Controls.Add((Control) this.removeStintsWithLessLaps);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.textBoxWear);
      this.Controls.Add((Control) this.textBoxTrack);
      this.Controls.Add((Control) this.textBoxMaxH);
      this.Controls.Add((Control) this.textBoxMinH);
      this.Controls.Add((Control) this.textBoxMaxT);
      this.Controls.Add((Control) this.textBoxMinT);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.comboBoxName);
      this.Controls.Add((Control) this.comboBoxWear);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.comboBoxTyres);
      this.Controls.Add((Control) this.button1);
      this.Icon = Resources.Resources.Car;
      this.MinimumSize = new Size(632, 152);
      this.Name = nameof (HistoricalTyreWearForm);
      this.Text = "GPRO Organizer : Historical Tyre Wear";
      this.Controls.SetChildIndex((Control) this.button1, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxTyres, 0);
      this.Controls.SetChildIndex((Control) this.label3, 0);
      this.Controls.SetChildIndex((Control) this.label5, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxWear, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxName, 0);
      this.Controls.SetChildIndex((Control) this.label1, 0);
      this.Controls.SetChildIndex((Control) this.label2, 0);
      this.Controls.SetChildIndex((Control) this.listView1, 0);
      this.Controls.SetChildIndex((Control) this.textBoxMinT, 0);
      this.Controls.SetChildIndex((Control) this.textBoxMaxT, 0);
      this.Controls.SetChildIndex((Control) this.textBoxMinH, 0);
      this.Controls.SetChildIndex((Control) this.textBoxMaxH, 0);
      this.Controls.SetChildIndex((Control) this.textBoxTrack, 0);
      this.Controls.SetChildIndex((Control) this.textBoxWear, 0);
      this.Controls.SetChildIndex((Control) this.label4, 0);
      this.Controls.SetChildIndex((Control) this.removeStintsWithLessLaps, 0);
      this.Controls.SetChildIndex((Control) this.removeStintsLabel, 0);
      this.Controls.SetChildIndex((Control) this.label6, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxDriver, 0);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void PrepareTrackNames()
    {
      this.comboBoxName.Items.Clear();
      foreach (Track track in Datas.Tracks)
        this.comboBoxName.Items.Add((object) track.name);
      ArrayList.Adapter((IList) this.comboBoxName.Items).Sort();
      this.comboBoxName.Items.Insert(0, (object) "All");
    }

    private void UpdateList()
    {
      this.listView1.Items.Clear();
      int selectedIndex1 = this.comboBoxTyres.SelectedIndex;
      int selectedIndex2 = this.comboBoxName.SelectedIndex;
      int selectedIndex3 = this.comboBoxWear.SelectedIndex;
      int num1 = int.Parse(this.textBoxMinT.Text);
      int num2 = int.Parse(this.textBoxMaxT.Text);
      int num3 = int.Parse(this.textBoxMinH.Text);
      int num4 = int.Parse(this.textBoxMaxH.Text);
      int selectedIndex4 = this.comboBoxDriver.SelectedIndex;
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      if (selectedIndex1 > 0)
        str2 = (string) this.comboBoxTyres.Items[selectedIndex1];
      if (selectedIndex2 > 0)
        str3 = (string) this.comboBoxName.Items[selectedIndex2];
      if (selectedIndex3 > 0)
        str4 = (string) this.comboBoxWear.Items[selectedIndex3];
      if (selectedIndex4 > 0)
        str1 = (string) this.comboBoxDriver.Items[selectedIndex4];
      this.comboBoxDriver.Items.Clear();
      this.comboBoxDriver.Items.Add((object) "All");
      foreach (Season20 season in Datas.Seasons)
      {
        if (season != null)
        {
          for (int index1 = 0; index1 < season.Events.Length; ++index1)
          {
            if (season.Events[index1] != null && season.Events[index1].Race != null)
            {
              Race9 race = season.Events[index1].Race;
              TechnicalDirector technicalDirector = season.Events[index1].TechnicalDirector;
              Strategy4 strat = season.Events[index1].Strat;
              bool isStrategyUpdated = season.Events[index1].isStrategyUpdated;
              if (race.CalcTyres != null)
              {
                Car2 startcar = season.Events[index1].Startcar;
                Driver5 driver = season.Events[index1].Driver;
                Staff staff = season.Events[index1].Staff;
                if (driver.name != "" && !this.comboBoxDriver.Items.Contains((object) driver.name))
                  this.comboBoxDriver.Items.Add((object) driver.name);
                TyreSupplier tyresupplier = season.Events[index1].Tyresupplier;
                for (int index2 = 0; race.CalcTyres != null && index2 < race.CalcTyres.Length; ++index2)
                {
                  CalculatedTyreWear calcTyre = race.CalcTyres[index2];
                  if (calcTyre != null)
                  {
                    int num5;
                    string str5;
                    if (index2 != race.CalcFuel.Length - 1)
                    {
                      num5 = index2 + 1;
                      str5 = num5.ToString();
                    }
                    else
                      str5 = "race";
                    string text1 = str5;
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
                      if (isStrategyUpdated)
                        this.checkRisk(column, ref found, listViewItem, strat);
                      if (!found)
                      {
                        switch (column)
                        {
                          case ColumnInfo.StintTyreType:
                            if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                            {
                              listViewItem.SubItems.Add(EnumToString.Enum2String(race.CalcTyres[index2].tyres));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintMinTemp:
                            listViewItem.SubItems.Add(calcTyre.minTemp.ToString());
                            continue;
                          case ColumnInfo.StintMaxTemp:
                            listViewItem.SubItems.Add(calcTyre.maxTemp.ToString());
                            continue;
                          case ColumnInfo.StintAvgTemp:
                            listViewItem.SubItems.Add(calcTyre.avgTemp.ToString("N2"));
                            continue;
                          case ColumnInfo.StintMinHum:
                            listViewItem.SubItems.Add(calcTyre.minHum.ToString());
                            continue;
                          case ColumnInfo.StintMaxHum:
                            listViewItem.SubItems.Add(calcTyre.maxHum.ToString());
                            continue;
                          case ColumnInfo.StintAvgHum:
                            listViewItem.SubItems.Add(calcTyre.avgHum.ToString("N2"));
                            continue;
                          case ColumnInfo.StintSeason:
                            ListViewItem.ListViewSubItemCollection subItems1 = listViewItem.SubItems;
                            num5 = season.Season;
                            string text2 = num5.ToString();
                            subItems1.Add(text2);
                            continue;
                          case ColumnInfo.StintRace:
                            ListViewItem.ListViewSubItemCollection subItems2 = listViewItem.SubItems;
                            num5 = index1 + 1;
                            string text3 = num5.ToString();
                            subItems2.Add(text3);
                            continue;
                          case ColumnInfo.StintNumber:
                            listViewItem.SubItems.Add(text1);
                            continue;
                          case ColumnInfo.StintLaps:
                            listViewItem.SubItems.Add(calcTyre.laps.ToString());
                            continue;
                          case ColumnInfo.StintKm:
                            listViewItem.SubItems.Add(calcTyre.km.ToString("N3"));
                            continue;
                          case ColumnInfo.StintBadKm:
                            if (race.CalcTyres != null && race.CalcTyres.Length > index2 && race.CalcTyres[index2].badAtKm > 0.0)
                            {
                              listViewItem.SubItems.Add(race.CalcTyres[index2].badAtKm.ToString("N3"));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintBadPercent:
                            if (race.CalcTyres != null && race.CalcTyres.Length > index2 && race.CalcTyres[index2].badAtPercent > 0.0)
                            {
                              listViewItem.SubItems.Add(race.CalcTyres[index2].badAtPercent.ToString("N2"));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintFinalPercent:
                            if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                            {
                              listViewItem.SubItems.Add(race.CalcTyres[index2].finalPercentage.ToString());
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintEstimatedTyreDuration:
                            if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                            {
                              listViewItem.SubItems.Add(race.CalcTyres[index2].estimatedDuration.ToString("N2"));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintFuel:
                            if (race.CalcFuel != null && race.CalcFuel.Length > index2)
                            {
                              listViewItem.SubItems.Add(race.CalcFuel[index2].fuelUsed.ToString("N1"));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintFuelConsumption:
                            if (race.CalcFuel != null && race.CalcFuel.Length > index2)
                            {
                              listViewItem.SubItems.Add(race.CalcFuel[index2].consumption.ToString("N3"));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintWeather:
                            listViewItem.SubItems.Add(race.CalcFuel[index2].weather);
                            continue;
                          default:
                            listViewItem.SubItems.Add("-");
                            continue;
                        }
                      }
                    }
                    if (listViewItem.SubItems.Count > 1 && (selectedIndex1 <= 0 || !(str2 != EnumToString.Enum2String(race.CalcTyres[index2].tyres))) && (selectedIndex2 <= 0 || !(Datas.Tracks[season.Events[index1].Trackid - 1].name != str3)) && (selectedIndex3 <= 0 || !(str4 != EnumToString.Enum2String(Datas.Tracks[season.Events[index1].Trackid - 1].tyreWear))) && (selectedIndex4 <= 0 || !(str1 != driver.name)) && calcTyre.minTemp >= num1 && calcTyre.maxTemp <= num2 && calcTyre.minHum >= num3 && calcTyre.maxHum <= num4 && calcTyre.laps >= int.Parse(this.removeStintsWithLessLaps.Text))
                    {
                      listViewItem.Text = listViewItem.SubItems[1].Text;
                      listViewItem.SubItems.RemoveAt(0);
                      this.listView1.Items.Add(listViewItem);
                    }
                  }
                }
              }
            }
          }
        }
      }
      if (str1 == null)
        return;
      int num6 = this.comboBoxDriver.Items.IndexOf((object) str1);
      if (num6 == -1)
        num6 = 0;
      this.updateDriver = false;
      this.comboBoxDriver.SelectedIndex = num6;
      this.updateDriver = true;
    }

    private void SomethingChanged(object sender, EventArgs e)
    {
      RegistryKey subKey = Registry.CurrentUser.CreateSubKey("Software\\go\\GUI");
      subKey.SetValue("HistoricalTyreWearSkip", (object) this.removeStintsWithLessLaps.Text);
      subKey.Close();
      this.UpdateList();
    }

    private void exit_Click(object sender, EventArgs e) => this.Close();

    private void textBox_TextChanged(object sender, EventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      try
      {
        int num = int.Parse(textBox.Text);
        if (num >= 0 && num <= 99)
          return;
        textBox.Text = "0";
        textBox.SelectAll();
      }
      catch
      {
        textBox.Text = "0";
        textBox.SelectAll();
      }
    }

    private void textBox_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
        this.SomethingChanged((object) null, (EventArgs) e);
      e.Handled = true;
    }

    private void ExtraInit()
    {
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.FullRowSelect = true;
      this.listView1.Location = new Point(0, 56);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(this.Width - 8, this.Height - 124);
      this.listView1.TabIndex = 9;
      this.listView1.View = View.Details;
      this.listView1.ContextMenu = this.contextMenu1;
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

    private void textBox_OnFocus(object sender, MouseEventArgs e)
    {
      ((Control) sender).Focus();
      ((TextBoxBase) sender).SelectAll();
    }

    private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.updateDriver)
        return;
      this.SomethingChanged(sender, e);
    }
  }
}
