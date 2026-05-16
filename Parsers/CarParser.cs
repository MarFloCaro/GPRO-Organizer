 
// Type: go.Parsers.CarParser
 
 
 

using go.Utils;
using System;
using System.Text.RegularExpressions;

#nullable disable
namespace go.Parsers
{
  public class CarParser : GenericParser
  {
    private static void ParsePart(
        string carPage,
        string partName,
        CarPart part
    )
    {   
        int partIndex =
          carPage.IndexOf("<td><b>" + partName);
    
        if (partIndex < 0)
        {
            throw new Exception(
                "Could not locate part section: " + partName
            );
        }
    
        string section =
            carPage.Substring(
                partIndex,
                Math.Min(2500, carPage.Length - partIndex)
            );
    
        MatchCollection tdMatches =
            Regex.Matches(
                section,
                @"<td align=""center"">\s*(.*?)\s*</td>"
            );
    
        if (tdMatches.Count < 2)
        {
            throw new Exception(
                "Not enough td matches for " + partName
            );
        }
    
        string levelText =
            tdMatches[0].Groups[1].Value;
    
        string wearText =
            tdMatches[1].Groups[1].Value;
    
        levelText =
            Regex.Replace(levelText, @"[^\d]", "");
    
        wearText =
            Regex.Replace(wearText, @"[^\d]", "");
    
        part.level = int.Parse(levelText);
        part.wear = int.Parse(wearText);
    
    }
    public static Car2 GetCar() => CarParser.GetCar(Datas.Communications.GetPage("UpdateCar.asp"));

    public static Car2 GetCar(string carPage)
    {
      try
      {
        Car2 car = new Car2();

        // --------------------------------------------------
        // CURRENT CAR CHARACTER
        // --------------------------------------------------

        int characterIndex =
            carPage.IndexOf("Current car character");

        if (characterIndex < 0)
        {
            throw new Exception(
                "Could not locate 'Current car character' section."
            );
        }

        string characterSection =
            carPage.Substring(
                characterIndex,
                Math.Min(2000, carPage.Length - characterIndex)
            );

        MatchCollection characterMatches =
            Regex.Matches(
                characterSection,
                @"<td[^>]*align=""center""[^>]*>\s*(\d+)\s*</td>"
            );

        if (characterMatches.Count < 3)
        {
            throw new Exception(
                "Could not parse car character values."
            );
        }

        car.power =
            int.Parse(characterMatches[0].Groups[1].Value);

        car.handling =
            int.Parse(characterMatches[1].Groups[1].Value);

        car.acceleration =
            int.Parse(characterMatches[2].Groups[1].Value);


        // --------------------------------------------------
        // PARTS
        // --------------------------------------------------

        ParsePart(carPage, "Chassis", car.chassis);
        ParsePart(carPage, "Engine", car.engine);
        ParsePart(carPage, "Front wing", car.frontWing);
        ParsePart(carPage, "Rear wing", car.rearWing);
        ParsePart(carPage, "Underbody", car.underbody);
        ParsePart(carPage, "Sidepods", car.sidepods);
        ParsePart(carPage, "Cooling", car.cooling);
        ParsePart(carPage, "Gearbox", car.gearBox);
        ParsePart(carPage, "Brakes", car.brakes);
        ParsePart(carPage, "Suspension", car.suspension);
        ParsePart(carPage, "Electronics", car.electronics);

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
