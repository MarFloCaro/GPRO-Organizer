 
// Type: go.DriverEnergy
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class DriverEnergy
  {
    private int beforeQ1;
    private int afterQ1;
    private int beforeQ2;
    private int afterQ2;
    private int beforeRace;
    private int afterRace;

    public int BeforeQ1
    {
      get => this.beforeQ1;
      set => this.beforeQ1 = value;
    }

    public int AfterQ1
    {
      get => this.afterQ1;
      set => this.afterQ1 = value;
    }

    public int BeforeQ2
    {
      get => this.beforeQ2;
      set => this.beforeQ2 = value;
    }

    public int AfterQ2
    {
      get => this.afterQ2;
      set => this.afterQ2 = value;
    }

    public int BeforeRace
    {
      get => this.beforeRace;
      set => this.beforeRace = value;
    }

    public int AfterRace
    {
      get => this.afterRace;
      set => this.afterRace = value;
    }
  }
}
