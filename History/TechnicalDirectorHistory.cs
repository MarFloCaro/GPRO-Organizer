 
// Type: go.History.TechnicalDirectorHistory
 
 
 

using System;
using System.Collections;

#nullable disable
namespace go.History
{
  [Serializable]
  public class TechnicalDirectorHistory
  {
    public ArrayList historyList = new ArrayList();

    public TechnicalDirectorHistoryItem GetLastItem()
    {
      int count = this.historyList.Count;
      return count > 0 ? (TechnicalDirectorHistoryItem) this.historyList[count - 1] : (TechnicalDirectorHistoryItem) null;
    }
  }
}
