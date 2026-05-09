// Decompiled with JetBrains decompiler
// Type: go.OvertakingAttempts
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class OvertakingAttempts
  {
    private int initiatedBlocked;
    private int initiatedSucceful;
    private int sufferedBlocked;
    private int sufferedSuccessful;

    public int InitiatedBlocked
    {
      get => this.initiatedBlocked;
      set => this.initiatedBlocked = value;
    }

    public int InitiatedSucceful
    {
      get => this.initiatedSucceful;
      set => this.initiatedSucceful = value;
    }

    public int SufferedBlocked
    {
      get => this.sufferedBlocked;
      set => this.sufferedBlocked = value;
    }

    public int SufferedSuccessful
    {
      get => this.sufferedSuccessful;
      set => this.sufferedSuccessful = value;
    }
  }
}
