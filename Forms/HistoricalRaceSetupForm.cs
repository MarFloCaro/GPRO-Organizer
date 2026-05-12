 
// Type: go.Forms.HistoricalRaceSetupForm
 
 
 

using go.Enums;
using go.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class HistoricalRaceSetupForm : GoForm
  {
    private const string formname = "HistoricalRaceSetup";
    private bool updateDriver = true;
    private Button button1;
    private ComboBox comboBoxName;
    private Label label1;
    private TextBox textBoxTrack;
    private ComboBox comboBoxDriver;

    public HistoricalRaceSetupForm()
      : base("HistoricalRaceSetup")
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HistoricalRaceSetupForm));
      this.button1 = new Button();
      this.comboBoxName = new ComboBox();
      this.label1 = new Label();
      this.textBoxTrack = new TextBox();
      this.comboBoxDriver = new ComboBox();
      this.SuspendLayout();
      this.listView1.Location = new Point(14, 77);
      this.listView1.Size = new Size(957, 245);
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(896, 342);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.exit_Click);
      this.comboBoxName.Items.AddRange(new object[1]
      {
        (object) "All"
      });
      this.comboBoxName.Location = new Point(14, 32);
      this.comboBoxName.Name = "comboBoxName";
      this.comboBoxName.Size = new Size(96, 21);
      this.comboBoxName.TabIndex = 17;
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
      this.comboBoxDriver.FormattingEnabled = true;
      this.comboBoxDriver.Location = new Point(143, 32);
      this.comboBoxDriver.Name = "comboBoxDriver";
      this.comboBoxDriver.Size = new Size(91, 21);
      this.comboBoxDriver.TabIndex = 35;
      this.comboBoxDriver.Text = "Driver";
      this.comboBoxDriver.SelectedIndexChanged += new EventHandler(this.comboBoxDriver_SelectedIndexChanged);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(1006, 377);
      this.Controls.Add((Control) this.comboBoxDriver);
      this.Controls.Add((Control) this.textBoxTrack);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.comboBoxName);
      this.Controls.Add((Control) this.button1);
      this.Icon = Resources.Resources.Car;
      this.MinimumSize = new Size(632, 152);
      this.Name = nameof (HistoricalRaceSetupForm);
      this.Text = "GPRO Organizer : Historical Race Setups";
      this.Controls.SetChildIndex((Control) this.button1, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxName, 0);
      this.Controls.SetChildIndex((Control) this.label1, 0);
      this.Controls.SetChildIndex((Control) this.listView1, 0);
      this.Controls.SetChildIndex((Control) this.textBoxTrack, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxDriver, 0);
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
          for (int index = 0; index < season.Events.Length; ++index)
          {
            if (season.Events[index] != null && season.Events[index].isStrategyUpdated)
            {
              Strategy4 strat = season.Events[index].Strat;
              Staff staff = season.Events[index].Staff;
              TechnicalDirector technicalDirector = season.Events[index].TechnicalDirector;
              Car2 startcar = season.Events[index].Startcar;
              Driver5 driver = season.Events[index].Driver;
              if (driver.name != "" && !this.comboBoxDriver.Items.Contains((object) driver.name))
                this.comboBoxDriver.Items.Add((object) driver.name);
              WeatherForecast forecast = season.Events[index].Weather.forecast;
              TyreSupplier tyresupplier = season.Events[index].Tyresupplier;
              ListViewItem listViewItem = new ListViewItem()
              {
                UseItemStyleForSubItems = false
              };
              foreach (ColumnInfo column in this.formInfo.columnInfo)
              {
                bool found = false;
                this.checkTrack(column, ref found, listViewItem, season.Events[index].Trackid - 1);
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
                      listViewItem.SubItems.Add((index + 1).ToString());
                      continue;
                    case ColumnInfo.RaceSetupFrontWing:
                      listViewItem.SubItems.Add(strat.setup.fWing.ToString());
                      continue;
                    case ColumnInfo.RaceSetupRearWing:
                      listViewItem.SubItems.Add(strat.setup.rWing.ToString());
                      continue;
                    case ColumnInfo.RaceSetupEngine:
                      listViewItem.SubItems.Add(strat.setup.engine.ToString());
                      continue;
                    case ColumnInfo.RaceSetupBrakes:
                      listViewItem.SubItems.Add(strat.setup.brakes.ToString());
                      continue;
                    case ColumnInfo.RaceSetupGear:
                      listViewItem.SubItems.Add(strat.setup.gear.ToString());
                      continue;
                    case ColumnInfo.RaceSetupSuspension:
                      listViewItem.SubItems.Add(strat.setup.susp.ToString());
                      continue;
                    case ColumnInfo.RaceSetupTyreType:
                      listViewItem.SubItems.Add(EnumToString.Enum2String(strat.startTyres));
                      continue;
                    case ColumnInfo.RaceSetupWeatherMinTemp:
                      int num1 = Math.Min(Math.Min(Math.Min(forecast.minTemp[0], forecast.minTemp[1]), forecast.minTemp[2]), forecast.minTemp[3]);
                      listViewItem.SubItems.Add(num1.ToString());
                      continue;
                    case ColumnInfo.RaceSetupWeatherMaxTemp:
                      int num2 = Math.Max(Math.Max(Math.Max(forecast.maxTemp[0], forecast.maxTemp[1]), forecast.maxTemp[2]), forecast.maxTemp[3]);
                      listViewItem.SubItems.Add(num2.ToString());
                      continue;
                    case ColumnInfo.RaceSetupWeatherMinHum:
                      int num3 = Math.Min(Math.Min(Math.Min(forecast.minHum[0], forecast.minHum[1]), forecast.minHum[2]), forecast.minHum[3]);
                      listViewItem.SubItems.Add(num3.ToString());
                      continue;
                    case ColumnInfo.RaceSetupWeatherMaxHum:
                      int num4 = Math.Max(Math.Max(Math.Max(forecast.maxHum[0], forecast.maxHum[1]), forecast.maxHum[2]), forecast.maxHum[3]);
                      listViewItem.SubItems.Add(num4.ToString());
                      continue;
                    default:
                      listViewItem.SubItems.Add("-");
                      continue;
                  }
                }
              }
              if (listViewItem.SubItems.Count > 1 && (selectedIndex1 <= 0 || !(Datas.Tracks[season.Events[index].Trackid - 1].name != str1)) && (selectedIndex2 <= 0 || !(str2 != driver.name)))
              {
                listViewItem.Text = listViewItem.SubItems[1].Text;
                listViewItem.SubItems.RemoveAt(0);
                this.listView1.Items.Add(listViewItem);
              }
            }
          }
        }
      }
      if (str2 == null)
        return;
      int num = this.comboBoxDriver.Items.IndexOf((object) str2);
      if (num == -1)
        num = 0;
      this.updateDriver = false;
      this.comboBoxDriver.SelectedIndex = num;
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
      this.listView1.Size = new Size(this.Width - 8, this.Height - 124);
      this.listView1.TabIndex = 0;
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

    private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.updateDriver)
        return;
      this.SomethingChanged(sender, e);
    }
  }
}
