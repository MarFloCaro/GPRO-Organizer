 
// Type: go.History.TechnicalDirectorHistoryItem
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go.History
{
  [Serializable]
  public class TechnicalDirectorHistoryItem : HistoryItem
  {
    public Date date = new Date();
    public TechnicalDirectorInfo info;

    public TechnicalDirectorHistoryItem()
    {
    }

    public TechnicalDirectorHistoryItem(TechnicalDirectorHistoryItem item)
    {
      this.date = item.date;
      this.info = item.info;
      this.newValue = item.newValue;
      this.oldValue = item.newValue;
    }
  }
}
