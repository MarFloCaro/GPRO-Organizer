 
// Type: go.FinancialAnalysis2
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class FinancialAnalysis2
  {
    public int endPosition;
    public int endPositionMoney;
    public int qualPosition;
    public int qualPositionMoney;
    public int sponsorMoney;
    public int driverSalary;
    public int staffSalary;
    public int facilityCost;
    public int total;
    public int currentBalance;
    public int tyresContractCost;

    public FinancialAnalysis2()
    {
    }

    public FinancialAnalysis2(FinancialAnalysis analysis)
    {
      this.endPosition = analysis.endPosition;
      this.endPositionMoney = analysis.endPositionMoney;
      this.qualPosition = analysis.qualPosition;
      this.qualPositionMoney = analysis.qualPositionMoney;
      this.sponsorMoney = analysis.sponsorMoney;
      this.driverSalary = analysis.driverSalary;
      this.staffSalary = analysis.staffSalary;
      this.facilityCost = analysis.facilityCost;
      this.total = analysis.total;
      this.currentBalance = analysis.currentBalance;
    }
  }
}
