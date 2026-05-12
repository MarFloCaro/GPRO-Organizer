 
// Type: go.Utils.PartsWear
 
 
 

#nullable disable
namespace go.Utils
{
  internal class PartsWear
  {
    public IntPair[] wear = new IntPair[9];

    public PartsWear()
    {
      for (int index = 0; index < this.wear.Length; ++index)
        this.wear[index] = new IntPair();
    }
  }
}
