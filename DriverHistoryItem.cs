 
// Type: go.DriverHistoryItem
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class DriverHistoryItem
  {
    public Date date = new Date();
    public DriverInfo driverinfo;
    public double newValue;
  }
}
