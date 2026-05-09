// Decompiled with JetBrains decompiler
// Type: go.DriverHistoryItem2
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using go.History;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class DriverHistoryItem2 : HistoryItem
  {
    public Date date = new Date();
    public DriverInfo driverinfo;

    public DriverHistoryItem2()
    {
    }

    public DriverHistoryItem2(DriverHistoryItem item)
    {
      this.date = item.date;
      this.driverinfo = item.driverinfo;
      this.newValue = item.newValue;
      this.oldValue = item.newValue;
    }
  }
}
