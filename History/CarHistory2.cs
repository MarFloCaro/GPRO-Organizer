 
// Type: go.History.CarHistory2
 
 
 

using System;
using System.Collections;

#nullable disable
namespace go.History
{
  [Serializable]
  public class CarHistory2
  {
    public ArrayList historyList = new ArrayList();

    public CarHistory2()
    {
    }

    public CarHistory2(CarHistory oldHistory)
    {
      for (int index = 0; index < oldHistory.historyList.Count; ++index)
        this.historyList.Add((object) new CarHistoryItem2((CarHistoryItem) oldHistory.historyList[index]));
    }

    public CarHistoryItem2 GetLastItem()
    {
      int count = this.historyList.Count;
      return count > 0 ? (CarHistoryItem2) this.historyList[count - 1] : (CarHistoryItem2) null;
    }
  }
}
