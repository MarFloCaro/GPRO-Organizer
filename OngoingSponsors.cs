 
// Type: go.OngoingSponsors
 
 
 

using System;
using System.Runtime.Serialization;

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

    [OptionalField]
    public double sponsorSatisfaction;

    public bool isDifferent(OngoingSponsors ongoingSponsors)
    {
      return ongoingSponsors == null
          || this.sponsorId != ongoingSponsors.sponsorId
          || !this.name.Equals(ongoingSponsors.name)
          || !this.spot.Equals(ongoingSponsors.spot)
          || this.amountPerRace != ongoingSponsors.amountPerRace
          || !this.contractStatus.Equals(ongoingSponsors.contractStatus)
          || this.racesLeft != ongoingSponsors.racesLeft
          || this.sponsorSatisfaction != ongoingSponsors.sponsorSatisfaction;
    }
  }
}
