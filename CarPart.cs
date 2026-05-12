 
// Type: go.CarPart
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class CarPart
  {
    public int level;
    public int wear;

    public bool IsEqual(CarPart part) => this.IsSameLevel(part) && this.wear == part.wear;

    public bool IsSameLevel(CarPart part) => this.level == part.level;
  }
}
