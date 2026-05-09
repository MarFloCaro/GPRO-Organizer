// Decompiled with JetBrains decompiler
// Type: go.History.CarHistory2
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
