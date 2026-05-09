// Decompiled with JetBrains decompiler
// Type: go.History.StaffHistory
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go.History
{
  [Serializable]
  public class StaffHistory
  {
    public int oldValue;
    public int newValue;
    public Date date = new Date();
    public StaffType type;

    public StaffHistory()
    {
    }

    public StaffHistory(Date date, int oldValue, int newValue, StaffType type)
    {
      this.date = date;
      this.oldValue = oldValue;
      this.newValue = newValue;
      this.type = type;
    }
  }
}
