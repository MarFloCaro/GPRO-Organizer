// Decompiled with JetBrains decompiler
// Type: go.History.TechnicalDirectorHistory
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
