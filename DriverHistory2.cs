 
// Type: go.DriverHistory2
 
 
 

using System;
using System.Collections;

#nullable disable
namespace go
{
  [Serializable]
  public class DriverHistory2
  {
    public ArrayList historyList = new ArrayList();

    public DriverHistory2()
    {
    }

    public DriverHistory2(DriverHistory history)
    {
      for (int index = 0; index < history.historyList.Count; ++index)
        this.historyList.Add((object) new DriverHistoryItem2((DriverHistoryItem) history.historyList[index]));
    }

    public DriverHistoryItem2 GetLastItem()
    {
      int count = this.historyList.Count;
      return count > 0 ? (DriverHistoryItem2) this.historyList[count - 1] : (DriverHistoryItem2) null;
    }
  }
}
