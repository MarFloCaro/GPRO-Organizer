 
// Type: go.Forms.PracticeDataExport
 
 
 

using go.Utils;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class PracticeDataExport : Form
  {
    private int GeaMin;
    private int GeaMax = 999;
    private int EngMin;
    private int EngMax = 999;
    private int BraMin;
    private int BraMax = 999;
    private int SusMin;
    private int SusMax = 999;
    private int MaxWings = 1998;
    private int MinWings;
    private int maxDiff = 999;
    private int MinDiff = -999;
    private int DriverWingSumMax = 1998;
    private int DriverWingSumMin;
    private Button button1;
    private TextBox textBox1;

    public PracticeDataExport(RaceEvent20 race, Track track)
    {
      this.InitializeComponent();
      Practice3 practise = race.Practise;
      Car2 car = practise.car;
      this.AddLine("Practice data for " + track.name);
      this.AddLine();
      this.AddLine("Practice runs");
      this.AddLine("# Total time D.Error Net time FWi RWi Eng Bra Gea Sus Tyres");
      for (int index1 = 0; index1 < 8 && !(practise.runs[index1].comments[0] == ""); ++index1)
      {
        this.AddLine((index1 + 1).ToString() + " " + EnumToString.Time2PracExportString(practise.runs[index1].lapTime, true) + " " + EnumToString.Time2PracExportString(practise.runs[index1].driverMistake, true) + " " + EnumToString.Time2PracExportString(practise.runs[index1].netTime, true) + " " + practise.runs[index1].setup.fWing.ToString() + " " + practise.runs[index1].setup.rWing.ToString() + " " + practise.runs[index1].setup.engine.ToString() + " " + practise.runs[index1].setup.brakes.ToString() + " " + practise.runs[index1].setup.gear.ToString() + " " + practise.runs[index1].setup.susp.ToString() + " " + EnumToString.Enum2String(practise.runs[index1].setup.tyres));
        for (int index2 = 0; index2 < index1; ++index2)
        {
          if (this.HasOnlyOneSettingChanged(practise.runs[index1], practise.runs[index2]) && !(practise.runs[index1].netTime == practise.runs[index2].netTime))
          {
            if (practise.runs[index1].netTime > practise.runs[index2].netTime)
              this.UpdateSetting(practise.runs[index2], practise.runs[index1]);
            else
              this.UpdateSetting(practise.runs[index1], practise.runs[index2]);
          }
        }
      }
      this.AddLine();
      this.AddLine("Q1");
      this.AddLine("    Time FWi RWi Eng Bra Gea Sus Tyres Risk");
      Qualify qualify1 = race.Qualify1;
      this.AddLine(EnumToString.Time2PracExportString(qualify1.time, true) + " " + qualify1.setup.fWing.ToString() + " " + qualify1.setup.rWing.ToString() + " " + qualify1.setup.engine.ToString() + " " + qualify1.setup.brakes.ToString() + " " + qualify1.setup.gear.ToString() + " " + qualify1.setup.susp.ToString() + " " + EnumToString.Enum2String(qualify1.setup.tyres) + " " + EnumToString.Enum2String(qualify1.risk));
      this.AddLine();
      this.AddLine("Q2");
      this.AddLine("    Time FWi RWi Eng Bra Gea Sus Tyres Fuel Risk");
      Qualify qualify2 = race.Qualify2;
      this.AddLine(EnumToString.Time2PracExportString(qualify2.time, true) + " " + qualify2.setup.fWing.ToString() + " " + qualify2.setup.rWing.ToString() + " " + qualify2.setup.engine.ToString() + " " + qualify2.setup.brakes.ToString() + " " + qualify2.setup.gear.ToString() + " " + qualify2.setup.susp.ToString() + " " + EnumToString.Enum2String(qualify2.setup.tyres) + " " + qualify2.fuel.ToString() + " " + EnumToString.Enum2String(qualify2.risk));
      this.AddLine();
      this.AddLine("Car data");
      this.AddLine("Wing sums: (" + this.MinWings.ToString() + " - " + this.MaxWings.ToString() + ")");
      this.AddLine("Wing diff: (" + this.MinDiff.ToString() + " - " + this.maxDiff.ToString() + ")");
      this.AddLine("Front wing: " + car.frontWing.level.ToString());
      this.AddLine("Rear wing: " + car.rearWing.level.ToString());
      this.AddLine("Engine: " + car.engine.level.ToString() + " (" + this.EngMin.ToString() + " - " + this.EngMax.ToString() + ")");
      this.AddLine("Brakes: " + car.brakes.level.ToString() + " (" + this.BraMin.ToString() + " - " + this.BraMax.ToString() + ")");
      this.AddLine("Gear: " + car.gearBox.level.ToString() + " (" + this.GeaMin.ToString() + " - " + this.GeaMax.ToString() + ")");
      this.AddLine("Suspension: " + car.suspension.level.ToString() + " (" + this.SusMin.ToString() + " - " + this.SusMax.ToString() + ")");
      this.AddLine("Chassis: " + car.chassis.level.ToString());
      this.AddLine("Underbody: " + car.underbody.level.ToString());
      this.AddLine("Sidepods: " + car.sidepods.level.ToString());
      this.AddLine("Cooling: " + car.cooling.level.ToString());
      this.AddLine("Electronics: " + car.electronics.level.ToString());
      this.AddLine("Wear");
      this.AddLine("Front wing: " + car.frontWing.wear.ToString());
      this.AddLine("Rear wing: " + car.rearWing.wear.ToString());
      this.AddLine("Engine: " + car.engine.wear.ToString());
      this.AddLine("Brakes: " + car.brakes.wear.ToString());
      this.AddLine("Gear: " + car.gearBox.wear.ToString());
      this.AddLine("Suspension: " + car.suspension.wear.ToString());
      this.AddLine("Chassis: " + car.chassis.wear.ToString());
      this.AddLine("Underbody: " + car.underbody.wear.ToString());
      this.AddLine("Sidepods: " + car.sidepods.wear.ToString());
      this.AddLine("Cooling: " + car.cooling.wear.ToString());
      this.AddLine("Electronics: " + car.electronics.wear.ToString());
      Driver5 driver = race.Driver;
      this.AddLine();
      this.AddLine("Driver stats");
      this.AddLine("Overall: " + driver.overall.ToString());
      this.AddLine("Concentration: " + driver.concentration.ToString());
      this.AddLine("Talent: " + driver.talent.ToString());
      this.AddLine("Agressiveness: " + driver.aggresiveness.ToString());
      this.AddLine("Experience: " + driver.experience.ToString());
      this.AddLine("Technical insight: " + driver.technicalInsight.ToString());
      this.AddLine("Stamina: " + driver.stamina.ToString());
      this.AddLine("Charisma: " + driver.charisma.ToString());
      this.AddLine("Motivation: " + driver.motivation.ToString());
      this.AddLine("Reputation: " + driver.reputation.ToString());
      this.AddLine("Weight: " + driver.weight.ToString());
      this.AddLine("Age: " + driver.age.ToString());
    }

    private void UpdateDriverSettings(PracticeRun practiceRun)
    {
      int num = practiceRun.setup.fWing + practiceRun.setup.rWing;
      for (int index = 0; index < practiceRun.comments.Length; ++index)
      {
        if (practiceRun.comments[index].Equals("Wings"))
        {
          if (practiceRun.comments[index + 1].Contains("missing"))
          {
            if (num > this.DriverWingSumMin)
              this.DriverWingSumMin = num;
          }
          else if (num < this.DriverWingSumMax)
            this.DriverWingSumMax = num;
        }
      }
    }

    private void UpdateSetting(PracticeRun goodRun, PracticeRun badRun)
    {
      if (goodRun.setup.fWing + goodRun.setup.rWing != badRun.setup.fWing + badRun.setup.rWing)
      {
        if (goodRun.setup.fWing + goodRun.setup.rWing < badRun.setup.fWing + badRun.setup.rWing)
        {
          if (this.MaxWings > badRun.setup.fWing + badRun.setup.rWing)
            this.MaxWings = badRun.setup.fWing + badRun.setup.rWing;
        }
        else if (this.MinWings < badRun.setup.fWing + badRun.setup.rWing)
          this.MinWings = badRun.setup.fWing + badRun.setup.rWing;
      }
      else if (goodRun.setup.fWing - goodRun.setup.rWing != badRun.setup.fWing - badRun.setup.rWing)
      {
        if (goodRun.setup.fWing - goodRun.setup.rWing < badRun.setup.fWing - badRun.setup.rWing)
        {
          if (this.maxDiff > badRun.setup.fWing - badRun.setup.rWing)
            this.maxDiff = badRun.setup.fWing - badRun.setup.rWing;
        }
        else if (this.MinDiff < badRun.setup.fWing - badRun.setup.rWing)
          this.MinDiff = badRun.setup.fWing - badRun.setup.rWing;
      }
      if (goodRun.setup.gear != badRun.setup.gear)
      {
        if (goodRun.setup.gear < badRun.setup.gear)
        {
          if (this.GeaMax > badRun.setup.gear)
            this.GeaMax = badRun.setup.gear;
        }
        else if (this.GeaMin < badRun.setup.gear)
          this.GeaMin = badRun.setup.gear;
      }
      if (goodRun.setup.engine != badRun.setup.engine)
      {
        if (goodRun.setup.engine < badRun.setup.engine)
        {
          if (this.EngMax > badRun.setup.engine)
            this.EngMax = badRun.setup.engine;
        }
        else if (this.EngMin < badRun.setup.engine)
          this.EngMin = badRun.setup.engine;
      }
      if (goodRun.setup.brakes != badRun.setup.brakes)
      {
        if (goodRun.setup.brakes < badRun.setup.brakes)
        {
          if (this.BraMax > badRun.setup.brakes)
            this.BraMax = badRun.setup.brakes;
        }
        else if (this.BraMin < badRun.setup.brakes)
          this.BraMin = badRun.setup.brakes;
      }
      if (goodRun.setup.susp == badRun.setup.susp)
        return;
      if (goodRun.setup.susp < badRun.setup.susp)
      {
        if (this.SusMax <= badRun.setup.susp)
          return;
        this.SusMax = badRun.setup.susp;
      }
      else
      {
        if (this.SusMin >= badRun.setup.susp)
          return;
        this.SusMin = badRun.setup.susp;
      }
    }

    private bool XOR(bool a, bool b)
    {
      if (!(!a | b))
        return true;
      return !a && b;
    }

    private bool HasOnlyOneSettingChanged(PracticeRun newRun, PracticeRun oldRun)
    {
      if (newRun.setup.tyres != oldRun.setup.tyres)
        return false;
      int num1 = 0;
      int num2 = newRun.setup.fWing + newRun.setup.rWing == oldRun.setup.fWing + oldRun.setup.rWing ? 1 : 0;
      bool flag = newRun.setup.fWing - newRun.setup.rWing == oldRun.setup.fWing - oldRun.setup.rWing;
      if (num2 == 0)
        ++num1;
      if (!flag)
        ++num1;
      if (newRun.setup.gear != oldRun.setup.gear)
        ++num1;
      if (newRun.setup.engine != oldRun.setup.engine)
        ++num1;
      if (newRun.setup.brakes != oldRun.setup.brakes)
        ++num1;
      if (newRun.setup.susp != oldRun.setup.susp)
        ++num1;
      return num1 == 1;
    }

    private void AddLine(string tmp)
    {
      TextBox textBox1 = this.textBox1;
      textBox1.Text = textBox1.Text + tmp + "\r\n";
    }

    private void AddLine() => this.textBox1.Text += "\r\n";

    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (PracticeDataExport));
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.SuspendLayout();
      this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.textBox1.Location = new Point(0, 0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(320, 357);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "";
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(232, 365);
      this.button1.Name = "button1";
      this.button1.TabIndex = 1;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(322, 397);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Icon = Resources.Resources.Car;
      this.MinimumSize = new Size(330, 431);
      this.Name = nameof (PracticeDataExport);
      this.Text = "GPRO Organizer : Practice Export";
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();
  }
}
