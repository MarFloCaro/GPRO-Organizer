 
// Type: go.OngoingSponsors
 
 
 

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
