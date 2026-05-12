 
// Type: go.DriverHistoryItem2
 
 
 

using go.Enums;
using go.History;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class DriverHistoryItem2 : HistoryItem
  {
    public Date date = new Date();
    public DriverInfo driverinfo;

    public DriverHistoryItem2()
    {
    }

    public DriverHistoryItem2(DriverHistoryItem item)
    {
      this.date = item.date;
      this.driverinfo = item.driverinfo;
      this.newValue = item.newValue;
      this.oldValue = item.newValue;
    }
  }
}
