 
// Type: go.Forms.CarHistoryForm
 
 
 

using go.Enums;
using go.History;
using go.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class CarHistoryForm : Form
  {
    private const string formName = "CarHistory";
    private CarHistory2 history;
    private ListViewColumnSorter lvwColumnSorter;
    private int INDEX_POWER = 2;
    private int INDEX_HANDLING = 3;
    private int INDEX_ACCELERATION = 4;
    private int INDEX_CHASSIS = 5;
    private int INDEX_ENGINE = 6;
    private int INDEX_FRONTWING = 7;
    private int INDEX_REARWING = 8;
    private int INDEX_UNDERBODY = 9;
    private int INDEX_SIDEPODS = 10;
    private int INDEX_COOLING = 11;
    private int INDEX_GEARBOX = 12;
    private int INDEX_BRAKES = 13;
    private int INDEX_SUSPENSION = 14;
    private int INDEX_ELECTRONICS = 15;
    private FormHandler handler;
    private FormInfo formInfo = new FormInfo();
    private ListView listView1;
    private Button button1;
    private ContextMenu contextMenu1;
    private MenuItem menuItemCopyLines;
    private MenuItem menuItemCopyChanges;
    private MenuItem menuItemChooseColumns;
    private MenuItem menuItemExportToCSV;

    public CarHistoryForm(ref FormHandler handler, ref CarHistory2 history)
    {
      this.InitializeComponent();
      this.handler = handler;
      this.formInfo = handler.GetFormInfo("CarHistory");
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.history = history;
      this.lvwColumnSorter = new ListViewColumnSorter();
      this.listView1.ListViewItemSorter = (IComparer) this.lvwColumnSorter;
      this.SetColumns();
      this.ListAll();
      this.Show();
      if (this.listView1.Items.Count <= 0)
        return;
      this.listView1.EnsureVisible(this.listView1.Items.Count - 1);
    }

    private void ListAll()
    {
      if (this.history.historyList.Count == 0)
        return;
      this.listView1.Items.Clear();
      CarHistoryItem2 carHistoryItem2 = new CarHistoryItem2();
      for (int index = 0; index < this.history.historyList.Count; ++index)
      {
        CarHistoryItem2 history = (CarHistoryItem2) this.history.historyList[index];
        if (!carHistoryItem2.car.IsSameLevelsAndPHA(history.car))
        {
          carHistoryItem2 = history;
          ListViewItem listViewItem = new ListViewItem()
          {
            UseItemStyleForSubItems = false
          };
          foreach (ColumnInfo columnInfo in this.formInfo.columnInfo)
          {
            switch (columnInfo)
            {
              case ColumnInfo.CarChassisLevel:
                listViewItem.SubItems.Add(history.car.chassis.level.ToString());
                continue;
              case ColumnInfo.CarEngineLevel:
                listViewItem.SubItems.Add(history.car.engine.level.ToString());
                continue;
              case ColumnInfo.CarFrontWingLevel:
                listViewItem.SubItems.Add(history.car.frontWing.level.ToString());
                continue;
              case ColumnInfo.CarRearWingLevel:
                listViewItem.SubItems.Add(history.car.rearWing.level.ToString());
                continue;
              case ColumnInfo.CarUnderbodyLevel:
                listViewItem.SubItems.Add(history.car.underbody.level.ToString());
                continue;
              case ColumnInfo.CarSidepodsLevel:
                listViewItem.SubItems.Add(history.car.sidepods.level.ToString());
                continue;
              case ColumnInfo.CarCoolingLevel:
                listViewItem.SubItems.Add(history.car.cooling.level.ToString());
                continue;
              case ColumnInfo.CarGearboxLevel:
                listViewItem.SubItems.Add(history.car.gearBox.level.ToString());
                continue;
              case ColumnInfo.CarBrakesLevel:
                listViewItem.SubItems.Add(history.car.brakes.level.ToString());
                continue;
              case ColumnInfo.CarSuspensionLevel:
                listViewItem.SubItems.Add(history.car.suspension.level.ToString());
                continue;
              case ColumnInfo.CarElectronicsLevel:
                listViewItem.SubItems.Add(history.car.electronics.level.ToString());
                continue;
              case ColumnInfo.CarPowerLevel:
                listViewItem.SubItems.Add(history.car.power.ToString() + (history.car.testPower > 0.0 ? "(" + history.car.testPower.ToString("N0") + ")" : ""));
                continue;
              case ColumnInfo.CarHandlingLevel:
                listViewItem.SubItems.Add(history.car.handling.ToString() + (history.car.testHandling > 0.0 ? "(" + history.car.testHandling.ToString("N0") + ")" : ""));
                continue;
              case ColumnInfo.CarAccelerationLevel:
                listViewItem.SubItems.Add(history.car.acceleration.ToString() + (history.car.testAcceleration > 0.0 ? "(" + history.car.testAcceleration.ToString("N0") + ")" : ""));
                continue;
              case ColumnInfo.StintSeason:
                listViewItem.SubItems.Add(history.date.season.ToString());
                continue;
              case ColumnInfo.StintRace:
                listViewItem.SubItems.Add(history.date.race.ToString());
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
            this.listView1.Items.Add(listViewItem);
          }
        }
      }
      this.UpdateColumnSizes();
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CarHistoryForm));
      this.listView1 = new ListView();
      this.contextMenu1 = new ContextMenu();
      this.menuItemChooseColumns = new MenuItem();
      this.menuItemCopyLines = new MenuItem();
      this.menuItemCopyChanges = new MenuItem();
      this.menuItemExportToCSV = new MenuItem();
      this.button1 = new Button();
      this.SuspendLayout();
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.ContextMenu = this.contextMenu1;
      this.listView1.FullRowSelect = true;
      this.listView1.Location = new Point(0, 0);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(568, 240);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = View.Details;
      this.listView1.ColumnClick += new ColumnClickEventHandler(this.listView1_ColumnClick);
      this.contextMenu1.MenuItems.AddRange(new MenuItem[4]
      {
        this.menuItemChooseColumns,
        this.menuItemCopyLines,
        this.menuItemCopyChanges,
        this.menuItemExportToCSV
      });
      this.menuItemChooseColumns.Index = 0;
      this.menuItemChooseColumns.Text = "Choose Columns";
      this.menuItemChooseColumns.Click += new EventHandler(this.menuItemChooseColumns_Click);
      this.menuItemCopyLines.Index = 1;
      this.menuItemCopyLines.Text = "Copy lines to clipboard";
      this.menuItemCopyLines.Click += new EventHandler(this.menuItemCopyLines_Click);
      this.menuItemCopyChanges.Index = 2;
      this.menuItemCopyChanges.Text = "Copy changes to clipboard";
      this.menuItemCopyChanges.Click += new EventHandler(this.menuItemCopyChanges_Click);
      this.menuItemExportToCSV.Index = 3;
      this.menuItemExportToCSV.Text = "Export to CSV";
      this.menuItemExportToCSV.Click += new EventHandler(this.menuItemExportToCSV_Click);
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(488, 248);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(568, 278);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.listView1);
      this.Icon = Resources.Resources.Car;
      this.MinimumSize = new Size(560, 312);
      this.Name = nameof (CarHistoryForm);
      this.Text = "GPRO Organizer : Car History";
      this.Closing += new CancelEventHandler(this.Form_Closing);
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
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
      this.listView1.Sort();
    }

    private void menuItemCopyLines_Click(object sender, EventArgs e)
    {
      string tmp = "";
      CarHistoryForm.Addline(ref tmp, "Car History");
      CarHistoryForm.Addline(ref tmp, "");
      CarHistoryForm.Addline(ref tmp, "Season, Race, Pow, Hand, Acc, Cha, Eng, Fwi, Rwi, Und, Sid, Coo, Gea, Bra, Sus, Ele");
      foreach (ListViewItem selectedItem in this.listView1.SelectedItems)
        CarHistoryForm.Addline(ref tmp, selectedItem.SubItems[0].Text + ", " + selectedItem.SubItems[1].Text + ", " + selectedItem.SubItems[2].Text + ", " + selectedItem.SubItems[3].Text + ", " + selectedItem.SubItems[4].Text + ", " + selectedItem.SubItems[5].Text + ", " + selectedItem.SubItems[6].Text + ", " + selectedItem.SubItems[7].Text + ", " + selectedItem.SubItems[8].Text + ", " + selectedItem.SubItems[9].Text + ", " + selectedItem.SubItems[10].Text + ", " + selectedItem.SubItems[11].Text + ", " + selectedItem.SubItems[12].Text + ", " + selectedItem.SubItems[13].Text + ", " + selectedItem.SubItems[14].Text + ", " + selectedItem.SubItems[15].Text);
      Clipboard.SetDataObject((object) tmp);
    }

    private static void Addline(ref string tmp, string noget) => tmp = tmp + noget + "\r\n";

    private void menuItemCopyChanges_Click(object sender, EventArgs e)
    {
      if (this.listView1.SelectedItems.Count < 2)
      {
        int num = (int) MessageBox.Show("You have to select at least two rows to be able to copy changes", "Not enough rows selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        ListViewItem listViewItem1 = this.listView1.SelectedItems[0];
        string data = "";
        CarHistoryForm.Addline(ref data, "Car Update History");
        foreach (ListViewItem selectedItem in this.listView1.SelectedItems)
        {
          bool prependComma = false;
          ListViewItem listViewItem2 = selectedItem;
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_CHASSIS, "Cha", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_ENGINE, "Eng", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_FRONTWING, "FWi", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_REARWING, "Rwi", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_UNDERBODY, "Und", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_SIDEPODS, "Sid", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_COOLING, "Coo", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_GEARBOX, "Gea", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_BRAKES, "Bra", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_SUSPENSION, "Sus", ref prependComma);
          CarHistoryForm.UpdateChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_ELECTRONICS, "Ele", ref prependComma);
          this.UpdateMainChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_POWER, "Power");
          this.UpdateMainChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_HANDLING, "Handling");
          this.UpdateMainChange(ref data, ref listViewItem1, ref listViewItem2, this.INDEX_ACCELERATION, "Acceleration");
          CarHistoryForm.Addline(ref data, "");
          listViewItem1 = listViewItem2;
        }
        Clipboard.SetDataObject((object) data);
      }
    }

    private void UpdateMainChange(
      ref string inout,
      ref ListViewItem item1,
      ref ListViewItem item2,
      int index,
      string name)
    {
      int num = CarHistoryForm.ParseMainStat(item2.SubItems[index].Text) - CarHistoryForm.ParseMainStat(item1.SubItems[index].Text);
      if (num == 0)
        return;
      string str = inout;
      inout = str + ", " + name + " " + (num > 0 ? "+" : "") + num.ToString();
    }

    private static int ParseMainStat(string stat)
    {
      return stat.IndexOf("(") < 0 ? int.Parse(stat) : int.Parse(stat.Substring(0, stat.IndexOf("(")));
    }

    private static void UpdateChange(
      ref string inout,
      ref ListViewItem item1,
      ref ListViewItem item2,
      int index,
      string name,
      ref bool prependComma)
    {
      if (!CarHistoryForm.AreIndexesDifferent(ref item1, ref item2, index))
        return;
      if (prependComma)
        inout += ", ";
      string str = inout;
      inout = str + name + "(" + item1.SubItems[index].Text + "->" + item2.SubItems[index].Text + ")";
      prependComma = true;
    }

    private static bool AreIndexesDifferent(
      ref ListViewItem item1,
      ref ListViewItem item2,
      int index)
    {
      return item1.SubItems[index].Text != item2.SubItems[index].Text;
    }

    private void SetColumns()
    {
      this.INDEX_POWER = 2;
      this.INDEX_HANDLING = 3;
      this.INDEX_ACCELERATION = 4;
      this.INDEX_CHASSIS = 5;
      this.INDEX_ENGINE = 6;
      this.INDEX_FRONTWING = 7;
      this.INDEX_REARWING = 8;
      this.INDEX_UNDERBODY = 9;
      this.INDEX_SIDEPODS = 10;
      this.INDEX_COOLING = 11;
      this.INDEX_GEARBOX = 12;
      this.INDEX_BRAKES = 13;
      this.INDEX_SUSPENSION = 14;
      this.INDEX_ELECTRONICS = 15;
      this.listView1.Columns.Clear();
      int num = -1;
      for (int index = 0; index < this.formInfo.columnInfo.Count && index < this.formInfo.columnWidths.Count; ++index)
      {
        ColumnInfo columnInfo = (ColumnInfo) this.formInfo.columnInfo[index];
        ++num;
        this.listView1.Columns.Add(EnumToString.Enum2ShortString(columnInfo), (int) this.formInfo.columnWidths[index], this.handler.GetColumnAlignment(columnInfo));
        switch (columnInfo)
        {
          case ColumnInfo.CarChassisLevel:
            this.INDEX_CHASSIS = num;
            break;
          case ColumnInfo.CarEngineLevel:
            this.INDEX_ENGINE = num;
            break;
          case ColumnInfo.CarFrontWingLevel:
            this.INDEX_FRONTWING = num;
            break;
          case ColumnInfo.CarRearWingLevel:
            this.INDEX_REARWING = num;
            break;
          case ColumnInfo.CarUnderbodyLevel:
            this.INDEX_UNDERBODY = num;
            break;
          case ColumnInfo.CarSidepodsLevel:
            this.INDEX_SIDEPODS = num;
            break;
          case ColumnInfo.CarCoolingLevel:
            this.INDEX_COOLING = num;
            break;
          case ColumnInfo.CarGearboxLevel:
            this.INDEX_GEARBOX = num;
            break;
          case ColumnInfo.CarBrakesLevel:
            this.INDEX_BRAKES = num;
            break;
          case ColumnInfo.CarSuspensionLevel:
            this.INDEX_SUSPENSION = num;
            break;
          case ColumnInfo.CarElectronicsLevel:
            this.INDEX_ELECTRONICS = num;
            break;
          case ColumnInfo.CarPowerLevel:
            this.INDEX_POWER = num;
            break;
          case ColumnInfo.CarHandlingLevel:
            this.INDEX_HANDLING = num;
            break;
          case ColumnInfo.CarAccelerationLevel:
            this.INDEX_ACCELERATION = num;
            break;
        }
      }
    }

    private void UpdateColumnSizes()
    {
      for (int index = 0; index < this.listView1.Columns.Count && index < this.formInfo.columnWidths.Count; ++index)
      {
        if ((int) this.formInfo.columnWidths[index] < 0)
          this.listView1.Columns[index].Width = -1;
      }
    }

    private void menuItemChooseColumns_Click(object sender, EventArgs e)
    {
      int num = (int) new ColumnChooser("CarHistory").ShowDialog();
      this.formInfo = this.handler.GetFormInfo("CarHistory");
      this.SetColumns();
      this.ListAll();
    }

    private void Form_Closing(object sender, CancelEventArgs e)
    {
      this.formInfo.columnWidths.Clear();
      foreach (ColumnHeader column in this.listView1.Columns)
        this.formInfo.columnWidths.Add((object) column.Width);
      this.formInfo.formHeight = this.Height;
      this.formInfo.formWidth = this.Width;
      this.handler.SetFormInfo("CarHistory", this.formInfo);
    }

    protected void menuItemExportToCSV_Click(object sender, EventArgs e)
    {
      new CSVWriter(this.listView1).save((Form) this);
    }
  }
}
