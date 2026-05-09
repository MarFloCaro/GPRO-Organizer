// Decompiled with JetBrains decompiler
// Type: go.History.CarHistory
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
