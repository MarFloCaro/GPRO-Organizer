 
// Type: go.Lap
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  public class Lap
  {
    public Weather weather = new Weather();
    public TimeSpan lapTime;
    public int position;
    public int lapNumber;
    public TyreType tyres;
    public string events;
  }
}
