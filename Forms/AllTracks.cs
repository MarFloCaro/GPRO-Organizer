 
// Type: go.Forms.AllTracks
 
 
 

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
  public class AllTracks : GoForm
  {
    private int FUEL_COLUMN = 10;
    private int TYRE_COLUMN = 11;
    private int ID_COLUMN = 14;
    protected ArrayList columns;
    private ComboBox comboBoxfuel;
    private ComboBox comboBoxTyres;
    private MenuItem menuItemOpenNote;
    private Button button1;
    private Label label1;
    private TextBox textBoxName;
    private Label labelTyre;
    private Label labelFuel;

    public AllTracks()
      : base(nameof (AllTracks))
    {
      this.InitializeComponent();
      if (Datas.NextRace >= 0)
        this.textBoxName.Text = Datas.Tracks[Datas.NextRace].name;
      this.Height = this.formInfo.formHeight;
      this.Width = this.formInfo.formWidth;
      this.DisplayComponents();
      this.SetVisibilityOnComboBoxes();
      this.comboBoxfuel.Text = "All";
      this.comboBoxfuel.Items.AddRange((object[]) new string[6]
      {
        "All",
        EnumToString.Enum2String(FuelConsumption.VeryLow),
        EnumToString.Enum2String(FuelConsumption.Low),
        EnumToString.Enum2String(FuelConsumption.Medium),
        EnumToString.Enum2String(FuelConsumption.High),
        EnumToString.Enum2String(FuelConsumption.VeryHigh)
      });
      this.comboBoxTyres.Text = "All";
      this.comboBoxTyres.Items.AddRange((object[]) new string[6]
      {
        "All",
        EnumToString.Enum2String(TyreWear.VeryLow),
        EnumToString.Enum2String(TyreWear.Low),
        EnumToString.Enum2String(TyreWear.Medium),
        EnumToString.Enum2String(TyreWear.High),
        EnumToString.Enum2String(TyreWear.VeryHigh)
      });
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AllTracks));
      this.contextMenu1 = new ContextMenu();
      this.menuItemChooseColumns = new MenuItem();
      this.menuItemExportToCSV = new MenuItem();
      this.menuItemOpenNote = new MenuItem();
      this.comboBoxfuel = new ComboBox();
      this.comboBoxTyres = new ComboBox();
      this.button1 = new Button();
      this.label1 = new Label();
      this.textBoxName = new TextBox();
      this.labelTyre = new Label();
      this.labelFuel = new Label();
      this.SuspendLayout();
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.listView1.ContextMenu = this.contextMenu1;
      this.listView1.FullRowSelect = true;
      this.listView1.GridLines = true;
      this.listView1.Location = new Point(8, 32);
      this.listView1.MultiSelect = false;
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(552, 80);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = View.Details;
      this.contextMenu1.MenuItems.AddRange(new MenuItem[3]
      {
        this.menuItemChooseColumns,
        this.menuItemOpenNote,
        this.menuItemExportToCSV
      });
      this.menuItemChooseColumns.Index = 0;
      this.menuItemChooseColumns.Text = "Choose Columns";
      this.menuItemChooseColumns.Click += new EventHandler(((GoForm) this).menuItemChooseColumns_Click);
      this.menuItemOpenNote.Index = 1;
      this.menuItemOpenNote.Text = "Open note";
      this.menuItemOpenNote.Click += new EventHandler(this.menuItem1_Click);
      this.menuItemExportToCSV.Index = 2;
      this.menuItemExportToCSV.Text = "Export to CSV";
      this.menuItemExportToCSV.Click += new EventHandler(((GoForm) this).menuItemExportToCSV_Click);
      this.comboBoxfuel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.comboBoxfuel.Location = new Point(312, 8);
      this.comboBoxfuel.Name = "comboBoxfuel";
      this.comboBoxfuel.Size = new Size(72, 21);
      this.comboBoxfuel.TabIndex = 1;
      this.comboBoxfuel.SelectedIndexChanged += new EventHandler(this.comboBoxfuel_SelectedIndexChanged);
      this.comboBoxTyres.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.comboBoxTyres.Location = new Point(480, 8);
      this.comboBoxTyres.Name = "comboBoxTyres";
      this.comboBoxTyres.Size = new Size(72, 21);
      this.comboBoxTyres.TabIndex = 2;
      this.comboBoxTyres.SelectedIndexChanged += new EventHandler(this.comboBoxTyres_SelectedIndexChanged);
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(480, 120);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.Location = new Point(16, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(64, 16);
      this.label1.TabIndex = 4;
      this.label1.Text = "Next Race:";
      this.textBoxName.BorderStyle = BorderStyle.None;
      this.textBoxName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBoxName.Location = new Point(80, 8);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.ReadOnly = true;
      this.textBoxName.Size = new Size(96, 13);
      this.textBoxName.TabIndex = 5;
      this.textBoxName.Text = "Unknown";
      this.labelTyre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.labelTyre.Location = new Point(416, 10);
      this.labelTyre.Name = "labelTyre";
      this.labelTyre.Size = new Size(64, 16);
      this.labelTyre.TabIndex = 6;
      this.labelTyre.Text = "Tyre Wear:";
      this.labelFuel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.labelFuel.Location = new Point(208, 10);
      this.labelFuel.Name = "labelFuel";
      this.labelFuel.Size = new Size(104, 16);
      this.labelFuel.TabIndex = 7;
      this.labelFuel.Text = "Fuel Consumption:";
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(568, 150);
      this.Controls.Add((Control) this.labelFuel);
      this.Controls.Add((Control) this.labelTyre);
      this.Controls.Add((Control) this.textBoxName);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.comboBoxTyres);
      this.Controls.Add((Control) this.comboBoxfuel);
      this.Controls.Add((Control) this.listView1);
      this.Icon = Resources.Resources.Car;
      this.MinimumSize = new Size(576, 184);
      this.Name = nameof (AllTracks);
      this.Text = "GPRO Organizer : All GPRO Tracks";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void comboBoxfuel_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.FUEL_COLUMN < 0)
        return;
      this.ListAll();
    }

    protected override void ListAll()
    {
      this.listView1.Items.Clear();
      for (int trackid = 0; trackid < Datas.Tracks.Length; ++trackid)
      {
        ListViewItem listViewItem = new ListViewItem()
        {
          UseItemStyleForSubItems = false
        };
        listViewItem.UseItemStyleForSubItems = true;
        foreach (ColumnInfo column in this.formInfo.columnInfo)
        {
          bool found = false;
          this.checkTrack(column, ref found, listViewItem, trackid);
          if (!found)
            listViewItem.SubItems.Add("-");
        }
        if (listViewItem.SubItems.Count > 1)
        {
          listViewItem.Text = listViewItem.SubItems[1].Text;
          listViewItem.SubItems.RemoveAt(0);
          listViewItem.SubItems.Add(trackid.ToString());
          this.listView1.Items.Add(listViewItem);
        }
        if (trackid == Datas.NextRace)
          listViewItem.BackColor = Color.PaleGreen;
      }
      if (this.comboBoxfuel.SelectedIndex > 0)
        this.SelectFuelConsumption();
      if (this.comboBoxTyres.SelectedIndex <= 0)
        return;
      this.SelectTyreWear();
    }

    private void ListTracksWithFuel(FuelConsumption fuel)
    {
      for (int index = 0; index < this.listView1.Items.Count; ++index)
      {
        if (fuel != StringToEnum.String2Fuel(this.listView1.Items[index].SubItems[this.FUEL_COLUMN].Text))
        {
          this.listView1.Items[index].Remove();
          --index;
        }
      }
    }

    private void ListTracksWithTyre(TyreWear tyres)
    {
      for (int index = 0; index < this.listView1.Items.Count; ++index)
      {
        if (tyres != StringToEnum.String2TyreWear(this.listView1.Items[index].SubItems[this.TYRE_COLUMN].Text))
        {
          this.listView1.Items[index].Remove();
          --index;
        }
      }
    }

    private void comboBoxTyres_SelectedIndexChanged(object sender, EventArgs e) => this.ListAll();

    protected override void SetColumns()
    {
      this.FUEL_COLUMN = -1;
      this.TYRE_COLUMN = -1;
      this.ID_COLUMN = this.formInfo.columnInfo.Count;
      this.listView1.Columns.Clear();
      for (int index = 0; index < this.formInfo.columnInfo.Count && index < this.formInfo.columnWidths.Count; ++index)
      {
        ColumnInfo columnInfo = (ColumnInfo) this.formInfo.columnInfo[index];
        this.listView1.Columns.Add(EnumToString.Enum2ShortString(columnInfo), (int) this.formInfo.columnWidths[index], Datas.FormHandler.GetColumnAlignment(columnInfo));
        switch (columnInfo)
        {
          case ColumnInfo.TrackFuelConsumption:
            this.FUEL_COLUMN = index;
            break;
          case ColumnInfo.TrackTyreWear:
            this.TYRE_COLUMN = index;
            break;
        }
      }
    }

    private void SelectTyreWear()
    {
      int selectedIndex = this.comboBoxTyres.SelectedIndex;
      if (selectedIndex <= 0)
        return;
      this.ListTracksWithTyre(StringToEnum.String2TyreWear((string) this.comboBoxTyres.Items[selectedIndex]));
    }

    private void SelectFuelConsumption()
    {
      int selectedIndex = this.comboBoxfuel.SelectedIndex;
      if (selectedIndex <= 0)
        return;
      this.ListTracksWithFuel(StringToEnum.String2Fuel((string) this.comboBoxfuel.Items[selectedIndex]));
    }

    private void SetVisibilityOnComboBoxes()
    {
      this.labelFuel.Visible = true;
      this.comboBoxfuel.Visible = true;
      this.labelTyre.Visible = true;
      this.comboBoxTyres.Visible = true;
    }

    private void menuItem1_Click(object sender, EventArgs e)
    {
      int index = int.Parse(this.listView1.Items[this.listView1.SelectedIndices[0]].SubItems[this.ID_COLUMN].Text);
      new TrackNote(index, Datas.Tracks[index].name).Show();
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();
  }
}
