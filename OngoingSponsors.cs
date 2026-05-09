// Decompiled with JetBrains decompiler
// Type: go.OngoingSponsors
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class OngoingSponsors
  {
    public int sponsorId;
    public string name;
    public string spot;
    public double amountPerRace;
    public string contractStatus;
    public int racesLeft;

    public bool isDifferent(OngoingSponsors ongoingSponsors)
    {
      return ongoingSponsors == null || this.sponsorId != ongoingSponsors.sponsorId || !this.name.Equals(ongoingSponsors.name) || !this.spot.Equals(ongoingSponsors.spot) || this.amountPerRace != ongoingSponsors.amountPerRace || !this.contractStatus.Equals(ongoingSponsors.contractStatus) || this.racesLeft != ongoingSponsors.racesLeft;
    }
  }
}
