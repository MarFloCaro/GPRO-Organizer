 
// Type: go.History.StaffHistory
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go.History
{
  [Serializable]
  public class StaffHistory
  {
    public int oldValue;
    public int newValue;
    public Date date = new Date();
    public StaffType type;

    public StaffHistory()
    {
    }

    public StaffHistory(Date date, int oldValue, int newValue, StaffType type)
    {
      this.date = date;
      this.oldValue = oldValue;
      this.newValue = newValue;
      this.type = type;
    }
  }
}
