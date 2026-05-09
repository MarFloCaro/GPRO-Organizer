// Decompiled with JetBrains decompiler
// Type: go.History.TechnicalDirectorHistoryItem
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
