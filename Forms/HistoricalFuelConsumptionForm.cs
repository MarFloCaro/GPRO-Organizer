 
// Type: go.Forms.HistoricalFuelConsumptionForm
 
 
 

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
  public class HistoricalFuelConsumptionForm : GoForm
  {
    private bool updateDriver = true;
    private Button exitButton;
    private TextBox textBoxTrack;
    private Label label2;
    private Label label1;
    private ComboBox comboBoxName;
    private ComboBox comboBoxUsage;
    private TextBox textBoxUsage;
    private CheckBox checkBoxStints;
    private Label removeStintsLabel;
    private TextBox removeStintsWithLessLaps;
    private Label label3;
    private ComboBox comboBoxDriver;

    public HistoricalFuelConsumptionForm()
      : base("FuelConsumption")
    {
      this.InitializeComponent();
      this.removeStintsWithLessLaps.Text = (string) Registry.CurrentUser.CreateSubKey("Software\\go\\GUI").GetValue("HistoricalFuelConsumptionSkip");
      this.ExtraInit();
      this.listView1.ListViewItemSorter = (IComparer) this.lvwColumnSorter;
      string text = this.textBoxUsage.Text;
      this.DisplayComponents();
      switch (text)
      {
        case "Very low":
          this.comboBoxUsage.SelectedIndex = 1;
          break;
        case "Low":
          this.comboBoxUsage.SelectedIndex = 2;
          break;
        case "Medium":
          this.comboBoxUsage.SelectedIndex = 3;
          break;
        case "High":
          this.comboBoxUsage.SelectedIndex = 4;
          break;
        case "Very high":
          this.comboBoxUsage.SelectedIndex = 5;
          break;
        default:
          this.comboBoxUsage.SelectedIndex = 0;
          break;
      }
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HistoricalFuelConsumptionForm));
      this.exitButton = new Button();
      this.textBoxTrack = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.comboBoxName = new ComboBox();
      this.comboBoxUsage = new ComboBox();
      this.textBoxUsage = new TextBox();
      this.checkBoxStints = new CheckBox();
      this.removeStintsWithLessLaps = new TextBox();
      this.removeStintsLabel = new Label();
      this.label3 = new Label();
      this.comboBoxDriver = new ComboBox();
      this.SuspendLayout();
      this.listView1.Location = new Point(8, 64);
      this.listView1.Size = new Size(680, 200);
      this.listView1.TabIndex = 5;
      this.exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.exitButton.DialogResult = DialogResult.Cancel;
      this.exitButton.Location = new Point(616, 280);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new Size(75, 23);
      this.exitButton.TabIndex = 6;
      this.exitButton.Text = "E&xit";
      this.exitButton.Click += new EventHandler(this.exit_Click);
      this.textBoxTrack.BorderStyle = BorderStyle.None;
      this.textBoxTrack.Location = new Point(72, 8);
      this.textBoxTrack.Name = "textBoxTrack";
      this.textBoxTrack.ReadOnly = true;
      this.textBoxTrack.Size = new Size(78, 13);
      this.textBoxTrack.TabIndex = 25;
      this.textBoxTrack.TabStop = false;
      this.textBoxTrack.Text = "Unknown";
      this.label2.Location = new Point(176, 8);
      this.label2.Name = "label2";
      this.label2.Size = new Size(104, 16);
      this.label2.TabIndex = 24;
      this.label2.Text = "Track consumption:";
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(64, 16);
      this.label1.TabIndex = 23;
      this.label1.Text = "Next Race:";
      this.comboBoxName.Items.AddRange(new object[1]
      {
        (object) "All"
      });
      this.comboBoxName.Location = new Point(4, 32);
      this.comboBoxName.Name = "comboBoxName";
      this.comboBoxName.Size = new Size(96, 21);
      this.comboBoxName.TabIndex = 0;
      this.comboBoxName.Text = "Track";
      this.comboBoxName.SelectedIndexChanged += new EventHandler(this.SomethingChanged);
      this.comboBoxUsage.Items.AddRange(new object[6]
      {
        (object) "All",
        (object) "Very low",
        (object) "Low",
        (object) "Medium",
        (object) "High",
        (object) "Very high"
      });
      this.comboBoxUsage.Location = new Point(100, 32);
      this.comboBoxUsage.Name = "comboBoxUsage";
      this.comboBoxUsage.Size = new Size(72, 21);
      this.comboBoxUsage.TabIndex = 1;
      this.comboBoxUsage.Text = "Usage";
      this.comboBoxUsage.SelectedIndexChanged += new EventHandler(this.SomethingChanged);
      this.textBoxUsage.BorderStyle = BorderStyle.None;
      this.textBoxUsage.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBoxUsage.Location = new Point(280, 8);
      this.textBoxUsage.Name = "textBoxUsage";
      this.textBoxUsage.ReadOnly = true;
      this.textBoxUsage.Size = new Size(78, 13);
      this.textBoxUsage.TabIndex = 26;
      this.textBoxUsage.TabStop = false;
      this.textBoxUsage.Text = "Unknown";
      this.checkBoxStints.Checked = true;
      this.checkBoxStints.CheckState = CheckState.Checked;
      this.checkBoxStints.Location = new Point(288, 30);
      this.checkBoxStints.Name = "checkBoxStints";
      this.checkBoxStints.Size = new Size(120, 16);
      this.checkBoxStints.TabIndex = 3;
      this.checkBoxStints.Text = "Include stints data";
      this.checkBoxStints.CheckedChanged += new EventHandler(this.SomethingChanged);
      this.removeStintsWithLessLaps.Location = new Point(561, 28);
      this.removeStintsWithLessLaps.Name = "removeStintsWithLessLaps";
      this.removeStintsWithLessLaps.RightToLeft = RightToLeft.Yes;
      this.removeStintsWithLessLaps.Size = new Size(19, 20);
      this.removeStintsWithLessLaps.TabIndex = 4;
      this.removeStintsWithLessLaps.Text = "0";
      this.removeStintsWithLessLaps.TextAlign = HorizontalAlignment.Right;
      this.removeStintsWithLessLaps.TextChanged += new EventHandler(this.removeStintsWithLessLaps_TextChanged);
      this.removeStintsWithLessLaps.KeyUp += new KeyEventHandler(this.removeStintsWithLessLaps_KeyUp);
      this.removeStintsWithLessLaps.Enter += new EventHandler(this.removeStintsWithLess_OnFocus);
      this.removeStintsLabel.AutoSize = true;
      this.removeStintsLabel.Location = new Point(414, 32);
      this.removeStintsLabel.Name = "removeStintsLabel";
      this.removeStintsLabel.Size = new Size(141, 13);
      this.removeStintsLabel.TabIndex = 29;
      this.removeStintsLabel.Text = "Remove stints with less than";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(586, 33);
      this.label3.Name = "label3";
      this.label3.Size = new Size(26, 13);
      this.label3.TabIndex = 30;
      this.label3.Text = "laps";
      this.comboBoxDriver.FormattingEnabled = true;
      this.comboBoxDriver.Location = new Point(179, 33);
      this.comboBoxDriver.Name = "comboBoxDriver";
      this.comboBoxDriver.Size = new Size(91, 21);
      this.comboBoxDriver.TabIndex = 2;
      this.comboBoxDriver.Text = "Driver";
      this.comboBoxDriver.SelectedIndexChanged += new EventHandler(this.DriverChanged);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.exitButton;
      this.ClientSize = new Size(704, 310);
      this.Controls.Add((Control) this.comboBoxDriver);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.removeStintsLabel);
      this.Controls.Add((Control) this.removeStintsWithLessLaps);
      this.Controls.Add((Control) this.checkBoxStints);
      this.Controls.Add((Control) this.textBoxUsage);
      this.Controls.Add((Control) this.textBoxTrack);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.comboBoxName);
      this.Controls.Add((Control) this.comboBoxUsage);
      this.Controls.Add((Control) this.exitButton);
      this.Icon = Resources.Resources.Car;
      this.Name = nameof (HistoricalFuelConsumptionForm);
      this.Text = "GPRO Organizer : Historical Fuel Consumption";
      this.Controls.SetChildIndex((Control) this.listView1, 0);
      this.Controls.SetChildIndex((Control) this.exitButton, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxUsage, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxName, 0);
      this.Controls.SetChildIndex((Control) this.label1, 0);
      this.Controls.SetChildIndex((Control) this.label2, 0);
      this.Controls.SetChildIndex((Control) this.textBoxTrack, 0);
      this.Controls.SetChildIndex((Control) this.textBoxUsage, 0);
      this.Controls.SetChildIndex((Control) this.checkBoxStints, 0);
      this.Controls.SetChildIndex((Control) this.removeStintsWithLessLaps, 0);
      this.Controls.SetChildIndex((Control) this.removeStintsLabel, 0);
      this.Controls.SetChildIndex((Control) this.label3, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxDriver, 0);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void exit_Click(object sender, EventArgs e) => this.Close();

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
      int selectedIndex1 = this.comboBoxName.SelectedIndex;
      int selectedIndex2 = this.comboBoxUsage.SelectedIndex;
      int selectedIndex3 = this.comboBoxDriver.SelectedIndex;
      string str1 = "";
      string str2 = "";
      string str3 = "";
      if (selectedIndex1 > 0)
        str1 = (string) this.comboBoxName.Items[selectedIndex1];
      if (selectedIndex3 > 0)
        str3 = (string) this.comboBoxDriver.Items[selectedIndex3];
      if (selectedIndex2 > 0)
        str2 = (string) this.comboBoxUsage.Items[selectedIndex2];
      this.comboBoxDriver.Items.Clear();
      this.comboBoxDriver.Items.Add((object) "All");
      foreach (Season20 season in Datas.Seasons)
      {
        if (season != null)
        {
          for (int index1 = 0; index1 < season.Events.Length; ++index1)
          {
            if (season.Events[index1] != null && season.Events[index1].Race != null && season.Events[index1].Startcar != null)
            {
              Race9 race = season.Events[index1].Race;
              Car2 startcar = season.Events[index1].Startcar;
              TechnicalDirector technicalDirector = season.Events[index1].TechnicalDirector;
              TyreSupplier tyresupplier = season.Events[index1].Tyresupplier;
              Staff staff = season.Events[index1].Staff;
              Driver5 driver = new Driver5();
              Strategy4 strategy = (Strategy4) null;
              if (season.Events[index1].isStrategyUpdated)
                strategy = season.Events[index1].Strat;
              if (season.Events[index1].isDriverUpdated)
              {
                driver = season.Events[index1].Driver;
                if (driver.name != "" && !this.comboBoxDriver.Items.Contains((object) driver.name))
                  this.comboBoxDriver.Items.Add((object) driver.name);
              }
              if (race.CalcFuel != null)
              {
                for (int index2 = 0; race.CalcFuel != null && index2 < race.CalcFuel.Length; ++index2)
                {
                  CalculatedFuelConsumption calculatedFuelConsumption = race.CalcFuel[index2];
                  if (calculatedFuelConsumption != null)
                  {
                    int num;
                    string str4;
                    if (index2 != race.CalcFuel.Length - 1)
                    {
                      num = index2 + 1;
                      str4 = num.ToString();
                    }
                    else
                      str4 = "race";
                    string text1 = str4;
                    ListViewItem listViewItem = new ListViewItem()
                    {
                      UseItemStyleForSubItems = false
                    };
                    foreach (ColumnInfo column in this.formInfo.columnInfo)
                    {
                      bool found = false;
                      this.checkTrack(column, ref found, listViewItem, season.Events[index1].Trackid - 1);
                      this.checkDriver(column, ref found, listViewItem, driver);
                      this.checkCar(column, ref found, listViewItem, startcar);
                      this.checkTyreSupplier(column, ref found, listViewItem, tyresupplier);
                      this.checkTechnicalDirector(column, ref found, listViewItem, technicalDirector);
                      this.checkStaff(column, ref found, listViewItem, staff);
                      if (strategy != null)
                        this.checkRisk(column, ref found, listViewItem, strategy);
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
                            listViewItem.SubItems.Add(calculatedFuelConsumption.minTemp.ToString());
                            continue;
                          case ColumnInfo.StintMaxTemp:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.maxTemp.ToString());
                            continue;
                          case ColumnInfo.StintAvgTemp:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.avgTemp.ToString("N2"));
                            continue;
                          case ColumnInfo.StintMinHum:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.minHum.ToString());
                            continue;
                          case ColumnInfo.StintMaxHum:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.maxHum.ToString());
                            continue;
                          case ColumnInfo.StintAvgHum:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.avgHum.ToString("N2"));
                            continue;
                          case ColumnInfo.StintSeason:
                            ListViewItem.ListViewSubItemCollection subItems1 = listViewItem.SubItems;
                            num = season.Season;
                            string text2 = num.ToString();
                            subItems1.Add(text2);
                            continue;
                          case ColumnInfo.StintRace:
                            ListViewItem.ListViewSubItemCollection subItems2 = listViewItem.SubItems;
                            num = index1 + 1;
                            string text3 = num.ToString();
                            subItems2.Add(text3);
                            continue;
                          case ColumnInfo.StintNumber:
                            listViewItem.SubItems.Add(text1);
                            continue;
                          case ColumnInfo.StintLaps:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.laps.ToString());
                            continue;
                          case ColumnInfo.StintKm:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.km.ToString("N3"));
                            continue;
                          case ColumnInfo.StintBadKm:
                            if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                            {
                              listViewItem.SubItems.Add(race.CalcTyres[index2].badAtKm.ToString("N3"));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintBadPercent:
                            if (race.CalcTyres != null && race.CalcTyres.Length > index2)
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
                              listViewItem.SubItems.Add(race.CalcTyres[index2].estimatedDuration.ToString("N3"));
                              continue;
                            }
                            listViewItem.SubItems.Add("-");
                            continue;
                          case ColumnInfo.StintFuel:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.fuelUsed.ToString("N1"));
                            continue;
                          case ColumnInfo.StintFuelConsumption:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.consumption.ToString("N3"));
                            continue;
                          case ColumnInfo.StintWeather:
                            listViewItem.SubItems.Add(calculatedFuelConsumption.weather);
                            continue;
                          default:
                            listViewItem.SubItems.Add("-");
                            continue;
                        }
                      }
                    }
                    if (listViewItem.SubItems.Count > 1 && (selectedIndex1 <= 0 || !(Datas.Tracks[season.Events[index1].Trackid - 1].name != str1)) && (selectedIndex2 <= 0 || !(str2 != EnumToString.Enum2String(Datas.Tracks[season.Events[index1].Trackid - 1].fuelConsumption))) && (selectedIndex3 <= 0 || !(str3 != driver.name)) && calculatedFuelConsumption.laps >= int.Parse(this.removeStintsWithLessLaps.Text) && (this.checkBoxStints.Checked || !("race" != text1)))
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
      if (str3 == null)
        return;
      int num1 = this.comboBoxDriver.Items.IndexOf((object) str3);
      if (num1 == -1)
        num1 = 0;
      this.updateDriver = false;
      this.comboBoxDriver.SelectedIndex = num1;
      this.updateDriver = true;
    }

    private void SomethingChanged(object sender, EventArgs e) => this.UpdateList();

    private void ExtraInit()
    {
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.FullRowSelect = true;
      this.listView1.GridLines = true;
      this.listView1.Location = new Point(0, 56);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(this.Width - 8, this.Height - 124);
      this.listView1.TabIndex = 5;
      this.listView1.View = View.Details;
      this.listView1.ContextMenu = this.contextMenu1;
      if (Datas.Date.race <= 0 || Datas.Date.race >= 18 || Datas.Seasons[Datas.Seasons.Count - 1] == null || Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1] == null || Datas.Tracks[Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1].Trackid - 1] == null)
        return;
      this.textBoxTrack.Text = Datas.Tracks[Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1].Trackid - 1].name;
      this.textBoxUsage.Text = EnumToString.Enum2String(Datas.Tracks[Datas.Seasons[Datas.Seasons.Count - 1].Events[Datas.Date.race - 1].Trackid - 1].fuelConsumption);
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

    private void removeStintsWithLessLaps_TextChanged(object sender, EventArgs e)
    {
      try
      {
        int num = int.Parse(this.removeStintsWithLessLaps.Text);
        if (num >= 0)
        {
          if (num <= 99)
            goto label_4;
        }
        this.removeStintsWithLessLaps.Text = "0";
        this.removeStintsWithLessLaps.SelectAll();
      }
      catch
      {
        this.removeStintsWithLessLaps.Text = "0";
        this.removeStintsWithLessLaps.SelectAll();
      }
label_4:
      RegistryKey subKey = Registry.CurrentUser.CreateSubKey("Software\\go\\GUI");
      subKey.SetValue("HistoricalFuelConsumptionSkip", (object) this.removeStintsWithLessLaps.Text);
      subKey.Close();
    }

    private void removeStintsWithLessLaps_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
        this.SomethingChanged((object) null, (EventArgs) e);
      e.Handled = true;
    }

    private void removeStintsWithLess_OnFocus(object sender, EventArgs e)
    {
      this.removeStintsWithLessLaps.Focus();
      this.removeStintsWithLessLaps.SelectAll();
    }

    private void DriverChanged(object sender, EventArgs e)
    {
      if (!this.updateDriver)
        return;
      this.SomethingChanged(sender, e);
    }
  }
}
