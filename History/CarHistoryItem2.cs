 
// Type: go.History.CarHistoryItem2
 
 
 

using System;

#nullable disable
namespace go.History
{
  [Serializable]
  public class CarHistoryItem2
  {
    public Date date = new Date();
    public Car2 car = new Car2();

    public CarHistoryItem2()
    {
    }

    public CarHistoryItem2(CarHistoryItem oldItem)
    {
      this.date = oldItem.date;
      this.car = new Car2(oldItem.car);
    }
  }
}
