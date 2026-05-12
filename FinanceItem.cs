 
// Type: go.FinanceItem
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class FinanceItem
  {
    private DateTime date = DateTime.MinValue;
    private string description = "";
    private int balanceBefore;
    private int balanceAfter;
    private int amount;
    private int detail;
    private bool isPlusAmount;
    private FinanceItemType itemType;

    public DateTime Date
    {
      get => this.date;
      set => this.date = value;
    }

    public string Description
    {
      get => this.description;
      set => this.description = value;
    }

    public int BalanceBefore
    {
      get => this.balanceBefore;
      set => this.balanceBefore = value;
    }

    public int BalanceAfter
    {
      get => this.balanceAfter;
      set => this.balanceAfter = value;
    }

    public int Amount
    {
      get => this.amount;
      set => this.amount = value;
    }

    public int Detail
    {
      get => this.detail;
      set => this.detail = value;
    }

    public bool IsPlusAmount
    {
      get => this.isPlusAmount;
      set => this.isPlusAmount = value;
    }

    public FinanceItemType ItemType
    {
      get => this.itemType;
      set => this.itemType = value;
    }
  }
}
