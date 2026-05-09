// Decompiled with JetBrains decompiler
// Type: go.Date
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Date
  {
    public int season;
    public int race;

    public Date Clone()
    {
      return new Date()
      {
        season = this.season,
        race = this.race
      };
    }

    public bool IsEqual(Date date) => this.race == date.race && this.season == date.season;
  }
}
