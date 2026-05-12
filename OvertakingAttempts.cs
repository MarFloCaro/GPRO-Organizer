 
// Type: go.OvertakingAttempts
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class OvertakingAttempts
  {
    private int initiatedBlocked;
    private int initiatedSucceful;
    private int sufferedBlocked;
    private int sufferedSuccessful;

    public int InitiatedBlocked
    {
      get => this.initiatedBlocked;
      set => this.initiatedBlocked = value;
    }

    public int InitiatedSucceful
    {
      get => this.initiatedSucceful;
      set => this.initiatedSucceful = value;
    }

    public int SufferedBlocked
    {
      get => this.sufferedBlocked;
      set => this.sufferedBlocked = value;
    }

    public int SufferedSuccessful
    {
      get => this.sufferedSuccessful;
      set => this.sufferedSuccessful = value;
    }
  }
}
