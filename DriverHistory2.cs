// Decompiled with JetBrains decompiler
// Type: go.DriverHistory2
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
