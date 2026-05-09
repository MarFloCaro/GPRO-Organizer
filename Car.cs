// Decompiled with JetBrains decompiler
// Type: go.Car
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Car
  {
    public int power;
    public int handling;
    public int acceleration;
    public CarPart chassis = new CarPart();
    public CarPart engine = new CarPart();
    public CarPart frontWing = new CarPart();
    public CarPart rearWing = new CarPart();
    public CarPart underbody = new CarPart();
    public CarPart sidepods = new CarPart();
    public CarPart cooling = new CarPart();
    public CarPart gearBox = new CarPart();
    public CarPart brakes = new CarPart();
    public CarPart suspension = new CarPart();
    public CarPart electronics = new CarPart();

    public bool IsEqual(Car car)
    {
      return this.power == car.power && this.handling == car.handling && this.acceleration == car.acceleration && this.chassis.IsEqual(car.chassis) && this.engine.IsEqual(car.engine) && this.frontWing.IsEqual(car.frontWing) && this.rearWing.IsEqual(car.rearWing) && this.underbody.IsEqual(car.underbody) && this.sidepods.IsEqual(car.sidepods) && this.cooling.IsEqual(car.cooling) && this.gearBox.IsEqual(car.gearBox) && this.brakes.IsEqual(car.brakes) && this.suspension.IsEqual(car.suspension) && this.electronics.IsEqual(car.electronics);
    }
  }
}
