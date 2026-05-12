 
// Type: go.Car2
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Car2
  {
    public int power;
    public int handling;
    public int acceleration;
    public double testPower;
    public double testHandling;
    public double testAcceleration;
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

    public Car2()
    {
    }

    public Car2(Car oldCar)
    {
      this.power = oldCar.power;
      this.handling = oldCar.handling;
      this.acceleration = oldCar.acceleration;
      this.chassis = oldCar.chassis;
      this.engine = oldCar.engine;
      this.frontWing = oldCar.frontWing;
      this.rearWing = oldCar.rearWing;
      this.underbody = oldCar.underbody;
      this.sidepods = oldCar.sidepods;
      this.cooling = oldCar.cooling;
      this.gearBox = oldCar.gearBox;
      this.brakes = oldCar.brakes;
      this.suspension = oldCar.suspension;
      this.electronics = oldCar.electronics;
    }

    public void CopyLevels(Car2 from)
    {
      this.chassis.level = from.chassis.level;
      this.engine.level = from.engine.level;
      this.frontWing.level = from.frontWing.level;
      this.rearWing.level = from.rearWing.level;
      this.underbody.level = from.underbody.level;
      this.sidepods.level = from.sidepods.level;
      this.cooling.level = from.cooling.level;
      this.gearBox.level = from.gearBox.level;
      this.brakes.level = from.brakes.level;
      this.suspension.level = from.suspension.level;
      this.electronics.level = from.electronics.level;
    }

    public bool IsEqual(Car2 car)
    {
      return this.power == car.power && this.handling == car.handling && this.acceleration == car.acceleration && this.chassis.IsEqual(car.chassis) && this.engine.IsEqual(car.engine) && this.frontWing.IsEqual(car.frontWing) && this.rearWing.IsEqual(car.rearWing) && this.underbody.IsEqual(car.underbody) && this.sidepods.IsEqual(car.sidepods) && this.cooling.IsEqual(car.cooling) && this.gearBox.IsEqual(car.gearBox) && this.brakes.IsEqual(car.brakes) && this.suspension.IsEqual(car.suspension) && this.electronics.IsEqual(car.electronics);
    }

    public bool IsSameLevelsAndPHA(Car2 car)
    {
      return this.power == car.power && this.handling == car.handling && this.acceleration == car.acceleration && this.chassis.IsSameLevel(car.chassis) && this.engine.IsSameLevel(car.engine) && this.frontWing.IsSameLevel(car.frontWing) && this.rearWing.IsSameLevel(car.rearWing) && this.underbody.IsSameLevel(car.underbody) && this.sidepods.IsSameLevel(car.sidepods) && this.cooling.IsSameLevel(car.cooling) && this.gearBox.IsSameLevel(car.gearBox) && this.brakes.IsSameLevel(car.brakes) && this.suspension.IsSameLevel(car.suspension) && this.electronics.IsSameLevel(car.electronics);
    }

    public bool UpdateTestPoints(Testing test)
    {
      if (this.testPower == test.points[3].power && this.testHandling == test.points[3].handling && this.testAcceleration == test.points[3].acceleration)
        return false;
      this.testPower = test.points[3].power;
      this.testHandling = test.points[3].handling;
      this.testAcceleration = test.points[3].acceleration;
      return true;
    }
  }
}
