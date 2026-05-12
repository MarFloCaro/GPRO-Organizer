 
// Type: go.SponsorNegotiations
 
 
 

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
