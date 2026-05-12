 
// Type: go.Forms.OldRacesForm
 
 
 

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
  public class OldRacesForm : Form
  {
    private const int INDEX_SEASON = 0;
    private const int INDEX_RACE = 1;
    private const int INDEX_NAME = 2;
    private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
    private Button button1;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;

    public OldRacesForm()
    {
      this.InitializeComponent();
      this.listView1.ListViewItemSorter = (IComparer) this.lvwColumnSorter;
      foreach (Season20 season in Datas.Seasons)
      {
        if (season != null)
        {
          for (int index = 0; index < season.Events.Length; ++index)
          {
            RaceEvent20 raceEvent20 = season.Events[index];
            if (raceEvent20.isRaceUpdated)
            {
              ListViewItem listViewItem = new ListViewItem(new string[7]
              {
                season.Season.ToString(),
                (index + 1).ToString(),
                Datas.Tracks[raceEvent20.Trackid - 1].name,
                raceEvent20.Race.Laps[0].position.ToString(),
                raceEvent20.Race.Laps[raceEvent20.Race.Laps.Length - 1].position.ToString(),
                "No",
                "No"
              });
              foreach (Lap2 lap in raceEvent20.Race.Laps)
              {
                if (lap.weather.skies == Skies.Rain)
                {
                  listViewItem.SubItems[5].Text = "Yes";
                  break;
                }
              }
              if (raceEvent20.isTestingUpdated && raceEvent20.Test.runs[0] != null)
                listViewItem.SubItems[6].Text = "Yes";
              this.listView1.Items.Add(listViewItem);
            }
          }
        }
      }
      this.Show();
      if (this.listView1.Items.Count <= 0)
        return;
      this.listView1.EnsureVisible(this.listView1.Items.Count - 1);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OldRacesForm));
      this.button1 = new Button();
      this.listView1 = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.SuspendLayout();
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(337, 372);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "E&xit";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
      this.listView1.Location = new Point(8, 8);
      this.listView1.MultiSelect = false;
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(405, 356);
      this.listView1.TabIndex = 3;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = View.Details;
      this.listView1.DoubleClick += new EventHandler(this.listView1_DoubleClick);
      this.listView1.ColumnClick += new ColumnClickEventHandler(this.listView1_ColumnClick);
      this.listView1.KeyUp += new KeyEventHandler(this.listView1_KeyUp);
      this.columnHeader1.Text = "Season";
      this.columnHeader1.Width = 48;
      this.columnHeader2.Text = "Race";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 38;
      this.columnHeader3.Text = "Track";
      this.columnHeader3.Width = 83;
      this.columnHeader4.Text = "Start Pos.";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 59;
      this.columnHeader5.Text = "Result";
      this.columnHeader5.TextAlign = HorizontalAlignment.Right;
      this.columnHeader5.Width = 43;
      this.columnHeader6.Text = "Rain laps";
      this.columnHeader7.Text = "Testing";
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(421, 402);
      this.Controls.Add((Control) this.listView1);
      this.Controls.Add((Control) this.button1);
      this.Icon = Resources.Resources.Car;
      this.Name = nameof (OldRacesForm);
      this.Text = nameof (OldRacesForm);
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
      this.lvwColumnSorter.SortingManner = e.Column != 2 ? ListViewColumnSorter.CompareManner.INT32 : ListViewColumnSorter.CompareManner.TEXT;
      this.listView1.Sort();
    }

    private void listView1_DoubleClick(object sender, EventArgs e)
    {
      int index = int.Parse(this.listView1.SelectedItems[0].SubItems[1].Text) - 1;
      int num = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text);
      foreach (Season20 season20 in Datas.Seasons.ToArray())
      {
        if (season20.Season == num)
        {
          new RaceForm(season20.Events[index], Datas.Tracks[season20.Events[index].Trackid - 1]).Show();
          break;
        }
      }
    }

    private void listView1_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.listView1_DoubleClick(sender, (EventArgs) null);
    }
  }
}
