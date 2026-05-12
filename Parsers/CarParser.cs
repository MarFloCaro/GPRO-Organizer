 
// Type: go.Parsers.CarParser
 
 
 

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  public class CarParser : GenericParser
  {
    public static Car2 GetCar() => CarParser.GetCar(Datas.Communications.GetPage("UpdateCar.asp"));

    public static Car2 GetCar(string carPage)
    {
      try
      {
        Car2 car = new Car2();
        int startIndex1 = carPage.IndexOf("Current car character");
        int startIndex2 = carPage.IndexOf("<td", startIndex1);
        int startIndex3 = carPage.IndexOf(">", startIndex2) + 1;
        car.power = int.Parse(carPage.Substring(startIndex3, carPage.IndexOf("<", startIndex3) - startIndex3));
        int startIndex4 = carPage.IndexOf("<td", startIndex3);
        int startIndex5 = carPage.IndexOf(">", startIndex4) + 1;
        car.handling = int.Parse(carPage.Substring(startIndex5, carPage.IndexOf("<", startIndex5) - startIndex5));
        int startIndex6 = carPage.IndexOf("<td", startIndex5);
        int startIndex7 = carPage.IndexOf(">", startIndex6) + 1;
        car.acceleration = int.Parse(carPage.Substring(startIndex7, carPage.IndexOf("<", startIndex7) - startIndex7));
        int startIndex8 = carPage.IndexOf("<b>Chassis", startIndex7);
        int startIndex9 = carPage.IndexOf("center", startIndex8) + 8;
        car.chassis.level = int.Parse(carPage.Substring(startIndex9, carPage.IndexOf("<", startIndex9) - startIndex9));
        int startIndex10 = carPage.IndexOf("center", startIndex9) + 8;
        if (carPage.Substring(startIndex10, 10).StartsWith("<font"))
          startIndex10 = carPage.IndexOf(">", startIndex10) + 1;
        car.chassis.wear = int.Parse(carPage.Substring(startIndex10, carPage.IndexOf("<", startIndex10) - startIndex10 - 1));
        int startIndex11 = carPage.IndexOf("<b>Engine", startIndex10);
        int startIndex12 = carPage.IndexOf("center", startIndex11) + 8;
        car.engine.level = int.Parse(carPage.Substring(startIndex12, carPage.IndexOf("<", startIndex12) - startIndex12));
        int startIndex13 = carPage.IndexOf("center", startIndex12) + 8;
        if (carPage.Substring(startIndex13, 10).StartsWith("<font"))
          startIndex13 = carPage.IndexOf(">", startIndex13) + 1;
        car.engine.wear = int.Parse(carPage.Substring(startIndex13, carPage.IndexOf("<", startIndex13) - startIndex13 - 1));
        int startIndex14 = carPage.IndexOf("<b>Front wing", startIndex13);
        int startIndex15 = carPage.IndexOf("center", startIndex14) + 8;
        car.frontWing.level = int.Parse(carPage.Substring(startIndex15, carPage.IndexOf("<", startIndex15) - startIndex15));
        int startIndex16 = carPage.IndexOf("center", startIndex15) + 8;
        if (carPage.Substring(startIndex16, 10).StartsWith("<font"))
          startIndex16 = carPage.IndexOf(">", startIndex16) + 1;
        car.frontWing.wear = int.Parse(carPage.Substring(startIndex16, carPage.IndexOf("<", startIndex16) - startIndex16 - 1));
        int startIndex17 = carPage.IndexOf("<b>Rear wing", startIndex16);
        int startIndex18 = carPage.IndexOf("center", startIndex17) + 8;
        car.rearWing.level = int.Parse(carPage.Substring(startIndex18, carPage.IndexOf("<", startIndex18) - startIndex18));
        int startIndex19 = carPage.IndexOf("center", startIndex18) + 8;
        if (carPage.Substring(startIndex19, 10).StartsWith("<font"))
          startIndex19 = carPage.IndexOf(">", startIndex19) + 1;
        car.rearWing.wear = int.Parse(carPage.Substring(startIndex19, carPage.IndexOf("<", startIndex19) - startIndex19 - 1));
        int startIndex20 = carPage.IndexOf("<b>Underbody", startIndex19);
        int startIndex21 = carPage.IndexOf("center", startIndex20) + 8;
        car.underbody.level = int.Parse(carPage.Substring(startIndex21, carPage.IndexOf("<", startIndex21) - startIndex21));
        int startIndex22 = carPage.IndexOf("center", startIndex21) + 8;
        if (carPage.Substring(startIndex22, 10).StartsWith("<font"))
          startIndex22 = carPage.IndexOf(">", startIndex22) + 1;
        car.underbody.wear = int.Parse(carPage.Substring(startIndex22, carPage.IndexOf("<", startIndex22) - startIndex22 - 1));
        int startIndex23 = carPage.IndexOf("<b>Sidepods", startIndex22);
        int startIndex24 = carPage.IndexOf("center", startIndex23) + 8;
        car.sidepods.level = int.Parse(carPage.Substring(startIndex24, carPage.IndexOf("<", startIndex24) - startIndex24));
        int startIndex25 = carPage.IndexOf("center", startIndex24) + 8;
        if (carPage.Substring(startIndex25, 10).StartsWith("<font"))
          startIndex25 = carPage.IndexOf(">", startIndex25) + 1;
        car.sidepods.wear = int.Parse(carPage.Substring(startIndex25, carPage.IndexOf("<", startIndex25) - startIndex25 - 1));
        int startIndex26 = carPage.IndexOf("<b>Cooling", startIndex25);
        int startIndex27 = carPage.IndexOf("center", startIndex26) + 8;
        car.cooling.level = int.Parse(carPage.Substring(startIndex27, carPage.IndexOf("<", startIndex27) - startIndex27));
        int startIndex28 = carPage.IndexOf("center", startIndex27) + 8;
        if (carPage.Substring(startIndex28, 10).StartsWith("<font"))
          startIndex28 = carPage.IndexOf(">", startIndex28) + 1;
        car.cooling.wear = int.Parse(carPage.Substring(startIndex28, carPage.IndexOf("<", startIndex28) - startIndex28 - 1));
        int startIndex29 = carPage.IndexOf("<b>Gearbox", startIndex28);
        int startIndex30 = carPage.IndexOf("center", startIndex29) + 8;
        car.gearBox.level = int.Parse(carPage.Substring(startIndex30, carPage.IndexOf("<", startIndex30) - startIndex30));
        int startIndex31 = carPage.IndexOf("center", startIndex30) + 8;
        if (carPage.Substring(startIndex31, 10).StartsWith("<font"))
          startIndex31 = carPage.IndexOf(">", startIndex31) + 1;
        car.gearBox.wear = int.Parse(carPage.Substring(startIndex31, carPage.IndexOf("<", startIndex31) - startIndex31 - 1));
        int startIndex32 = carPage.IndexOf("<b>Brakes", startIndex31);
        int startIndex33 = carPage.IndexOf("center", startIndex32) + 8;
        car.brakes.level = int.Parse(carPage.Substring(startIndex33, carPage.IndexOf("<", startIndex33) - startIndex33));
        int startIndex34 = carPage.IndexOf("center", startIndex33) + 8;
        if (carPage.Substring(startIndex34, 10).StartsWith("<font"))
          startIndex34 = carPage.IndexOf(">", startIndex34) + 1;
        car.brakes.wear = int.Parse(carPage.Substring(startIndex34, carPage.IndexOf("<", startIndex34) - startIndex34 - 1));
        int startIndex35 = carPage.IndexOf("<b>Suspension", startIndex34);
        int startIndex36 = carPage.IndexOf("center", startIndex35) + 8;
        car.suspension.level = int.Parse(carPage.Substring(startIndex36, carPage.IndexOf("<", startIndex36) - startIndex36));
        int startIndex37 = carPage.IndexOf("center", startIndex36) + 8;
        if (carPage.Substring(startIndex37, 10).StartsWith("<font"))
          startIndex37 = carPage.IndexOf(">", startIndex37) + 1;
        car.suspension.wear = int.Parse(carPage.Substring(startIndex37, carPage.IndexOf("<", startIndex37) - startIndex37 - 1));
        int startIndex38 = carPage.IndexOf("<b>Electronics", startIndex37);
        int startIndex39 = carPage.IndexOf("center", startIndex38) + 8;
        car.electronics.level = int.Parse(carPage.Substring(startIndex39, carPage.IndexOf("<", startIndex39) - startIndex39));
        int startIndex40 = carPage.IndexOf("center", startIndex39) + 8;
        if (carPage.Substring(startIndex40, 10).StartsWith("<font"))
          startIndex40 = carPage.IndexOf(">", startIndex40) + 1;
        car.electronics.wear = int.Parse(carPage.Substring(startIndex40, carPage.IndexOf("<", startIndex40) - startIndex40 - 1));
        return car;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing car", ex, carPage);
        return new Car2();
      }
    }
  }
}
