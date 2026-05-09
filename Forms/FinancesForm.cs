// Decompiled with JetBrains decompiler
// Type: go.Forms.FinancesForm
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
  public class FinancesForm : Form
  {
    private Button button1;
    private TabControl tabControl1;
    private int sponsors;
    private int bonus;
    private int qualmoney;
    private int racemoney;
    private int fastestLap;
    private int cupmoney;
    private go.CarPartCosts costs = new go.CarPartCosts();
    private int driverwage;
    private int drivercompensation;
    private int driveroffer;
    private int drivertraining;
    private int driverSigningFee;
    private int tyresupplier;
    private int staffWage;
    private int staffTraning;
    private int facilitiesCost;
    private int facilitiesUpgrade;
    private int tdWage;
    private int tdOffers;
    private int tdCompensation;
    private int tdSigningFee;
    private int racesPractise;
    private int racesQualify1;
    private int racesQualify2;
    private int racesTesting;
    private int car;
    private int chassis;
    private int engine;
    private int frontWing;
    private int rearWing;
    private int underbody;
    private int sidepods;
    private int cooling;
    private int gearbox;
    private int brakes;
    private int suspension;
    private int electronics;

    public FinancesForm()
    {
      this.InitializeComponent();
      int currentseason = -1;
      int index1 = -1;
      if (Datas.Seasons[Datas.Seasons.Count - 1] != null)
        currentseason = Datas.Seasons[Datas.Seasons.Count - 1].Season;
      bool flag1 = false;
      bool flag2 = false;
      foreach (FinanceItem financeItem in Datas.FinanceHistory)
      {
        switch (financeItem.ItemType)
        {
          case FinanceItemType.QualifyingMoney:
            this.qualmoney += financeItem.Amount;
            break;
          case FinanceItemType.RaceMoney:
            flag1 = false;
            int detail = financeItem.Detail;
            if (index1 < 0)
            {
              for (int index2 = 0; index2 < Datas.Seasons.Count; ++index2)
              {
                if (Datas.Seasons[index2].Events[detail - 1].isRaceUpdated)
                {
                  DateTime dateTime = Datas.Seasons[index2].Events[detail - 1].Race.Realdate;
                  string shortDateString1 = dateTime.ToShortDateString();
                  dateTime = financeItem.Date;
                  string shortDateString2 = dateTime.ToShortDateString();
                  if (shortDateString1 == shortDateString2)
                  {
                    index1 = index2;
                    break;
                  }
                }
              }
            }
            if (currentseason < 0 && index1 >= 0)
              currentseason = Datas.Seasons[index1].Season;
            if (index1 >= 0 && Datas.Seasons[index1].Events[detail - 1].isRaceUpdated)
            {
              FinancialAnalysis2 finances = Datas.Seasons[index1].Events[detail - 1].Race.Finances;
              this.driverwage += finances.driverSalary;
              this.staffWage += finances.staffSalary;
              this.facilitiesCost += finances.facilityCost;
              this.sponsors += finances.sponsorMoney;
              this.racemoney += finances.endPositionMoney;
              this.qualmoney += finances.qualPositionMoney;
              this.tyresupplier += finances.tyresContractCost;
              this.tdWage -= Datas.Seasons[index1].Events[detail - 1].TechnicalDirector.salary;
              break;
            }
            break;
          case FinanceItemType.FacilityCost:
            this.facilitiesCost += financeItem.Amount;
            break;
          case FinanceItemType.CarParts:
            foreach (IntPair carPart in this.GetCarParts(financeItem.Description))
            {
              int cost = this.costs.GetCost(carPart.a, (CarPartType) carPart.b);
              switch (carPart.b)
              {
                case 0:
                  this.chassis -= cost;
                  break;
                case 1:
                  this.engine -= cost;
                  break;
                case 2:
                  this.frontWing -= cost;
                  break;
                case 3:
                  this.rearWing -= cost;
                  break;
                case 4:
                  this.underbody -= cost;
                  break;
                case 5:
                  this.sidepods -= cost;
                  break;
                case 6:
                  this.cooling -= cost;
                  break;
                case 7:
                  this.gearbox -= cost;
                  break;
                case 8:
                  this.brakes -= cost;
                  break;
                case 9:
                  this.suspension -= cost;
                  break;
                case 10:
                  this.electronics -= cost;
                  break;
              }
            }
            this.car += financeItem.Amount;
            break;
          case FinanceItemType.PracticeLaps:
            this.racesPractise += financeItem.Amount;
            break;
          case FinanceItemType.Qualifying1:
            this.racesQualify1 += financeItem.Amount;
            break;
          case FinanceItemType.Qualifying2:
            this.racesQualify2 += financeItem.Amount;
            break;
          case FinanceItemType.DriverWage:
            this.driverwage += financeItem.Amount;
            break;
          case FinanceItemType.DriverTraining:
            this.drivertraining += financeItem.Amount;
            break;
          case FinanceItemType.DriverOffer:
            this.driveroffer += financeItem.Amount;
            break;
          case FinanceItemType.DriverCompensation:
            this.drivercompensation += financeItem.Amount;
            break;
          case FinanceItemType.DriverSigningFee:
            this.driverSigningFee += financeItem.Amount;
            break;
          case FinanceItemType.TDOffer:
            this.tdOffers += financeItem.Amount;
            break;
          case FinanceItemType.TDCompensation:
            this.tdCompensation += financeItem.Amount;
            break;
          case FinanceItemType.TDSigningFee:
            this.tdSigningFee += financeItem.Amount;
            break;
          case FinanceItemType.StaffWage:
            this.staffWage += financeItem.Amount;
            break;
          case FinanceItemType.StaffTraining:
            this.staffTraning += financeItem.Amount;
            break;
          case FinanceItemType.FacilityUpgrade:
            this.facilitiesUpgrade += financeItem.Amount;
            break;
          case FinanceItemType.EndOfSeasonBonus:
            if (flag2 && !flag1)
            {
              this.addTab(currentseason);
              --currentseason;
              --index1;
              this.sponsors = 0;
              this.bonus = 0;
              this.qualmoney = 0;
              this.racemoney = 0;
              this.cupmoney = 0;
              this.driverwage = 0;
              this.drivercompensation = 0;
              this.driveroffer = 0;
              this.drivertraining = 0;
              this.driverSigningFee = 0;
              this.staffWage = 0;
              this.staffTraning = 0;
              this.facilitiesCost = 0;
              this.facilitiesUpgrade = 0;
              this.tdWage = 0;
              this.tdOffers = 0;
              this.tdCompensation = 0;
              this.tdSigningFee = 0;
              this.racesPractise = 0;
              this.racesTesting = 0;
              this.racesQualify1 = 0;
              this.racesQualify2 = 0;
              this.car = 0;
              this.chassis = 0;
              this.engine = 0;
              this.frontWing = 0;
              this.rearWing = 0;
              this.underbody = 0;
              this.sidepods = 0;
              this.cooling = 0;
              this.gearbox = 0;
              this.brakes = 0;
              this.suspension = 0;
              this.electronics = 0;
            }
            this.bonus += financeItem.Amount;
            flag1 = true;
            break;
          case FinanceItemType.Sponsors:
            this.sponsors += financeItem.Amount;
            break;
          case FinanceItemType.TestingSession:
            this.racesTesting += financeItem.Amount;
            break;
          case FinanceItemType.CupEarnings:
            this.cupmoney += financeItem.Amount;
            break;
          case FinanceItemType.FastestLap:
            this.fastestLap += financeItem.Amount;
            break;
        }
        flag2 = true;
      }
      this.addTab(currentseason);
    }

    private void addTab(int currentseason)
    {
      FinancePage financePage = new FinancePage(currentseason);
      financePage.Text = "Season " + currentseason.ToString();
      TreeNode treeNode1 = financePage.treeViewIncome.Nodes.Add(this.FillRootNode("Races", EnumToString.Wage2String(this.qualmoney + this.racemoney + this.cupmoney + this.fastestLap)));
      treeNode1.Nodes.Add(this.FillLeafNode("Qual. Money", EnumToString.Wage2String(this.qualmoney)));
      treeNode1.Nodes.Add(this.FillLeafNode("Race Money", EnumToString.Wage2String(this.racemoney)));
      treeNode1.Nodes.Add(this.FillLeafNode("Fastest Laps", EnumToString.Wage2String(this.fastestLap)));
      treeNode1.Nodes.Add(this.FillLeafNode("Cup Money", EnumToString.Wage2String(this.cupmoney)));
      financePage.treeViewIncome.Nodes.Add(this.FillRootNode("Sponsors", EnumToString.Wage2String(this.sponsors)));
      financePage.treeViewIncome.Nodes.Add(this.FillRootNode("End of Season bonuses", EnumToString.Wage2String(this.bonus)));
      TreeNode treeNode2 = financePage.treeViewExpenses.Nodes.Add(this.FillRootNode("Driver", EnumToString.Wage2String(this.driverwage + this.driveroffer + this.drivercompensation + this.drivertraining + this.driverSigningFee)));
      treeNode2.Nodes.Add(this.FillLeafNode("Wages", EnumToString.Wage2String(this.driverwage)));
      treeNode2.Nodes.Add(this.FillLeafNode("Offers", EnumToString.Wage2String(this.driveroffer)));
      treeNode2.Nodes.Add(this.FillLeafNode("Signing Fee", EnumToString.Wage2String(this.driverSigningFee)));
      treeNode2.Nodes.Add(this.FillLeafNode("Compensation", EnumToString.Wage2String(this.drivercompensation)));
      treeNode2.Nodes.Add(this.FillLeafNode("Training", EnumToString.Wage2String(this.drivertraining)));
      TreeNode treeNode3 = financePage.treeViewExpenses.Nodes.Add(this.FillRootNode("Staff", EnumToString.Wage2String(this.staffWage + this.staffTraning)));
      treeNode3.Nodes.Add(this.FillLeafNode("Wages", EnumToString.Wage2String(this.staffWage)));
      treeNode3.Nodes.Add(this.FillLeafNode("Training", EnumToString.Wage2String(this.staffTraning)));
      TreeNode treeNode4 = financePage.treeViewExpenses.Nodes.Add(this.FillRootNode("Facilities", EnumToString.Wage2String(this.facilitiesCost + this.facilitiesUpgrade)));
      treeNode4.Nodes.Add(this.FillLeafNode("Costs", EnumToString.Wage2String(this.facilitiesCost)));
      treeNode4.Nodes.Add(this.FillLeafNode("Upgrade", EnumToString.Wage2String(this.facilitiesUpgrade)));
      TreeNode treeNode5 = financePage.treeViewExpenses.Nodes.Add(this.FillRootNode("Technical Director", EnumToString.Wage2String(this.tdWage + this.tdOffers + this.tdSigningFee + this.tdCompensation)));
      treeNode5.Nodes.Add(this.FillLeafNode("Wages", EnumToString.Wage2String(this.tdWage)));
      treeNode5.Nodes.Add(this.FillLeafNode("Offers", EnumToString.Wage2String(this.tdOffers)));
      treeNode5.Nodes.Add(this.FillLeafNode("Signing Fee", EnumToString.Wage2String(this.tdSigningFee)));
      treeNode5.Nodes.Add(this.FillLeafNode("Compensation", EnumToString.Wage2String(this.tdCompensation)));
      TreeNode treeNode6 = financePage.treeViewExpenses.Nodes.Add(this.FillRootNode("Races", EnumToString.Wage2String(this.racesPractise + this.racesQualify1 + this.racesQualify2 + this.racesTesting)));
      treeNode6.Nodes.Add(this.FillLeafNode("Practice", EnumToString.Wage2String(this.racesPractise)));
      treeNode6.Nodes.Add(this.FillLeafNode("Qualifying 1", EnumToString.Wage2String(this.racesQualify1)));
      treeNode6.Nodes.Add(this.FillLeafNode("Qualifying 2", EnumToString.Wage2String(this.racesQualify2)));
      treeNode6.Nodes.Add(this.FillLeafNode("Testing", EnumToString.Wage2String(this.racesTesting)));
      TreeNode treeNode7 = financePage.treeViewExpenses.Nodes.Add(this.FillRootNode("Car", EnumToString.Wage2String(this.car)));
      treeNode7.Nodes.Add(this.FillLeafNode("Chassis", EnumToString.Wage2String(this.chassis)));
      treeNode7.Nodes.Add(this.FillLeafNode("Engine", EnumToString.Wage2String(this.engine)));
      treeNode7.Nodes.Add(this.FillLeafNode("Front Wing", EnumToString.Wage2String(this.frontWing)));
      treeNode7.Nodes.Add(this.FillLeafNode("Rear Wing", EnumToString.Wage2String(this.rearWing)));
      treeNode7.Nodes.Add(this.FillLeafNode("Underbody", EnumToString.Wage2String(this.underbody)));
      treeNode7.Nodes.Add(this.FillLeafNode("Sidepods", EnumToString.Wage2String(this.sidepods)));
      treeNode7.Nodes.Add(this.FillLeafNode("Cooling", EnumToString.Wage2String(this.cooling)));
      treeNode7.Nodes.Add(this.FillLeafNode("Gearbox", EnumToString.Wage2String(this.gearbox)));
      treeNode7.Nodes.Add(this.FillLeafNode("Brakes", EnumToString.Wage2String(this.brakes)));
      treeNode7.Nodes.Add(this.FillLeafNode("Suspension", EnumToString.Wage2String(this.suspension)));
      treeNode7.Nodes.Add(this.FillLeafNode("Electronics", EnumToString.Wage2String(this.electronics)));
      financePage.treeViewExpenses.Nodes.Add(this.FillRootNode("Tyre Supplier", EnumToString.Wage2String(this.tyresupplier)));
      financePage.label1.Text += EnumToString.Wage2String(this.qualmoney + this.racemoney + this.sponsors + this.bonus + this.fastestLap);
      financePage.label2.Text += EnumToString.Wage2String(this.driverwage + this.driveroffer + this.drivercompensation + this.drivertraining + this.driverSigningFee + this.staffWage + this.staffTraning + this.facilitiesCost + this.facilitiesUpgrade + this.tdWage + this.tdOffers + this.tdSigningFee + this.tdCompensation + this.racesPractise + this.racesQualify1 + this.racesQualify2 + this.car + this.tyresupplier);
      this.tabControl1.TabPages.Add((TabPage) financePage);
    }

    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (FinancesForm));
      this.tabControl1 = new TabControl();
      this.button1 = new Button();
      this.SuspendLayout();
      this.tabControl1.Location = new Point(4, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(680, 292);
      this.tabControl1.TabIndex = 5;
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(608, 308);
      this.button1.Name = "button1";
      this.button1.TabIndex = 0;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(688, 334);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.button1);
      this.Icon = Properties.Resources.Car;
      this.Name = nameof (FinancesForm);
      this.Text = "GPRO Organizer : Fiscal report";
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private string FillRootNode(string nodetext, string amount)
    {
      return nodetext.PadRight(21, ' ') + amount.PadLeft(12, ' ');
    }

    private string FillLeafNode(string nodetext, string amount)
    {
      return nodetext.PadRight(15, ' ') + amount.PadLeft(12, ' ');
    }

    private IntPair[] GetCarParts(string page)
    {
      if (page.IndexOf(":") == page.Length - 1)
        return new IntPair[0];
      string[] strArray = page.Substring(page.IndexOf(":") + 2).Split(',');
      IntPair[] carParts = new IntPair[strArray.Length];
      int index = 0;
      foreach (string str1 in strArray)
      {
        if (str1.Equals("None"))
          return new IntPair[0];
        string str2 = str1.Substring(0, 2);
        int a = int.Parse(str1.Substring(3, 1));
        CarPartType b = CarPartType.Brakes;
        switch (str2)
        {
          case "Br":
            b = CarPartType.Brakes;
            break;
          case "Ch":
            b = CarPartType.Chassis;
            break;
          case "Co":
            b = CarPartType.Cooling;
            break;
          case "El":
            b = CarPartType.Electronics;
            break;
          case "En":
            b = CarPartType.Engine;
            break;
          case "FW":
            b = CarPartType.FrontWing;
            break;
          case "Ge":
            b = CarPartType.Gearbox;
            break;
          case "RW":
            b = CarPartType.RearWing;
            break;
          case "Si":
            b = CarPartType.Sidepods;
            break;
          case "Su":
            b = CarPartType.Suspension;
            break;
          case "Un":
            b = CarPartType.Underbody;
            break;
        }
        carParts[index] = new IntPair(a, (int) b);
        ++index;
      }
      return carParts;
    }
  }
}
