 
// Type: go.SponsorState
 
 
 

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
