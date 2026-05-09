// Decompiled with JetBrains decompiler
// Type: go.Forms.CarWearForm
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Utils;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class CarWearForm : Form
  {
    private ListView listView1;
    private ColumnHeader Level;
    private ColumnHeader Engine;
    private ColumnHeader FrontWing;
    private ColumnHeader RearWing;
    private ColumnHeader GearBox;
    private ColumnHeader Brakes;
    private ColumnHeader Suspension;
    private ColumnHeader Chassis;
    private ColumnHeader Underbody;
    private ColumnHeader Sidepods;
    private ColumnHeader Cooling;
    private ColumnHeader Electronics;
    private Button button1;
    private ContextMenu contextMenu1;
    private MenuItem menuItemExportToCSV;
    private int INDEX_CHASSIS;
    private int INDEX_ENGINE = 1;
    private int INDEX_FRONTWING = 2;
    private int INDEX_REARWING = 3;
    private int INDEX_UNDERBODY = 4;
    private int INDEX_SIDEPODS = 5;
    private int INDEX_COOLING = 6;
    private int INDEX_GEARBOX = 7;
    private int INDEX_BRAKES = 8;
    private int INDEX_SUSPENSION = 9;
    private int INDEX_ELECTRONICS = 10;

    public CarWearForm()
    {
      this.InitializeComponent();
      PartsWear[] partsWearArray = new PartsWear[11];
      for (int index = 0; index < partsWearArray.Length; ++index)
        partsWearArray[index] = new PartsWear();
      foreach (Season20 season in Datas.Seasons)
      {
        if (season != null)
        {
          foreach (RaceEvent20 raceEvent20 in season.Events)
          {
            if (raceEvent20.isRaceUpdated && raceEvent20.isCarUpdated && raceEvent20.Race.DidFinishRace && raceEvent20.Startcar.power != 0)
            {
              Car2 startcar = raceEvent20.Startcar;
              Car2 endcar = raceEvent20.Endcar;
              if (endcar.frontWing.wear - startcar.frontWing.wear > 0)
              {
                ++partsWearArray[this.INDEX_FRONTWING].wear[startcar.frontWing.level - 1].a;
                partsWearArray[this.INDEX_FRONTWING].wear[startcar.frontWing.level - 1].b += endcar.frontWing.wear - startcar.frontWing.wear;
              }
              if (endcar.rearWing.wear - startcar.rearWing.wear > 0)
              {
                ++partsWearArray[this.INDEX_REARWING].wear[startcar.rearWing.level - 1].a;
                partsWearArray[this.INDEX_REARWING].wear[startcar.rearWing.level - 1].b += endcar.rearWing.wear - startcar.rearWing.wear;
              }
              if (endcar.brakes.wear - startcar.brakes.wear > 0)
              {
                ++partsWearArray[this.INDEX_BRAKES].wear[startcar.brakes.level - 1].a;
                partsWearArray[this.INDEX_BRAKES].wear[startcar.brakes.level - 1].b += endcar.brakes.wear - startcar.brakes.wear;
              }
              if (endcar.chassis.wear - startcar.chassis.wear > 0)
              {
                ++partsWearArray[this.INDEX_CHASSIS].wear[startcar.chassis.level - 1].a;
                partsWearArray[this.INDEX_CHASSIS].wear[startcar.chassis.level - 1].b += endcar.chassis.wear - startcar.chassis.wear;
              }
              if (endcar.cooling.wear - startcar.cooling.wear > 0)
              {
                ++partsWearArray[this.INDEX_COOLING].wear[startcar.cooling.level - 1].a;
                partsWearArray[this.INDEX_COOLING].wear[startcar.cooling.level - 1].b += endcar.cooling.wear - startcar.cooling.wear;
              }
              if (endcar.electronics.wear - startcar.electronics.wear > 0)
              {
                ++partsWearArray[this.INDEX_ELECTRONICS].wear[startcar.electronics.level - 1].a;
                partsWearArray[this.INDEX_ELECTRONICS].wear[startcar.electronics.level - 1].b += endcar.electronics.wear - startcar.electronics.wear;
              }
              if (endcar.engine.wear - startcar.engine.wear > 0)
              {
                ++partsWearArray[this.INDEX_ENGINE].wear[startcar.engine.level - 1].a;
                partsWearArray[this.INDEX_ENGINE].wear[startcar.engine.level - 1].b += endcar.engine.wear - startcar.engine.wear;
              }
              if (endcar.gearBox.wear - startcar.gearBox.wear > 0)
              {
                ++partsWearArray[this.INDEX_GEARBOX].wear[startcar.gearBox.level - 1].a;
                partsWearArray[this.INDEX_GEARBOX].wear[startcar.gearBox.level - 1].b += endcar.gearBox.wear - startcar.gearBox.wear;
              }
              if (endcar.sidepods.wear - startcar.sidepods.wear > 0)
              {
                ++partsWearArray[this.INDEX_SIDEPODS].wear[startcar.sidepods.level - 1].a;
                partsWearArray[this.INDEX_SIDEPODS].wear[startcar.sidepods.level - 1].b += endcar.sidepods.wear - startcar.sidepods.wear;
              }
              if (endcar.suspension.wear - startcar.suspension.wear > 0)
              {
                ++partsWearArray[this.INDEX_SUSPENSION].wear[startcar.suspension.level - 1].a;
                partsWearArray[this.INDEX_SUSPENSION].wear[startcar.suspension.level - 1].b += endcar.suspension.wear - startcar.suspension.wear;
              }
              if (endcar.underbody.wear - startcar.underbody.wear > 0)
              {
                ++partsWearArray[this.INDEX_UNDERBODY].wear[startcar.underbody.level - 1].a;
                partsWearArray[this.INDEX_UNDERBODY].wear[startcar.underbody.level - 1].b += endcar.underbody.wear - startcar.underbody.wear;
              }
            }
          }
        }
      }
      for (int index = 0; index < 9; ++index)
        this.listView1.Items.Add(new ListViewItem((index + 1).ToString())
        {
          SubItems = {
            this.GetSubItemText(partsWearArray[this.INDEX_CHASSIS].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_ENGINE].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_FRONTWING].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_REARWING].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_UNDERBODY].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_SIDEPODS].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_COOLING].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_GEARBOX].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_BRAKES].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_SUSPENSION].wear[index]),
            this.GetSubItemText(partsWearArray[this.INDEX_ELECTRONICS].wear[index])
          }
        });
    }

    private string GetSubItemText(IntPair pair)
    {
      return pair.a == 0 ? "?" : ((double) pair.b / (double) pair.a).ToString("N2");
    }

    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (CarWearForm));
      this.listView1 = new ListView();
      this.Level = new ColumnHeader();
      this.Chassis = new ColumnHeader();
      this.Engine = new ColumnHeader();
      this.FrontWing = new ColumnHeader();
      this.RearWing = new ColumnHeader();
      this.Underbody = new ColumnHeader();
      this.Sidepods = new ColumnHeader();
      this.Cooling = new ColumnHeader();
      this.GearBox = new ColumnHeader();
      this.Brakes = new ColumnHeader();
      this.Suspension = new ColumnHeader();
      this.Electronics = new ColumnHeader();
      this.button1 = new Button();
      this.contextMenu1 = new ContextMenu();
      this.menuItemExportToCSV = new MenuItem();
      this.SuspendLayout();
      this.listView1.Columns.AddRange(new ColumnHeader[12]
      {
        this.Level,
        this.Chassis,
        this.Engine,
        this.FrontWing,
        this.RearWing,
        this.Underbody,
        this.Sidepods,
        this.Cooling,
        this.GearBox,
        this.Brakes,
        this.Suspension,
        this.Electronics
      });
      this.listView1.ContextMenu = this.contextMenu1;
      this.listView1.FullRowSelect = true;
      this.listView1.GridLines = true;
      this.listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.listView1.Location = new Point(0, 0);
      this.listView1.Name = "listView1";
      this.listView1.Scrollable = false;
      this.listView1.Size = new Size(668, 148);
      this.listView1.TabIndex = 0;
      this.listView1.View = View.Details;
      this.Level.Text = "Level";
      this.Level.Width = 39;
      this.Chassis.Text = "Chassis";
      this.Chassis.TextAlign = HorizontalAlignment.Center;
      this.Chassis.Width = 49;
      this.Engine.Text = "Engine";
      this.Engine.TextAlign = HorizontalAlignment.Center;
      this.Engine.Width = 45;
      this.FrontWing.Text = "Front Wing";
      this.FrontWing.TextAlign = HorizontalAlignment.Center;
      this.FrontWing.Width = 64;
      this.RearWing.Text = "Rear Wing";
      this.RearWing.TextAlign = HorizontalAlignment.Center;
      this.RearWing.Width = 64;
      this.Underbody.Text = "Underbody";
      this.Underbody.TextAlign = HorizontalAlignment.Center;
      this.Underbody.Width = 65;
      this.Sidepods.Text = "Sidepods";
      this.Sidepods.TextAlign = HorizontalAlignment.Center;
      this.Sidepods.Width = 57;
      this.Cooling.Text = "Cooling";
      this.Cooling.TextAlign = HorizontalAlignment.Center;
      this.Cooling.Width = 48;
      this.GearBox.Text = "Gearbox";
      this.GearBox.TextAlign = HorizontalAlignment.Center;
      this.GearBox.Width = 52;
      this.Brakes.Text = "Brakes";
      this.Brakes.TextAlign = HorizontalAlignment.Center;
      this.Brakes.Width = 46;
      this.Suspension.Text = "Suspension";
      this.Suspension.TextAlign = HorizontalAlignment.Center;
      this.Suspension.Width = 68;
      this.Electronics.Text = "Electronics";
      this.Electronics.TextAlign = HorizontalAlignment.Center;
      this.Electronics.Width = 65;
      this.contextMenu1.MenuItems.AddRange(new MenuItem[1]
      {
        this.menuItemExportToCSV
      });
      this.menuItemExportToCSV.Index = 0;
      this.menuItemExportToCSV.Text = "Export to CSV";
      this.menuItemExportToCSV.Click += new EventHandler(this.menuItemExportToCSV_Click);
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(588, 156);
      this.button1.Name = "button1";
      this.button1.TabIndex = 1;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(668, 186);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.listView1);
      this.Icon = Properties.Resources.Car;
      this.MaximumSize = new Size(676, 220);
      this.MinimumSize = new Size(676, 220);
      this.Name = nameof (CarWearForm);
      this.Text = "GPRO Organizer : Average Car Wear";
      this.ResumeLayout(false);
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    protected void menuItemExportToCSV_Click(object sender, EventArgs e)
    {
      new CSVWriter(this.listView1).save((Form) this);
    }
  }
}
