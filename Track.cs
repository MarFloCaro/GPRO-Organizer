 
// Type: go.Track
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Track
  {
    public string name = "";
    public int number;
    public double distance;
    public int laps;
    public double lapDistance;
    public double averageSpeed;
    public int numberOfCorners;
    public double timeInPits;
    public int power;
    public int handling;
    public int acceleration;
    public Downforce downforce = Downforce.Medium;
    public Overtaking overtaking = Overtaking.Normal;
    public SupensionRigidity suspensionRigidity = SupensionRigidity.Medium;
    public FuelConsumption fuelConsumption = FuelConsumption.Medium;
    public TyreWear tyreWear = TyreWear.Medium;
    public Category category;
    public Grip grip;
  }
}
