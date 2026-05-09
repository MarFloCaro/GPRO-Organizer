// Decompiled with JetBrains decompiler
// Type: go.Season
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season
  {
    public int season;
    public RaceEvent[] events = new RaceEvent[17];

    public Season()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent();
    }
  }
}
