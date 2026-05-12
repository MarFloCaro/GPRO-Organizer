 
// Type: go.CarSetup
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class CarSetup
  {
    public int fWing;
    public int rWing;
    public int engine;
    public int brakes;
    public int gear;
    public int susp;
    public TyreType tyres;

    public bool IsEqual(CarSetup oldSetup)
    {
      return this.fWing == oldSetup.fWing && this.rWing == oldSetup.rWing && this.engine == oldSetup.engine && this.brakes == oldSetup.brakes && this.gear == oldSetup.gear && this.susp == oldSetup.susp && this.tyres == oldSetup.tyres;
    }
  }
}
