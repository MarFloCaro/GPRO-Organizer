 
// Type: go.Forms.GoForm
 
 
 

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
  public class GoForm : Form
  {
    public FormInfo formInfo;
    protected string formName;
    private ListView staticListView = new ListView();
    protected ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
    protected ListView listView1;
    protected ContextMenu contextMenu1 = new ContextMenu();
    protected MenuItem menuItemChooseColumns = new MenuItem();
    protected MenuItem menuItemExportToCSV = new MenuItem();

    public GoForm() => this.InitializeComponent();

    public GoForm(string formName)
    {
      this.InitializeComponent();
      this.formName = formName;
      this.formInfo = Datas.FormHandler.GetFormInfo(formName);
      this.menuItemChooseColumns.Index = 0;
      this.menuItemChooseColumns.Text = "Choose Columns";
      this.menuItemChooseColumns.Click += new EventHandler(this.menuItemChooseColumns_Click);
      this.contextMenu1.MenuItems.Add(this.menuItemChooseColumns);
      this.menuItemExportToCSV.Index = 1;
      this.menuItemExportToCSV.Text = "Export to CSV";
      this.menuItemExportToCSV.Click += new EventHandler(this.menuItemExportToCSV_Click);
      this.contextMenu1.MenuItems.Add(this.menuItemExportToCSV);
      this.listView1.ColumnClick += new ColumnClickEventHandler(this.ListView1ColumnClick);
      this.listView1.ListViewItemSorter = (IComparer) this.lvwColumnSorter;
    }

    private void InitializeComponent()
    {
      this.listView1 = new ListView();
      this.SuspendLayout();
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.Location = new Point(4, 8);
      this.listView1.Name = "listView1";
      this.listView1.TabIndex = 0;
      this.listView1.View = View.Details;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(292, 266);
      this.Controls.Add((Control) this.listView1);
      this.Name = nameof (GoForm);
      this.Text = nameof (GoForm);
      this.Closing += new CancelEventHandler(this.Form_Closing);
      this.ResumeLayout(false);
    }

    protected virtual void SetColumns()
    {
      this.listView1.Columns.Clear();
      for (int index = 0; index < this.formInfo.columnInfo.Count && index < this.formInfo.columnWidths.Count; ++index)
      {
        ColumnInfo columnInfo = (ColumnInfo) this.formInfo.columnInfo[index];
        this.listView1.Columns.Add(EnumToString.Enum2ShortString(columnInfo), (int) this.formInfo.columnWidths[index], Datas.FormHandler.GetColumnAlignment(columnInfo));
      }
    }

    protected virtual void ListAll()
    {
      this.staticListView.Items.Clear();
      this.listView1.Items.Clear();
      foreach (Season20 season in Datas.Seasons)
      {
        if (season != null)
        {
          for (int index1 = 0; index1 < season.Events.Length; ++index1)
          {
            if (season.Events[index1] != null && season.Events[index1].Race != null)
            {
              Race9 race = season.Events[index1].Race;
              Strategy4 strat = season.Events[index1].Strat;
              bool flag1 = false;
              if (season.Events[index1].isStrategyUpdated)
                flag1 = true;
              bool flag2 = false;
              Car2 startcar = season.Events[index1].Startcar;
              if (season.Events[index1].isCarUpdated && startcar != null)
                flag2 = true;
              bool flag3 = false;
              Car2 endcar = season.Events[index1].Endcar;
              if (season.Events[index1].isRaceUpdated)
                flag3 = true;
              bool flag4 = false;
              Driver5 driver5 = new Driver5();
              if (season.Events[index1].isDriverUpdated)
              {
                flag4 = true;
                driver5 = season.Events[index1].Driver;
              }
              int num1 = 1;
              int num2 = 0;
              if (season.Events[index1].Race.PitStops != null)
                num2 = season.Events[index1].Race.PitStops.Length;
              for (int index2 = 0; index2 < num1; ++index2)
              {
                for (int index3 = 0; index3 < num2; ++index3)
                {
                  string text = "stint " + index2.ToString();
                  ListViewItem listViewItem = new ListViewItem()
                  {
                    UseItemStyleForSubItems = false
                  };
                  foreach (ColumnInfo column in this.formInfo.columnInfo)
                  {
                    bool found = false;
                    this.checkTrack(column, ref found, listViewItem, season.Events[index1].Trackid - 1);
                    this.checkTechnicalDirector(column, ref found, listViewItem, season.Events[index1].TechnicalDirector);
                    if (!found)
                    {
                      switch (column)
                      {
                        case ColumnInfo.DriverName:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.name);
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverOverall:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.overall.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverConcentration:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.concentration.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverTalent:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.talent.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverAggresiveness:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.aggresiveness.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverExperience:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.experience.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverTechnicalInsight:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.technicalInsight.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverStamina:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.stamina.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverCharisma:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.charisma.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverMotivation:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.motivation.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverWeight:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.weight.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverAge:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.age.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverTrophies:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.trophies.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverNumberofGps:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.numberOfGps.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverWins:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.wins.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverPodiums:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.podiums.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverPointsScored:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.pointsScored.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverPolePositions:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.polePositions.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverFastestLaps:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.fastestLaps.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverAvPointsPerRace:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.avPointsPerrace.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverSalary:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(EnumToString.Wage2String(driver5.salary));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.DriverRacesLeft:
                          if (flag4)
                          {
                            listViewItem.SubItems.Add(driver5.racesLeftOfContract.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffOverall:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.overall.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffExperience:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.experience.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffMotivation:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.motivation.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffTechnicalSkill:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.technicalSkill.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffStressHandling:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.stressHandling.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffConcentration:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.concentration.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffEfficiency:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.efficiency.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffWindtunnel:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.windtunnel.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffPitstopTrainingCenter:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.pitstopTrainingCenter.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffRDWorkshop:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.rDWorkshop.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffRDDesignCenter:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.rDDesignCenter.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffEngineeringWorkshop:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.engineeringWorkshop.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffAlloyAndChemicalLab:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.alloyAndChemicalLab.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffCommercial:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.commercial.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffSalary:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(EnumToString.Wage2String(season.Events[index1].Staff.salary));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StaffMaintenance:
                          if (season.Events[index1].isStaffUpdated)
                          {
                            listViewItem.SubItems.Add(season.Events[index1].Staff.maintenance.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintTyreType:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(EnumToString.Enum2String(race.CalcTyres[index2].tyres));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarChassisLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.chassis.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarEngineLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.engine.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarFrontWingLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.frontWing.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarRearWingLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.rearWing.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarUnderbodyLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.underbody.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarSidepodsLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.sidepods.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarCoolingLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.cooling.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarGearboxLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.gearBox.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarBrakesLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.brakes.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarSuspensionLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.suspension.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarElectronicsLevel:
                          if (flag3)
                          {
                            listViewItem.SubItems.Add(endcar.electronics.level.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarPowerLevel:
                          if (flag2)
                          {
                            listViewItem.SubItems.Add(startcar.power.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarHandlingLevel:
                          if (flag2)
                          {
                            listViewItem.SubItems.Add(startcar.handling.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.CarAccelerationLevel:
                          if (flag2)
                          {
                            listViewItem.SubItems.Add(startcar.acceleration.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintMinTemp:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].minTemp.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintMaxTemp:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].maxTemp.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintAvgTemp:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].avgTemp.ToString("N2"));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintMinHum:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].minHum.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintMaxHum:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].maxHum.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintAvgHum:
                          if (race.CalcTyres != null && race.CalcTyres[index2] != null)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].avgHum.ToString("N2"));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintSeason:
                          listViewItem.SubItems.Add(season.Season.ToString());
                          continue;
                        case ColumnInfo.StintRace:
                          listViewItem.SubItems.Add((index1 + 1).ToString());
                          continue;
                        case ColumnInfo.StintNumber:
                          listViewItem.SubItems.Add(text);
                          continue;
                        case ColumnInfo.StintLaps:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].laps.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintKm:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].km.ToString("N3"));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
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
                        case ColumnInfo.RiskOvertake:
                          if (flag1)
                          {
                            listViewItem.SubItems.Add(strat.riskOvertake.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.RiskDefend:
                          if (flag1)
                          {
                            listViewItem.SubItems.Add(strat.riskDefend.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.RiskClear:
                          if (flag1)
                          {
                            listViewItem.SubItems.Add(strat.riskClear.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.RiskWet:
                          if (flag1)
                          {
                            listViewItem.SubItems.Add(strat.riskWet.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.RiskMalfunction:
                          if (flag1)
                          {
                            listViewItem.SubItems.Add(strat.riskMalfunction.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitLap:
                          if (race.PitStops != null && race.PitStops.Length > index3)
                          {
                            listViewItem.SubItems.Add(race.PitStops[index3].lap.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitReason:
                          if (race.PitStops != null && race.PitStops.Length > index3)
                          {
                            listViewItem.SubItems.Add(EnumToString.Enum2String(race.PitStops[index3].pitstopreason));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitTyresLeft:
                          if (race.PitStops != null && race.PitStops.Length > index3)
                          {
                            listViewItem.SubItems.Add(race.PitStops[index3].tyresCondition.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitFuelLeft:
                          if (race.PitStops != null && race.PitStops.Length > index3)
                          {
                            listViewItem.SubItems.Add(((double) race.PitStops[index3].fuelLeft * 1.8).ToString("N1"));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitRefilled:
                          if (race.PitStops != null && race.PitStops.Length > index3 && race.PitStops[index3].refilledTo > 0)
                          {
                            listViewItem.SubItems.Add(race.PitStops[index3].refilledTo.ToString());
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitTime:
                          if (race.PitStops != null && race.PitStops.Length > index3)
                          {
                            listViewItem.SubItems.Add(EnumToString.Time2String(race.PitStops[index3].pitTime, true));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitFuelPutOnCar:
                          if (race.PitStops != null && race.PitStops.Length > index3 && race.PitStops[index3].refilledTo > 0)
                          {
                            listViewItem.SubItems.Add(((double) race.PitStops[index3].refilledTo - (double) race.PitStops[index3].fuelLeft * 1.8).ToString("N1"));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.PitSecondsPerLiterFuel:
                          if (race.PitStops != null && race.PitStops.Length > index3 && race.PitStops[index3].refilledTo > 0)
                          {
                            double num3 = (double) (race.PitStops[index3].pitTime.Minutes * 60 + race.PitStops[index3].pitTime.Seconds) + (double) race.PitStops[index3].pitTime.Milliseconds / 1000.0;
                            listViewItem.SubItems.Add((((double) race.PitStops[index3].refilledTo - (double) race.PitStops[index3].fuelLeft * 1.8) / num3).ToString("N3"));
                            continue;
                          }
                          listViewItem.SubItems.Add("-");
                          continue;
                        case ColumnInfo.StintWeather:
                          if (race.CalcTyres != null && race.CalcTyres.Length > index2)
                          {
                            listViewItem.SubItems.Add(race.CalcTyres[index2].weather);
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
                  if (listViewItem.SubItems.Count > 1)
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

    protected void checkTrack(ColumnInfo column, ref bool found, ListViewItem item, int trackid)
    {
      if (found)
        return;
      found = true;
      switch (column)
      {
        case ColumnInfo.TrackName:
          item.SubItems.Add(Datas.Tracks[trackid].name);
          break;
        case ColumnInfo.TrackDownForce:
          item.SubItems.Add(EnumToString.Enum2String(Datas.Tracks[trackid].downforce));
          break;
        case ColumnInfo.TrackOvertaking:
          item.SubItems.Add(EnumToString.Enum2String(Datas.Tracks[trackid].overtaking));
          break;
        case ColumnInfo.TrackSuspensionRigidity:
          item.SubItems.Add(EnumToString.Enum2String(Datas.Tracks[trackid].suspensionRigidity));
          break;
        case ColumnInfo.TrackFuelConsumption:
          item.SubItems.Add(EnumToString.Enum2String(Datas.Tracks[trackid].fuelConsumption));
          break;
        case ColumnInfo.TrackTyreWear:
          item.SubItems.Add(EnumToString.Enum2String(Datas.Tracks[trackid].tyreWear));
          break;
        case ColumnInfo.TrackLapLength:
          item.SubItems.Add(Datas.Tracks[trackid].lapDistance.ToString());
          break;
        case ColumnInfo.TrackLaps:
          item.SubItems.Add(Datas.Tracks[trackid].laps.ToString());
          break;
        case ColumnInfo.TrackRaceDistance:
          item.SubItems.Add(Datas.Tracks[trackid].distance.ToString());
          break;
        case ColumnInfo.TrackPower:
          item.SubItems.Add(Datas.Tracks[trackid].power.ToString());
          break;
        case ColumnInfo.TrackHandling:
          item.SubItems.Add(Datas.Tracks[trackid].handling.ToString());
          break;
        case ColumnInfo.TrackAcceleration:
          item.SubItems.Add(Datas.Tracks[trackid].acceleration.ToString());
          break;
        case ColumnInfo.TrackAvgSpeed:
          item.SubItems.Add(Datas.Tracks[trackid].averageSpeed.ToString());
          break;
        case ColumnInfo.TrackNote:
          item.SubItems.Add(Datas.TrackNotes[trackid]);
          break;
        case ColumnInfo.TrackPitInOutTime:
          item.SubItems.Add(Datas.Tracks[trackid].timeInPits.ToString("N1"));
          break;
        case ColumnInfo.TrackCorners:
          item.SubItems.Add(Datas.Tracks[trackid].numberOfCorners.ToString());
          break;
        case ColumnInfo.TrackGrip:
          item.SubItems.Add(EnumToString.Enum2String(Datas.Tracks[trackid].grip));
          break;
        default:
          found = false;
          break;
      }
    }

    protected void checkDriver(
      ColumnInfo column,
      ref bool found,
      ListViewItem item,
      Driver5 driver)
    {
      if (found)
        return;
      found = true;
      switch (column)
      {
        case ColumnInfo.DriverName:
          item.SubItems.Add(driver.name);
          break;
        case ColumnInfo.DriverOverall:
          item.SubItems.Add(driver.overall.ToString());
          break;
        case ColumnInfo.DriverConcentration:
          item.SubItems.Add(driver.concentration.ToString());
          break;
        case ColumnInfo.DriverTalent:
          item.SubItems.Add(driver.talent.ToString());
          break;
        case ColumnInfo.DriverAggresiveness:
          item.SubItems.Add(driver.aggresiveness.ToString());
          break;
        case ColumnInfo.DriverExperience:
          item.SubItems.Add(driver.experience.ToString());
          break;
        case ColumnInfo.DriverTechnicalInsight:
          item.SubItems.Add(driver.technicalInsight.ToString());
          break;
        case ColumnInfo.DriverStamina:
          item.SubItems.Add(driver.stamina.ToString());
          break;
        case ColumnInfo.DriverCharisma:
          item.SubItems.Add(driver.charisma.ToString());
          break;
        case ColumnInfo.DriverMotivation:
          item.SubItems.Add(driver.motivation.ToString());
          break;
        case ColumnInfo.DriverWeight:
          item.SubItems.Add(driver.weight.ToString());
          break;
        case ColumnInfo.DriverAge:
          item.SubItems.Add(driver.age.ToString());
          break;
        case ColumnInfo.DriverTrophies:
          item.SubItems.Add(driver.trophies.ToString());
          break;
        case ColumnInfo.DriverNumberofGps:
          item.SubItems.Add(driver.numberOfGps.ToString());
          break;
        case ColumnInfo.DriverWins:
          item.SubItems.Add(driver.wins.ToString());
          break;
        case ColumnInfo.DriverPodiums:
          item.SubItems.Add(driver.podiums.ToString());
          break;
        case ColumnInfo.DriverPointsScored:
          item.SubItems.Add(driver.pointsScored.ToString());
          break;
        case ColumnInfo.DriverFastestLaps:
          item.SubItems.Add(driver.fastestLaps.ToString());
          break;
        case ColumnInfo.DriverAvPointsPerRace:
          item.SubItems.Add(driver.avPointsPerrace.ToString());
          break;
        case ColumnInfo.DriverSalary:
          item.SubItems.Add(driver.salary.ToString());
          break;
        case ColumnInfo.DriverRacesLeft:
          item.SubItems.Add(driver.racesLeftOfContract.ToString());
          break;
        case ColumnInfo.DriverEnergy:
          item.SubItems.Add(driver.energy.ToString());
          break;
        default:
          found = false;
          break;
      }
    }

    protected void checkCar(ColumnInfo column, ref bool found, ListViewItem item, Car2 car)
    {
      if (found)
        return;
      found = true;
      switch (column)
      {
        case ColumnInfo.CarChassisLevel:
          item.SubItems.Add(car.chassis.level.ToString());
          break;
        case ColumnInfo.CarEngineLevel:
          item.SubItems.Add(car.engine.level.ToString());
          break;
        case ColumnInfo.CarFrontWingLevel:
          item.SubItems.Add(car.frontWing.level.ToString());
          break;
        case ColumnInfo.CarRearWingLevel:
          item.SubItems.Add(car.rearWing.level.ToString());
          break;
        case ColumnInfo.CarUnderbodyLevel:
          item.SubItems.Add(car.underbody.level.ToString());
          break;
        case ColumnInfo.CarSidepodsLevel:
          item.SubItems.Add(car.sidepods.level.ToString());
          break;
        case ColumnInfo.CarCoolingLevel:
          item.SubItems.Add(car.cooling.level.ToString());
          break;
        case ColumnInfo.CarGearboxLevel:
          item.SubItems.Add(car.gearBox.level.ToString());
          break;
        case ColumnInfo.CarBrakesLevel:
          item.SubItems.Add(car.brakes.level.ToString());
          break;
        case ColumnInfo.CarSuspensionLevel:
          item.SubItems.Add(car.suspension.level.ToString());
          break;
        case ColumnInfo.CarElectronicsLevel:
          item.SubItems.Add(car.electronics.level.ToString());
          break;
        case ColumnInfo.CarPowerLevel:
          item.SubItems.Add(car.power.ToString());
          break;
        case ColumnInfo.CarHandlingLevel:
          item.SubItems.Add(car.handling.ToString());
          break;
        case ColumnInfo.CarAccelerationLevel:
          item.SubItems.Add(car.acceleration.ToString());
          break;
        default:
          found = false;
          break;
      }
    }

    protected void checkRisk(
      ColumnInfo column,
      ref bool found,
      ListViewItem item,
      Strategy4 strategy)
    {
      if (found)
        return;
      found = true;
      switch (column)
      {
        case ColumnInfo.RiskOvertake:
          item.SubItems.Add(strategy.riskOvertake.ToString());
          break;
        case ColumnInfo.RiskDefend:
          item.SubItems.Add(strategy.riskDefend.ToString());
          break;
        case ColumnInfo.RiskClear:
          item.SubItems.Add(strategy.riskClear.ToString());
          break;
        case ColumnInfo.RiskWet:
          item.SubItems.Add(strategy.riskWet.ToString());
          break;
        case ColumnInfo.RiskMalfunction:
          item.SubItems.Add(strategy.riskMalfunction.ToString());
          break;
        default:
          found = false;
          break;
      }
    }

    protected void checkTyreSupplier(
      ColumnInfo column,
      ref bool found,
      ListViewItem item,
      TyreSupplier supplier)
    {
      if (found)
        return;
      found = true;
      switch (column)
      {
        case ColumnInfo.TyreSupplierDryPerf:
          item.SubItems.Add(supplier.dryPerf.ToString());
          break;
        case ColumnInfo.TyreSupplierWetPerf:
          item.SubItems.Add(supplier.wetPerf.ToString());
          break;
        case ColumnInfo.TyreSupplierPeakTemp:
          item.SubItems.Add(supplier.peakTemp.ToString());
          break;
        case ColumnInfo.TyreSupplierDurability:
          item.SubItems.Add(supplier.durability.ToString());
          break;
        case ColumnInfo.TyreSupplierWarmupDist:
          item.SubItems.Add(supplier.warmUpDistance.ToString());
          break;
        default:
          found = false;
          break;
      }
    }

    protected void checkStaff(ColumnInfo column, ref bool found, ListViewItem item, Staff staff)
    {
      if (found)
        return;
      found = true;
      switch (column)
      {
        case ColumnInfo.StaffOverall:
          item.SubItems.Add(staff.overall.ToString());
          break;
        case ColumnInfo.StaffExperience:
          item.SubItems.Add(staff.experience.ToString());
          break;
        case ColumnInfo.StaffMotivation:
          item.SubItems.Add(staff.motivation.ToString());
          break;
        case ColumnInfo.StaffTechnicalSkill:
          item.SubItems.Add(staff.technicalSkill.ToString());
          break;
        case ColumnInfo.StaffStressHandling:
          item.SubItems.Add(staff.stressHandling.ToString());
          break;
        case ColumnInfo.StaffConcentration:
          item.SubItems.Add(staff.concentration.ToString());
          break;
        case ColumnInfo.StaffEfficiency:
          item.SubItems.Add(staff.efficiency.ToString());
          break;
        case ColumnInfo.StaffWindtunnel:
          item.SubItems.Add(staff.windtunnel.ToString());
          break;
        case ColumnInfo.StaffPitstopTrainingCenter:
          item.SubItems.Add(staff.pitstopTrainingCenter.ToString());
          break;
        case ColumnInfo.StaffRDWorkshop:
          item.SubItems.Add(staff.rDWorkshop.ToString());
          break;
        case ColumnInfo.StaffRDDesignCenter:
          item.SubItems.Add(staff.rDDesignCenter.ToString());
          break;
        case ColumnInfo.StaffEngineeringWorkshop:
          item.SubItems.Add(staff.engineeringWorkshop.ToString());
          break;
        case ColumnInfo.StaffAlloyAndChemicalLab:
          item.SubItems.Add(staff.alloyAndChemicalLab.ToString());
          break;
        case ColumnInfo.StaffCommercial:
          item.SubItems.Add(staff.commercial.ToString());
          break;
        case ColumnInfo.StaffSalary:
          item.SubItems.Add(staff.salary.ToString());
          break;
        case ColumnInfo.StaffMaintenance:
          item.SubItems.Add(staff.maintenance.ToString());
          break;
        default:
          found = false;
          break;
      }
    }

    protected void checkRace(
      ColumnInfo column,
      ref bool found,
      ListViewItem item,
      int i,
      Season20 season)
    {
      if (found)
        return;
      found = true;
      if (column != ColumnInfo.StintSeason)
      {
        if (column == ColumnInfo.StintRace)
          item.SubItems.Add((i + 1).ToString());
        else
          found = false;
      }
      else
        item.SubItems.Add(season.Season.ToString());
    }

    protected void checkTechnicalDirector(
      ColumnInfo column,
      ref bool found,
      ListViewItem item,
      TechnicalDirector td)
    {
      if (found)
        return;
      found = true;
      switch (column)
      {
        case ColumnInfo.TechDirectorName:
          item.SubItems.Add(td.name);
          break;
        case ColumnInfo.TechDirectorOverall:
          item.SubItems.Add(td.overall.ToString());
          break;
        case ColumnInfo.TechDirectorLeadership:
          item.SubItems.Add(td.leadership.ToString());
          break;
        case ColumnInfo.TechDirectorMechanics:
          item.SubItems.Add(td.mechanics.ToString());
          break;
        case ColumnInfo.TechDirectorElectronics:
          item.SubItems.Add(td.electronics.ToString());
          break;
        case ColumnInfo.TechDirectorAerodynamics:
          item.SubItems.Add(td.aerodynamics.ToString());
          break;
        case ColumnInfo.TechDirectorExperience:
          item.SubItems.Add(td.experience.ToString());
          break;
        case ColumnInfo.TechDirectorPitCoordination:
          item.SubItems.Add(td.pitCoordination.ToString());
          break;
        case ColumnInfo.TechDirectorMotivation:
          item.SubItems.Add(td.motivation.ToString());
          break;
        default:
          found = false;
          break;
      }
    }

    protected void DisplayComponents()
    {
      this.SetColumns();
      this.ListAll();
      this.UpdateColumnSizes();
      this.UpdateBoxVisibilities();
      if (this.formInfo.columnInfo.Count != 0)
        return;
      this.menuItemChooseColumns_Click((object) null, (EventArgs) null);
    }

    protected virtual void UpdateBoxVisibilities()
    {
    }

    protected void UpdateColumnSizes()
    {
      for (int index = 0; index < this.listView1.Columns.Count && index < this.formInfo.columnWidths.Count; ++index)
      {
        if ((int) this.formInfo.columnWidths[index] < 0)
          this.listView1.Columns[index].Width = -1;
      }
    }

    public void menuItemChooseColumns_Click(object sender, EventArgs e)
    {
      if (new ColumnChooser(this.formName).ShowDialog().Equals((object) DialogResult.Cancel))
        return;
      this.formInfo = Datas.FormHandler.GetFormInfo(this.formName);
      this.SetColumns();
      this.DisplayComponents();
    }

    public void menuItemExportToCSV_Click(object sender, EventArgs e)
    {
      new CSVWriter(this.listView1).save((Form) this);
    }

    protected void Form_Closing(object sender, CancelEventArgs e)
    {
      this.formInfo.columnWidths.Clear();
      foreach (ColumnHeader column in this.listView1.Columns)
        this.formInfo.columnWidths.Add((object) column.Width);
      this.formInfo.formHeight = this.Height;
      this.formInfo.formWidth = this.Width;
      Datas.FormHandler.SetFormInfo(this.formName, this.formInfo);
    }

    protected void ListView1ColumnClick(object sender, ColumnClickEventArgs e)
    {
      if (e.Column == this.lvwColumnSorter.SortColumn)
      {
        this.lvwColumnSorter.Order = this.lvwColumnSorter.Order != SortOrder.Ascending ? SortOrder.Ascending : SortOrder.Descending;
      }
      else
      {
        this.lvwColumnSorter.SortColumn = e.Column;
        this.lvwColumnSorter.Order = SortOrder.Ascending;
      }
      this.lvwColumnSorter.SortingManner = Datas.FormHandler.GetColumnSortOrder((ColumnInfo) this.formInfo.columnInfo[e.Column]);
      this.listView1.Sort();
    }
  }
}
