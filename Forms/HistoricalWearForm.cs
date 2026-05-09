// Decompiled with JetBrains decompiler
// Type: go.Forms.HistoricalWearForm
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
  public class HistoricalWearForm : GoForm
  {
    private const string formname = "HistoricalWear";
    private bool updateDriver = true;
    private Button button1;
    private ComboBox comboBoxName;
    private Label label1;
    private TextBox textBoxTrack;
    private ComboBox comboBoxDriver;

    public HistoricalWearForm()
      : base("HistoricalWear")
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HistoricalWearForm));
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
      this.Icon = Resources.Car;
      this.MinimumSize = new Size(632, 152);
      this.Name = nameof (HistoricalWearForm);
      this.Text = "GPRO Organizer : Historical Car Parts Wear";
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
          for (int i = 0; i < season.Events.Length; ++i)
          {
            if (season.Events[i] != null && season.Events[i].isRaceUpdated && season.Events[i].Race.DidFinishRace)
            {
              Staff staff = season.Events[i].Staff;
              TechnicalDirector technicalDirector = season.Events[i].TechnicalDirector;
              RaceEvent20 raceEvent20 = season.Events[i];
              Car2 car = (Car2) null;
              Car2 car2 = (Car2) null;
              if (raceEvent20.isCarUpdated && raceEvent20.Race.DidFinishRace && raceEvent20.Startcar.power != 0)
              {
                car = raceEvent20.Startcar;
                car2 = raceEvent20.Endcar;
              }
              Driver5 driver = season.Events[i].Driver;
              if (driver.name != "" && !this.comboBoxDriver.Items.Contains((object) driver.name))
                this.comboBoxDriver.Items.Add((object) driver.name);
              TyreSupplier tyresupplier = season.Events[i].Tyresupplier;
              ListViewItem listViewItem = new ListViewItem()
              {
                UseItemStyleForSubItems = false
              };
              foreach (ColumnInfo column in this.formInfo.columnInfo)
              {
                bool found = false;
                this.checkTrack(column, ref found, listViewItem, season.Events[i].Trackid - 1);
                this.checkDriver(column, ref found, listViewItem, driver);
                this.checkStaff(column, ref found, listViewItem, staff);
                this.checkTechnicalDirector(column, ref found, listViewItem, technicalDirector);
                this.checkTyreSupplier(column, ref found, listViewItem, tyresupplier);
                this.checkRace(column, ref found, listViewItem, i, season);
                if (raceEvent20.isStrategyUpdated)
                  this.checkRisk(column, ref found, listViewItem, raceEvent20.Strat);
                if (car == null && !found)
                {
                  listViewItem.SubItems.Add("-");
                }
                else
                {
                  this.checkCar(column, ref found, listViewItem, car);
                  if (!found)
                  {
                    switch (column)
                    {
                      case ColumnInfo.CarChassisWear:
                        if (car2.chassis.wear - car.chassis.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.chassis.wear - car.chassis.wear).ToString());
                          if (car2.chassis.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarEngineWear:
                        if (car2.engine.wear - car.engine.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.engine.wear - car.engine.wear).ToString());
                          if (car2.engine.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarFrontWingWear:
                        if (car2.frontWing.wear - car.frontWing.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.frontWing.wear - car.frontWing.wear).ToString());
                          if (car2.frontWing.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarRearWingWear:
                        if (car2.rearWing.wear - car.rearWing.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.rearWing.wear - car.rearWing.wear).ToString());
                          if (car2.rearWing.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarUnderbodyWear:
                        if (car2.underbody.wear - car.underbody.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.underbody.wear - car.underbody.wear).ToString());
                          if (car2.underbody.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarSidepodsWear:
                        if (car2.sidepods.wear - car.sidepods.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.sidepods.wear - car.sidepods.wear).ToString());
                          if (car2.sidepods.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarCoolingWear:
                        if (car2.cooling.wear - car.cooling.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.cooling.wear - car.cooling.wear).ToString());
                          if (car2.cooling.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarGearboxWear:
                        if (car2.gearBox.wear - car.gearBox.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.gearBox.wear - car.gearBox.wear).ToString());
                          if (car2.gearBox.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarBrakesWear:
                        if (car2.brakes.wear - car.brakes.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.brakes.wear - car.brakes.wear).ToString());
                          if (car2.brakes.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarSuspensionWear:
                        if (car2.suspension.wear - car.suspension.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.suspension.wear - car.suspension.wear).ToString());
                          if (car2.suspension.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      case ColumnInfo.CarElectronicsWear:
                        if (car2.electronics.wear - car.electronics.wear > 0)
                        {
                          listViewItem.SubItems.Add((car2.electronics.wear - car.electronics.wear).ToString());
                          if (car2.electronics.wear == 99)
                          {
                            listViewItem.SubItems[listViewItem.SubItems.Count - 1].ForeColor = Color.Red;
                            continue;
                          }
                          continue;
                        }
                        listViewItem.SubItems.Add("-");
                        continue;
                      default:
                        listViewItem.SubItems.Add("-");
                        continue;
                    }
                  }
                }
              }
              if (listViewItem.SubItems.Count - 1 > 1 && (selectedIndex1 <= 0 || !(Datas.Tracks[season.Events[i].Trackid - 1].name != str1)) && (selectedIndex2 <= 0 || !(str2 != driver.name)))
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
      this.listView1.Size = new Size(this.Width - 8, this.Height - 150);
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
