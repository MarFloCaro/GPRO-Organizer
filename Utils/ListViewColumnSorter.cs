// Decompiled with JetBrains decompiler
// Type: go.Utils.ListViewColumnSorter
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System.Collections;
using System.Windows.Forms;

#nullable disable
namespace go.Utils
{
  public class ListViewColumnSorter : IComparer
  {
    private int ColumnToSort;
    private SortOrder OrderOfSort;
    private CaseInsensitiveComparer ObjectCompare;
    private ListViewColumnSorter.CompareManner compareManner;

    public int SortColumn
    {
      get => this.ColumnToSort;
      set => this.ColumnToSort = value;
    }

    public SortOrder Order
    {
      get => this.OrderOfSort;
      set => this.OrderOfSort = value;
    }

    public ListViewColumnSorter.CompareManner SortingManner
    {
      get => this.compareManner;
      set => this.compareManner = value;
    }

    public ListViewColumnSorter()
    {
      this.ColumnToSort = 0;
      this.OrderOfSort = SortOrder.None;
      this.ObjectCompare = new CaseInsensitiveComparer();
      this.compareManner = ListViewColumnSorter.CompareManner.TEXT;
    }

    public int Compare(object x, object y)
    {
      ListViewItem listViewItem1 = (ListViewItem) x;
      ListViewItem listViewItem2 = (ListViewItem) y;
      int num1;
      try
      {
        int num2;
        switch (this.compareManner)
        {
          case ListViewColumnSorter.CompareManner.INT32:
            num2 = this.ObjectCompare.Compare((object) int.Parse(listViewItem1.SubItems[this.ColumnToSort].Text), (object) int.Parse(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.Double:
            num2 = this.ObjectCompare.Compare((object) double.Parse(listViewItem1.SubItems[this.ColumnToSort].Text), (object) double.Parse(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.TYRETYPE:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2Tyres(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2Tyres(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.TYREWEAR:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2TyreWear(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2TyreWear(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.DOWNFORCE:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2Fuel(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2Fuel(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.OVERTAKING:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2Overtaking(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2Overtaking(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.SUSPENSION:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2Suspension(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2Suspension(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.FUEL_CONSUMPTION:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2Fuel(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2Fuel(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.TIMESPAN:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2Time(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2Time(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          case ListViewColumnSorter.CompareManner.GRIP:
            num2 = this.ObjectCompare.Compare((object) StringToEnum.String2Grip(listViewItem1.SubItems[this.ColumnToSort].Text), (object) StringToEnum.String2Grip(listViewItem2.SubItems[this.ColumnToSort].Text));
            break;
          default:
            num2 = this.ObjectCompare.Compare((object) listViewItem1.SubItems[this.ColumnToSort].Text, (object) listViewItem2.SubItems[this.ColumnToSort].Text);
            break;
        }
        num1 = num2;
      }
      catch
      {
        num1 = this.ObjectCompare.Compare((object) listViewItem1.SubItems[this.ColumnToSort].Text, (object) listViewItem2.SubItems[this.ColumnToSort].Text);
      }
      if (this.OrderOfSort == SortOrder.Ascending)
        return num1;
      return this.OrderOfSort == SortOrder.Descending ? -num1 : 0;
    }

    public enum CompareManner
    {
      TEXT,
      INT32,
      Double,
      TYRETYPE,
      TYREWEAR,
      DOWNFORCE,
      OVERTAKING,
      SUSPENSION,
      FUEL_CONSUMPTION,
      TIMESPAN,
      GRIP,
    }
  }
}
