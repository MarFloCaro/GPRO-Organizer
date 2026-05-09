// Decompiled with JetBrains decompiler
// Type: go.SponsorState
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class SponsorState
  {
    public OngoingSponsors[] ongoing = new OngoingSponsors[5];
    public SponsorNegotiations[] negotiations = new SponsorNegotiations[11];

    public bool isDifferent(SponsorState oldSponsor)
    {
      for (int index = 0; index < this.ongoing.Length; ++index)
      {
        if ((this.ongoing[index] != null || oldSponsor.ongoing[index] != null) && (this.ongoing[index] == null && oldSponsor.ongoing[index] != null || this.ongoing[index].isDifferent(oldSponsor.ongoing[index])))
          return true;
      }
      for (int index = 0; index < this.negotiations.Length; ++index)
      {
        if ((this.negotiations[index] != null || oldSponsor.negotiations[index] != null) && (this.negotiations[index] == null && oldSponsor.negotiations[index] != null || this.negotiations[index].isDifferent(oldSponsor.negotiations[index])))
          return true;
      }
      return false;
    }
  }
}
