 
// Type: go.DriverHistory
 
 
 

using System;
using System.Collections;

#nullable disable
namespace go
{
  [Serializable]
  public class DriverHistory
  {
    public ArrayList historyList = new ArrayList();

    public DriverHistoryItem GetLastItem()
    {
      int count = this.historyList.Count;
      return count > 0 ? (DriverHistoryItem) this.historyList[count - 1] : (DriverHistoryItem) null;
    }
  }
}
