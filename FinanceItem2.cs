// Decompiled with JetBrains decompiler
// Type: go.FinanceItem2
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using go.Utils;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class FinanceItem2
  {
    private DateTime date = DateTime.MinValue;
    private string description = "";
    private int balanceBefore;
    private int balanceAfter;
    private int amount;
    private int detail;

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

    public FinanceItemType ItemType
    {
      get => String2Enum.GetFinanceItemType(this);
      set => this.ItemType = value;
    }

    public static explicit operator FinanceItem2(FinanceItem financeItem)
    {
      if (financeItem == null)
        throw new ArgumentNullException(nameof (financeItem), "null");
      return new FinanceItem2()
      {
        date = financeItem.Date,
        description = financeItem.Description,
        balanceBefore = financeItem.BalanceBefore,
        balanceAfter = financeItem.BalanceAfter,
        amount = financeItem.Amount,
        detail = financeItem.Detail
      };
    }
  }
}
