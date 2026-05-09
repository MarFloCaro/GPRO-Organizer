// Decompiled with JetBrains decompiler
// Type: go.Forms.DriverTrainingHistory
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
  public class DriverTrainingHistory : GoForm
  {
    private int currentrace;
    private int currentseason;
    private int INDEX_TRAINING_TYPE = -1;
    private int INDEX_NAME = -1;
    private ListView listViewReserve = new ListView();
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private ColumnHeader columnHeader10;
    private ColumnHeader columnHeader11;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader13;
    private Button button1;
    private ComboBox comboBoxDriver;
    private ComboBox comboBoxType;
    private Label labelType;
    private Label labelName;

    public DriverTrainingHistory()
      : base("DriverTraining")
    {
      this.InitializeComponent();
      this.ExtraInit();
      this.SetColumns();
      this.ListAll();
      this.UpdateColumnSizes();
      this.UpdateBoxVisibilities();
    }

    private void InitListView(Driver5 driver, ref int financeInt)
    {
      if (Datas.Seasons[0] == null)
        return;
      this.comboBoxDriver.Items.Add((object) driver.name);
      Driver5 driver5 = new Driver5();
      driver5.name = driver.name;
      driver5.UpdateDriver(new Date(), driver, false);
      bool flag1 = true;
      string str1 = "";
      bool flag2 = false;
      Date date = new Date();
      string text = "Unknown";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      string str7 = "";
      string str8 = "";
      string str9 = "";
      string str10 = "";
      string str11 = "";
      for (int index = driver.history.historyList.Count - 2; index > 0; --index)
      {
        DriverHistoryItem2 history = (DriverHistoryItem2) driver.history.historyList[index];
        if (history.driverinfo == DriverInfo.RacesLeft)
        {
          flag1 = false;
          if (str1.Length > 0)
          {
            ListViewItem listViewItem = new ListViewItem()
            {
              UseItemStyleForSubItems = false
            };
            foreach (ColumnInfo columnInfo in this.formInfo.columnInfo)
            {
              switch (columnInfo)
              {
                case ColumnInfo.DriverName:
                  listViewItem.SubItems.Add(driver5.name);
                  continue;
                case ColumnInfo.DriverOverall:
                  listViewItem.SubItems.Add(driver5.overall.ToString() + str2);
                  continue;
                case ColumnInfo.DriverConcentration:
                  listViewItem.SubItems.Add(driver5.concentration.ToString() + str3);
                  continue;
                case ColumnInfo.DriverTalent:
                  listViewItem.SubItems.Add(driver5.talent.ToString() + str4);
                  continue;
                case ColumnInfo.DriverAggresiveness:
                  listViewItem.SubItems.Add(driver5.aggresiveness.ToString() + str5);
                  continue;
                case ColumnInfo.DriverExperience:
                  listViewItem.SubItems.Add(driver5.experience.ToString() + str6);
                  continue;
                case ColumnInfo.DriverTechnicalInsight:
                  listViewItem.SubItems.Add(driver5.technicalInsight.ToString() + str7);
                  continue;
                case ColumnInfo.DriverStamina:
                  listViewItem.SubItems.Add(driver5.stamina.ToString() + str8);
                  continue;
                case ColumnInfo.DriverCharisma:
                  listViewItem.SubItems.Add(driver5.charisma.ToString() + str9);
                  continue;
                case ColumnInfo.DriverMotivation:
                  listViewItem.SubItems.Add(driver5.motivation.ToString() + str10);
                  continue;
                case ColumnInfo.DriverWeight:
                  listViewItem.SubItems.Add(driver5.weight.ToString() + str11);
                  continue;
                case ColumnInfo.DriverAge:
                  listViewItem.SubItems.Add(driver5.age.ToString());
                  continue;
                case ColumnInfo.DriverTrophies:
                  listViewItem.SubItems.Add(driver5.trophies.ToString());
                  continue;
                case ColumnInfo.DriverNumberofGps:
                  listViewItem.SubItems.Add(driver5.numberOfGps.ToString());
                  continue;
                case ColumnInfo.DriverWins:
                  listViewItem.SubItems.Add(driver5.wins.ToString());
                  continue;
                case ColumnInfo.DriverPodiums:
                  listViewItem.SubItems.Add(driver5.podiums.ToString());
                  continue;
                case ColumnInfo.DriverPointsScored:
                  listViewItem.SubItems.Add(driver5.pointsScored.ToString());
                  continue;
                case ColumnInfo.DriverPolePositions:
                  listViewItem.SubItems.Add(driver5.polePositions.ToString());
                  continue;
                case ColumnInfo.DriverFastestLaps:
                  listViewItem.SubItems.Add(driver5.fastestLaps.ToString());
                  continue;
                case ColumnInfo.DriverSalary:
                  listViewItem.SubItems.Add(driver5.salary.ToString());
                  continue;
                case ColumnInfo.DriverRacesLeft:
                  listViewItem.SubItems.Add(driver5.racesLeftOfContract.ToString());
                  continue;
                case ColumnInfo.DriverTrainingType:
                  listViewItem.SubItems.Add(text);
                  continue;
                case ColumnInfo.StintSeason:
                  listViewItem.SubItems.Add(date.season.ToString());
                  continue;
                case ColumnInfo.StintRace:
                  listViewItem.SubItems.Add(date.race.ToString());
                  continue;
                case ColumnInfo.DriverEnergy:
                  listViewItem.SubItems.Add(driver5.energy.ToString());
                  continue;
                default:
                  listViewItem.SubItems.Add("?");
                  continue;
              }
            }
            if (listViewItem.SubItems.Count > 1)
            {
              listViewItem.Text = listViewItem.SubItems[1].Text;
              listViewItem.SubItems.RemoveAt(0);
              this.listViewReserve.Items.Add(listViewItem);
            }
          }
          str1 = "";
          str2 = "";
          str3 = "";
          str4 = "";
          str5 = "";
          str6 = "";
          str7 = "";
          str8 = "";
          str9 = "";
          str10 = "";
          str11 = "";
          text = "Unknown";
          flag2 = false;
        }
        if (flag1)
        {
          if (flag2)
          {
            str1 += ", ";
          }
          else
          {
            flag2 = true;
            date = history.date;
            bool flag3 = false;
            while (financeInt < Datas.FinanceHistory.Count)
            {
              FinanceItem financeItem = (FinanceItem) Datas.FinanceHistory[financeInt];
              switch (financeItem.ItemType)
              {
                case FinanceItemType.DriverTraining:
                  if (this.currentseason == history.date.season)
                  {
                    if (financeItem.ItemType == FinanceItemType.RaceMoney)
                    {
                      this.currentrace = financeItem.Detail;
                      if (this.currentseason < history.date.season || this.currentseason == history.date.season && this.currentrace < history.date.race)
                        goto label_57;
                    }
                    if (financeItem.ItemType == FinanceItemType.DriverTraining && this.currentrace == history.date.race)
                    {
                      text = financeItem.Description.Substring(23);
                      goto label_57;
                    }
                  }
                  ++financeInt;
                  continue;
                case FinanceItemType.EndOfSeasonBonus:
                  flag3 = true;
                  goto case FinanceItemType.DriverTraining;
                default:
                  if (flag3)
                    --this.currentseason;
                  flag3 = false;
                  goto case FinanceItemType.DriverTraining;
              }
            }
          }
label_57:
          double num;
          switch (history.driverinfo)
          {
            case DriverInfo.Overall:
              string str12 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str13 = num.ToString();
              str2 = " " + str12 + str13;
              break;
            case DriverInfo.Concentration:
              string str14 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str15 = num.ToString();
              str3 = " " + str14 + str15;
              break;
            case DriverInfo.Talent:
              string str16 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str17 = num.ToString();
              str4 = " " + str16 + str17;
              break;
            case DriverInfo.Aggresiveness:
              string str18 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str19 = num.ToString();
              str5 = " " + str18 + str19;
              break;
            case DriverInfo.Experience:
              string str20 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str21 = num.ToString();
              str6 = " " + str20 + str21;
              break;
            case DriverInfo.TechnicalInsight:
              string str22 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str23 = num.ToString();
              str7 = " " + str22 + str23;
              break;
            case DriverInfo.Stamina:
              string str24 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str25 = num.ToString();
              str8 = " " + str24 + str25;
              break;
            case DriverInfo.Charisma:
              string str26 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str27 = num.ToString();
              str9 = " " + str26 + str27;
              break;
            case DriverInfo.Motivation:
              string str28 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str29 = num.ToString();
              str10 = " " + str28 + str29;
              break;
            case DriverInfo.Weight:
              string str30 = history.oldValue > history.newValue ? "" : "+";
              num = history.newValue - history.oldValue;
              string str31 = num.ToString();
              str11 = " " + str30 + str31;
              break;
          }
        }
        if (history.driverinfo == DriverInfo.NumberofGps)
          flag1 = true;
        switch (history.driverinfo)
        {
          case DriverInfo.Overall:
            driver5.overall = (int) history.oldValue;
            break;
          case DriverInfo.Concentration:
            driver5.concentration = (int) history.oldValue;
            break;
          case DriverInfo.Talent:
            driver5.talent = (int) history.oldValue;
            break;
          case DriverInfo.Aggresiveness:
            driver5.aggresiveness = (int) history.oldValue;
            break;
          case DriverInfo.Experience:
            driver5.experience = (int) history.oldValue;
            break;
          case DriverInfo.TechnicalInsight:
            driver5.technicalInsight = (int) history.oldValue;
            break;
          case DriverInfo.Stamina:
            driver5.stamina = (int) history.oldValue;
            break;
          case DriverInfo.Charisma:
            driver5.charisma = (int) history.oldValue;
            break;
          case DriverInfo.Motivation:
            driver5.motivation = (int) history.oldValue;
            break;
          case DriverInfo.Weight:
            driver5.weight = (int) history.oldValue;
            break;
        }
      }
    }

    private void PrepareListViewItems()
    {
      this.listView1.Items.Clear();
      for (int index = 0; index < this.listViewReserve.Items.Count; ++index)
        this.listView1.Items.Add((ListViewItem) this.listViewReserve.Items[index].Clone());
    }

    protected override void SetColumns()
    {
      base.SetColumns();
      for (int index = 0; index < this.formInfo.columnInfo.Count && index < this.formInfo.columnWidths.Count; ++index)
      {
        int num = (int) this.formInfo.columnInfo[index];
        if (num == 59)
          this.INDEX_TRAINING_TYPE = index;
        if (num == 15)
          this.INDEX_NAME = index;
      }
    }

    protected override void UpdateBoxVisibilities()
    {
      if (this.INDEX_NAME < 0)
      {
        this.labelName.Visible = false;
        this.comboBoxDriver.Visible = false;
      }
      else
      {
        this.labelName.Visible = true;
        this.comboBoxDriver.Visible = true;
      }
      if (this.INDEX_TRAINING_TYPE < 0)
      {
        this.labelType.Visible = false;
        this.comboBoxType.Visible = false;
      }
      else
      {
        this.labelType.Visible = true;
        this.comboBoxType.Visible = true;
      }
    }

    private void UpdateList()
    {
      this.PrepareListViewItems();
      this.FilterTraining();
      this.FilterDriver();
    }

    private void FilterTraining()
    {
      if (this.comboBoxType.SelectedIndex < 1 || this.INDEX_TRAINING_TYPE == -1)
        return;
      string str = (string) this.comboBoxType.Items[this.comboBoxType.SelectedIndex];
      for (int index = 0; index < this.listView1.Items.Count; ++index)
      {
        if (this.listView1.Items[index].SubItems[this.INDEX_TRAINING_TYPE].Text != str)
        {
          this.listView1.Items[index].Remove();
          --index;
        }
      }
    }

    private void FilterDriver()
    {
      if (this.comboBoxDriver.SelectedIndex < 1 || this.INDEX_NAME == -1)
        return;
      string str = (string) this.comboBoxDriver.Items[this.comboBoxDriver.SelectedIndex];
      for (int index = 0; index < this.listView1.Items.Count; ++index)
      {
        if (this.listView1.Items[index].SubItems[this.INDEX_NAME].Text != str)
        {
          this.listView1.Items[index].Remove();
          --index;
        }
      }
    }

    protected override void ListAll()
    {
      this.listViewReserve.Items.Clear();
      int financeInt = 0;
      this.currentrace = Datas.Date.race;
      this.currentseason = Datas.Date.season;
      this.comboBoxDriver.Items.Clear();
      this.comboBoxDriver.Items.Add((object) "All");
      for (int index = Datas.OldDrivers.Count - 1; index >= 0; --index)
        this.InitListView((Driver5) Datas.OldDrivers[index], ref financeInt);
      this.PrepareListViewItems();
      this.listViewReserve.Visible = false;
      if (this.listView1.Items.Count == 0)
        return;
      ListViewItem listViewItem = this.listView1.Items[0];
      string text1 = listViewItem.Text;
      string text2 = listViewItem.SubItems[0].Text;
    }

    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (DriverTrainingHistory));
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader13 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.columnHeader8 = new ColumnHeader();
      this.columnHeader9 = new ColumnHeader();
      this.columnHeader10 = new ColumnHeader();
      this.columnHeader11 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.comboBoxType = new ComboBox();
      this.labelType = new Label();
      this.button1 = new Button();
      this.labelName = new Label();
      this.comboBoxDriver = new ComboBox();
      this.SuspendLayout();
      this.columnHeader1.Text = "Date";
      this.columnHeader2.Text = "Type";
      this.columnHeader13.Text = "Driver";
      this.columnHeader13.Width = 100;
      this.columnHeader3.Text = "OA";
      this.columnHeader3.Width = 50;
      this.columnHeader4.Text = "Conc";
      this.columnHeader4.Width = 50;
      this.columnHeader5.Text = "Tal";
      this.columnHeader5.Width = 50;
      this.columnHeader6.Text = "Aggr";
      this.columnHeader6.Width = 50;
      this.columnHeader7.Text = "Exp";
      this.columnHeader7.Width = 50;
      this.columnHeader8.Text = "Tech";
      this.columnHeader8.Width = 50;
      this.columnHeader9.Text = "Sta";
      this.columnHeader9.Width = 50;
      this.columnHeader10.Text = "Cha";
      this.columnHeader10.Width = 50;
      this.columnHeader11.Text = "Mot";
      this.columnHeader11.Width = 50;
      this.columnHeader12.Text = "Weight";
      this.columnHeader12.Width = 50;
      this.comboBoxType.Items.AddRange(new object[7]
      {
        (object) "All",
        (object) "Fitness class",
        (object) "Yoga",
        (object) "PR training",
        (object) "Tech training",
        (object) "Sports psychologist",
        (object) "Ninja classes"
      });
      this.comboBoxType.Location = new Point(96, 8);
      this.comboBoxType.Name = "comboBoxType";
      this.comboBoxType.Size = new Size(104, 21);
      this.comboBoxType.TabIndex = 1;
      this.comboBoxType.Text = "All";
      this.comboBoxType.SelectionChangeCommitted += new EventHandler(this.comboBox1_SelectionChangeCommitted);
      this.labelType.Location = new Point(12, 12);
      this.labelType.Name = "labelType";
      this.labelType.Size = new Size(76, 16);
      this.labelType.TabIndex = 2;
      this.labelType.Text = "Training type:";
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(688, 324);
      this.button1.Name = "button1";
      this.button1.TabIndex = 3;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.labelName.Location = new Point(224, 12);
      this.labelName.Name = "labelName";
      this.labelName.Size = new Size(52, 16);
      this.labelName.TabIndex = 4;
      this.labelName.Text = "Driver:";
      this.comboBoxDriver.Items.AddRange(new object[1]
      {
        (object) "All"
      });
      this.comboBoxDriver.Location = new Point(284, 8);
      this.comboBoxDriver.Name = "comboBoxDriver";
      this.comboBoxDriver.Size = new Size(121, 21);
      this.comboBoxDriver.TabIndex = 5;
      this.comboBoxDriver.Text = "All";
      this.comboBoxDriver.SelectionChangeCommitted += new EventHandler(this.comboBox1_SelectionChangeCommitted);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(772, 354);
      this.Controls.Add((Control) this.comboBoxDriver);
      this.Controls.Add((Control) this.labelName);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.labelType);
      this.Controls.Add((Control) this.comboBoxType);
      this.Icon = Properties.Resources.Car;
      this.MinimumSize = new Size(452, 168);
      this.Name = nameof (DriverTrainingHistory);
      this.Text = "GPRO Organizer : Training History (BETA)";
      this.Controls.SetChildIndex((Control) this.comboBoxType, 0);
      this.Controls.SetChildIndex((Control) this.labelType, 0);
      this.Controls.SetChildIndex((Control) this.button1, 0);
      this.Controls.SetChildIndex((Control) this.labelName, 0);
      this.Controls.SetChildIndex((Control) this.comboBoxDriver, 0);
      this.ResumeLayout(false);
    }

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.UpdateList();
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void ExtraInit()
    {
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.listView1.Location = new Point(12, 36);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(this.Width - 16, this.Height - 108);
      this.listView1.ContextMenu = this.contextMenu1;
    }
  }
}
