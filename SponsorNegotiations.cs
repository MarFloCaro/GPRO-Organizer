// Decompiled with JetBrains decompiler
// Type: go.SponsorNegotiations
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class SponsorNegotiations
  {
    public int sponsorId;
    public string name;
    public string spot;
    public double amountPerRace;
    public int duration;
    public double progress;
    public SponsorPriority priority;

    public bool isDifferent(SponsorNegotiations sponsorNegotiations)
    {
      return sponsorNegotiations == null || this.sponsorId != sponsorNegotiations.sponsorId || !this.name.Equals(sponsorNegotiations.name) || !this.spot.Equals(sponsorNegotiations.spot) || this.amountPerRace != sponsorNegotiations.amountPerRace || this.duration != sponsorNegotiations.duration || this.progress != sponsorNegotiations.progress || this.priority != sponsorNegotiations.priority;
    }
  }
}
