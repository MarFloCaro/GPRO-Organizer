 
// Type: go.History.CarHistory
 
 
 

using System;
using System.Collections;

#nullable disable
namespace go.History
{
  [Serializable]
  public class CarHistory
  {
    public ArrayList historyList = new ArrayList();

    public CarHistoryItem GetLastItem()
    {
      int count = this.historyList.Count;
      return count > 0 ? (CarHistoryItem) this.historyList[count - 1] : (CarHistoryItem) null;
    }
  }
}
