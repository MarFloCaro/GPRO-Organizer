 
// Type: go.Forms.PracticeHelperForm
 
 
 

using go.Comms;
using go.Parsers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class PracticeHelperForm : Form
  {
    private readonly Communication comms;
    private Button ReloadDataButton;
    private TextBox driverSatisfactionSpan;
    private Label label1;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;

    public PracticeHelperForm(Communication comms, ref Driver5 driver)
    {
      this.comms = comms;
      this.InitializeComponent();
      this.driverSatisfactionSpan.Text = (125 - driver.technicalInsight / 3).ToString();
      this.ReloadData();
    }

    private void ReloadDataButton_Click(object sender, EventArgs e) => this.ReloadData();

    private void ReloadData()
    {
      RaceWeather wf = new RaceWeather();
      Practice3 practice = PracticeParser.ParsePractice(ref wf);
      int driverSatisfaction = int.Parse(this.driverSatisfactionSpan.Text);
      int num1 = 0;
      int num2 = int.MaxValue;
      int num3 = int.MaxValue;
      int num4 = 0;
      int num5 = 0;
      int num6 = int.MaxValue;
      int num7 = int.MaxValue;
      int num8 = 0;
      int num9 = 0;
      int num10 = int.MaxValue;
      int num11 = int.MaxValue;
      int num12 = 0;
      int num13 = 0;
      int num14 = int.MaxValue;
      int num15 = int.MaxValue;
      int num16 = 0;
      int num17 = 0;
      int num18 = int.MaxValue;
      int num19 = int.MaxValue;
      int num20 = 0;
      foreach (PracticeRun run in practice.runs)
      {
        if (run.netTime > TimeSpan.Zero)
        {
          string comments1 = this.getComments(run.comments, "Wings");
          switch (comments1)
          {
            case "The car could have a bit more speed in the straights":
            case "The car is lacking some speed in the straights":
              num3 = Math.Min(num3, run.setup.fWing + run.setup.rWing);
              break;
            case "I am missing a bit of grip in the curves":
            case "The car is very unstable in many corners":
              num1 = Math.Max(num1, run.setup.fWing + run.setup.rWing);
              break;
            case "I cannot drive the car, there's no grip on it":
              num1 = Math.Max(num1, 500);
              break;
            case "I am really missing a lot of speed in straights":
              num3 = Math.Max(500, num3);
              break;
            case "":
              num4 = Math.Max(num4, run.setup.fWing + run.setup.rWing);
              num2 = Math.Min(num2, run.setup.fWing + run.setup.rWing);
              break;
            default:
              throw new Exception("Unknown Wingcomment:" + comments1);
          }
          string comments2 = this.getComments(run.comments, "Engine");
          switch (comments2)
          {
            case "Try to favor a bit more the low revs":
            case "The engine revs are too high":
              num7 = Math.Min(num7, run.setup.engine);
              break;
            case "I feel that I do not have enough engine power in the straights":
            case "The engine power on the straights is not sufficient":
              num5 = Math.Max(num5, run.setup.engine);
              break;
            case "You should try to favor a lot more the high revs":
              num5 = Math.Max(num5, 500);
              break;
            case "No, no, no!!! Favor a lot more the low revs!":
              num7 = Math.Max(num7, 500);
              break;
            case "":
              num8 = Math.Max(num8, run.setup.engine);
              num6 = Math.Min(num6, run.setup.engine);
              break;
            default:
              throw new Exception("Unknown Engine comment:" + comments2);
          }
          string comments3 = this.getComments(run.comments, "Brakes");
          switch (comments3)
          {
            case "Put the balance a bit more to the back":
              num11 = Math.Min(num11, run.setup.brakes);
              break;
            case "I think the brakes effectiveness could be higher if we move the balance to the front":
            case "I would feel a lot more comfortable to move the balance to the front":
              num9 = Math.Max(num9, 500);
              break;
            case "I would like to have the balance a bit more to the front":
              num9 = Math.Max(num9, run.setup.brakes);
              break;
            case "I think the brakes effectiveness could be higher if we move the balance to the back":
            case "Please move the balance a lot more to the back":
              num11 = Math.Min(num11, 500);
              break;
            case "":
              num12 = Math.Max(num12, run.setup.brakes);
              num10 = Math.Min(num10, run.setup.brakes);
              break;
            default:
              throw new Exception("Unknown Brakes comment:" + comments3);
          }
          string comments4 = this.getComments(run.comments, "Gear");
          switch (comments4)
          {
            case "I cannot take advantage of the power of the engine. Put the gear ratio a bit lower":
            case "The gear ratio is too high":
              num15 = Math.Min(num15, run.setup.gear);
              break;
            case "I am very often in the red. Put the gear ratio a bit higher":
            case "The gear ratio is too low":
              num13 = Math.Max(num13, run.setup.gear);
              break;
            case "It feels like the engine is going to explode. Put a lot higher ratio between the gears":
              num13 = Math.Max(num13, 500);
              break;
            case "Please put a lot lower ratio between the gears":
              num15 = Math.Min(num15, 500);
              break;
            case "":
              num16 = Math.Max(num16, run.setup.gear);
              num14 = Math.Min(num14, run.setup.gear);
              break;
            default:
              throw new Exception("Unknown Gear comment:" + comments4);
          }
          string comments5 = this.getComments(run.comments, "Suspension");
          switch (comments5)
          {
            case "The car is too rigid. Lower a bit the rigidity":
            case "The suspension rigidity is too high":
            case "The car is far too rigid. Lower a lot the rigidity":
              num19 = Math.Min(num19, run.setup.susp);
              continue;
            case "The suspension rigidity is too low":
            case "The suspension rigidity should be a lot higher":
            case "I think with a bit more rigid suspension I will be able to go faster":
              num17 = Math.Max(num17, run.setup.susp);
              continue;
            case "":
              num20 = Math.Max(num20, run.setup.susp);
              num18 = Math.Min(num18, run.setup.susp);
              continue;
            default:
              throw new Exception("Unknown Suspension comment:" + comments5);
          }
        }
      }
      this.listView1.Items.Clear();
      int num21 = 1;
      foreach (PracticeRun run in practice.runs)
      {
        ListViewItem listViewItem = new ListViewItem("Practice " + num21++.ToString());
        if (run.netTime > TimeSpan.Zero)
        {
          listViewItem.SubItems.Add(run.setup.fWing.ToString());
          listViewItem.SubItems.Add(run.setup.rWing.ToString());
          listViewItem.SubItems.Add(run.setup.engine.ToString());
          listViewItem.SubItems.Add(run.setup.brakes.ToString());
          listViewItem.SubItems.Add(run.setup.gear.ToString());
          listViewItem.SubItems.Add(run.setup.susp.ToString());
        }
        this.listView1.Items.Add(listViewItem);
      }
      this.listView1.Items.Add("");
      ListViewItem listViewItem1 = new ListViewItem("Next prac. setup");
      ListViewItem.ListViewSubItemCollection subItems1 = listViewItem1.SubItems;
      int num22 = this.getNextSetupValue(num1, num2, num3, num4, driverSatisfaction) / 2;
      string text1 = num22.ToString();
      subItems1.Add(text1);
      ListViewItem.ListViewSubItemCollection subItems2 = listViewItem1.SubItems;
      num22 = this.getNextSetupValue(num1, num2, num3, num4, driverSatisfaction) / 2;
      string text2 = num22.ToString();
      subItems2.Add(text2);
      ListViewItem.ListViewSubItemCollection subItems3 = listViewItem1.SubItems;
      num22 = this.getNextSetupValue(num5, num6, num7, num8, driverSatisfaction);
      string text3 = num22.ToString();
      subItems3.Add(text3);
      ListViewItem.ListViewSubItemCollection subItems4 = listViewItem1.SubItems;
      num22 = this.getNextSetupValue(num9, num10, num11, num12, driverSatisfaction);
      string text4 = num22.ToString();
      subItems4.Add(text4);
      ListViewItem.ListViewSubItemCollection subItems5 = listViewItem1.SubItems;
      num22 = this.getNextSetupValue(num13, num14, num15, num16, driverSatisfaction);
      string text5 = num22.ToString();
      subItems5.Add(text5);
      ListViewItem.ListViewSubItemCollection subItems6 = listViewItem1.SubItems;
      num22 = this.getNextSetupValue(num17, num18, num19, num20, driverSatisfaction);
      string text6 = num22.ToString();
      subItems6.Add(text6);
      this.listView1.Items.Add(listViewItem1);
      ListViewItem listViewItem2 = new ListViewItem("Qual setup");
      ListViewItem.ListViewSubItemCollection subItems7 = listViewItem2.SubItems;
      num22 = this.getNextQualValue(num1, num2, num3, num4, 2 * driverSatisfaction) / 2;
      string text7 = num22.ToString();
      subItems7.Add(text7);
      ListViewItem.ListViewSubItemCollection subItems8 = listViewItem2.SubItems;
      num22 = this.getNextQualValue(num1, num2, num3, num4, 2 * driverSatisfaction) / 2;
      string text8 = num22.ToString();
      subItems8.Add(text8);
      ListViewItem.ListViewSubItemCollection subItems9 = listViewItem2.SubItems;
      num22 = this.getNextQualValue(num5, num6, num7, num8, driverSatisfaction);
      string text9 = num22.ToString();
      subItems9.Add(text9);
      ListViewItem.ListViewSubItemCollection subItems10 = listViewItem2.SubItems;
      num22 = this.getNextQualValue(num9, num10, num11, num12, driverSatisfaction);
      string text10 = num22.ToString();
      subItems10.Add(text10);
      ListViewItem.ListViewSubItemCollection subItems11 = listViewItem2.SubItems;
      num22 = this.getNextQualValue(num13, num14, num15, num16, driverSatisfaction);
      string text11 = num22.ToString();
      subItems11.Add(text11);
      ListViewItem.ListViewSubItemCollection subItems12 = listViewItem2.SubItems;
      num22 = this.getNextQualValue(num17, num18, num19, num20, driverSatisfaction);
      string text12 = num22.ToString();
      subItems12.Add(text12);
      this.listView1.Items.Add(listViewItem2);
    }

    private int getNextSetupValue(
      int minNotOK,
      int minOK,
      int maxNotOK,
      int maxOK,
      int driverSatisfaction)
    {
      if (minNotOK > 0 && minOK == int.MaxValue && maxNotOK == int.MaxValue)
        return minNotOK + driverSatisfaction;
      if (minNotOK > 0 && minOK < int.MaxValue && maxNotOK == int.MaxValue)
        return minNotOK + (minOK - minNotOK) / 2;
      if (minNotOK > 0 && minOK == int.MaxValue && maxNotOK < int.MaxValue)
        return minNotOK + (maxNotOK - minNotOK) / 2;
      if (minNotOK > 0 && minOK < int.MaxValue && maxNotOK < int.MaxValue)
        return minOK - minNotOK > maxNotOK - maxOK ? minNotOK + (minOK - minNotOK) / 2 : maxOK + (maxNotOK - maxOK) / 2;
      if (minNotOK == 0 && maxOK == 0 && maxNotOK < int.MaxValue)
        return maxNotOK - driverSatisfaction;
      if (minNotOK == 0 && maxOK > 0 && maxNotOK < int.MaxValue)
        return maxOK + (maxNotOK - maxOK) / 2;
      return minNotOK == 0 && minOK > 0 && maxNotOK == int.MaxValue ? minOK - driverSatisfaction / 2 : 0;
    }

    private int getNextQualValue(
      int minNotOK,
      int minOK,
      int maxNotOK,
      int maxOK,
      int driverSatisfaction)
    {
      if (minNotOK > 0 && minOK == int.MaxValue && maxNotOK == int.MaxValue)
        return minNotOK + driverSatisfaction / 2;
      if (minNotOK > 0 && minOK < int.MaxValue && maxNotOK == int.MaxValue)
        return minNotOK + (minOK - minNotOK) / 2 + driverSatisfaction / 2;
      if (minNotOK > 0 && minOK == int.MaxValue && maxNotOK < int.MaxValue)
        return minNotOK + (maxNotOK - minNotOK) / 2 + driverSatisfaction / 2;
      if (minNotOK > 0 && minOK < int.MaxValue && maxNotOK < int.MaxValue)
        return minOK - minNotOK > maxNotOK - maxOK ? minNotOK + (minOK - minNotOK) / 2 + driverSatisfaction / 2 : maxOK + (maxNotOK - maxOK) / 2 - driverSatisfaction / 2;
      if (minNotOK == 0 && maxOK == 0 && maxNotOK < int.MaxValue)
        return maxNotOK - driverSatisfaction / 2;
      if (minNotOK == 0 && maxOK > 0 && maxNotOK < int.MaxValue)
        return maxOK + (maxNotOK - maxOK) / 2 - driverSatisfaction / 2;
      return minNotOK == 0 && minOK > 0 && maxNotOK == int.MaxValue ? minOK + (maxOK - minOK) / 2 : 0;
    }

    private string getComments(string[] comments, string part)
    {
      for (int index = 0; index < comments.Length; index += 2)
      {
        if (comments[index].Equals(part))
          return comments[index + 1];
      }
      return "";
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PracticeHelperForm));
      this.ReloadDataButton = new Button();
      this.driverSatisfactionSpan = new TextBox();
      this.label1 = new Label();
      this.listView1 = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.SuspendLayout();
      this.ReloadDataButton.Location = new Point(13, 13);
      this.ReloadDataButton.Name = "ReloadDataButton";
      this.ReloadDataButton.Size = new Size(75, 23);
      this.ReloadDataButton.TabIndex = 0;
      this.ReloadDataButton.Text = "&Reload";
      this.ReloadDataButton.UseVisualStyleBackColor = true;
      this.ReloadDataButton.Click += new EventHandler(this.ReloadDataButton_Click);
      this.driverSatisfactionSpan.Location = new Point(383, 12);
      this.driverSatisfactionSpan.Name = "driverSatisfactionSpan";
      this.driverSatisfactionSpan.Size = new Size(100, 20);
      this.driverSatisfactionSpan.TabIndex = 1;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(260, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(117, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Driver satisfaction span";
      this.listView1.Columns.AddRange(new ColumnHeader[7]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6,
        this.columnHeader7
      });
      this.listView1.FullRowSelect = true;
      this.listView1.GridLines = true;
      this.listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.listView1.Location = new Point(13, 66);
      this.listView1.MultiSelect = false;
      this.listView1.Name = "listView1";
      this.listView1.Scrollable = false;
      this.listView1.Size = new Size(566, 218);
      this.listView1.TabIndex = 3;
      this.listView1.TabStop = false;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = View.Details;
      this.columnHeader1.Text = "";
      this.columnHeader1.Width = 85;
      this.columnHeader2.Text = "Front Wing";
      this.columnHeader2.Width = 80;
      this.columnHeader3.Text = "Rear Wing";
      this.columnHeader3.Width = 80;
      this.columnHeader4.Text = "Engine";
      this.columnHeader4.Width = 80;
      this.columnHeader5.Text = "Brakes";
      this.columnHeader5.Width = 80;
      this.columnHeader6.Text = "Gear";
      this.columnHeader6.Width = 80;
      this.columnHeader7.Text = "Suspension";
      this.columnHeader7.Width = 80;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(608, 308);
      this.Controls.Add((Control) this.listView1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.driverSatisfactionSpan);
      this.Controls.Add((Control) this.ReloadDataButton);
      this.Icon = Resources.Resources.Car;
      this.Name = "PracticeHelper";
      this.Text = "PracticeHelper";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
