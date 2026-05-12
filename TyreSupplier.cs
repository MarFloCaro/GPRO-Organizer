 
// Type: go.TyreSupplier
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class TyreSupplier
  {
    public int dryPerf;
    public int wetPerf;
    public int peakTemp;
    public int durability;
    public int warmUpDistance;

    public bool isEqual(TyreSupplier supplier)
    {
      return this.dryPerf == supplier.dryPerf && this.wetPerf == supplier.wetPerf && this.peakTemp == supplier.peakTemp && this.durability == supplier.durability && this.warmUpDistance == supplier.warmUpDistance;
    }
  }
}
