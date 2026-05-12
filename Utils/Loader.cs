 
// Type: go.Utils.Loader
 
 
 

using go.History;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

#nullable disable
namespace go.Utils
{
  internal class Loader
  {
    public List<Season20> LoadSeasons(ref Stream stream, ref IFormatter formatter, int version)
    {
      Season20[] source = new Season20[0];
      switch (version)
      {
        case 7:
          Season7[] season7Array = (Season7[]) formatter.Deserialize(stream);
          source = new Season20[season7Array.Length];
          for (int index = 0; index < season7Array.Length; ++index)
            source[index] = new Season20(season7Array[index]);
          break;
        case 8:
          Season8[] season8Array = (Season8[]) formatter.Deserialize(stream);
          source = new Season20[season8Array.Length];
          for (int index = 0; index < season8Array.Length; ++index)
            source[index] = new Season20(season8Array[index]);
          break;
        case 9:
          Season9[] season9Array = (Season9[]) formatter.Deserialize(stream);
          source = new Season20[season9Array.Length];
          for (int index = 0; index < season9Array.Length; ++index)
            source[index] = new Season20(season9Array[index]);
          break;
        case 10:
          Season10[] season10Array = (Season10[]) formatter.Deserialize(stream);
          source = new Season20[season10Array.Length];
          for (int index = 0; index < season10Array.Length; ++index)
            source[index] = new Season20(season10Array[index]);
          break;
        case 11:
          Season11[] season11Array = (Season11[]) formatter.Deserialize(stream);
          source = new Season20[season11Array.Length];
          for (int index = 0; index < season11Array.Length; ++index)
            source[index] = new Season20(season11Array[index]);
          break;
        case 12:
          Season12[] season12Array = (Season12[]) formatter.Deserialize(stream);
          source = new Season20[season12Array.Length];
          for (int index = 0; index < season12Array.Length; ++index)
            source[index] = new Season20(season12Array[index]);
          break;
        case 13:
          object obj1 = formatter.Deserialize(stream);
          if (obj1 is Season13[])
          {
            Season13[] season13Array = (Season13[]) obj1;
            source = new Season20[season13Array.Length];
            for (int index = 0; index < season13Array.Length; ++index)
              source[index] = new Season20(season13Array[index]);
            break;
          }
          source = (Season20[]) obj1;
          break;
        case 14:
          Season14[] season14Array = (Season14[]) formatter.Deserialize(stream);
          source = new Season20[season14Array.Length];
          for (int index = 0; index < season14Array.Length; ++index)
            source[index] = new Season20(season14Array[index]);
          break;
        case 15:
          Season15[] season15Array = (Season15[]) formatter.Deserialize(stream);
          source = new Season20[season15Array.Length];
          for (int index = 0; index < season15Array.Length; ++index)
            source[index] = new Season20(season15Array[index]);
          break;
        case 16:
          Season16[] season16Array = (Season16[]) formatter.Deserialize(stream);
          source = new Season20[season16Array.Length];
          for (int index = 0; index < season16Array.Length; ++index)
            source[index] = new Season20(season16Array[index]);
          break;
        case 17:
          Season17[] season17Array = (Season17[]) formatter.Deserialize(stream);
          source = new Season20[season17Array.Length];
          for (int index = 0; index < season17Array.Length; ++index)
            source[index] = new Season20(season17Array[index]);
          break;
        case 18:
          object obj2 = formatter.Deserialize(stream);
          if (obj2 is Season18[])
          {
            Season18[] season18Array = obj2 as Season18[];
            source = new Season20[season18Array.Length];
            for (int index = 0; index < season18Array.Length; ++index)
              source[index] = new Season20(season18Array[index]);
            break;
          }
          break;
        case 19:
          Season19[] season19Array = (Season19[]) formatter.Deserialize(stream);
          source = new Season20[season19Array.Length];
          for (int index = 0; index < season19Array.Length; ++index)
            source[index] = new Season20(season19Array[index]);
          break;
        case 20:
          source = (Season20[]) formatter.Deserialize(stream);
          break;
        default:
          return (List<Season20>) formatter.Deserialize(stream);
      }
      return ((IEnumerable<Season20>) source).ToList<Season20>();
    }

    public Car2 LoadCar(ref Stream stream, ref IFormatter formatter, int version)
    {
      if (version == 1)
        return new Car2((Car) formatter.Deserialize(stream));
      if (version == 2)
        return (Car2) formatter.Deserialize(stream);
      throw new Exception("Unknown car version " + version.ToString());
    }

    public Driver5 LoadDriver(ref Stream stream, ref IFormatter formatter, int version)
    {
      switch (version)
      {
        case 1:
          return new Driver5((Driver) formatter.Deserialize(stream));
        case 2:
          return new Driver5((Driver2) formatter.Deserialize(stream));
        case 3:
          return new Driver5((Driver3) formatter.Deserialize(stream));
        case 4:
          return new Driver5((Driver4) formatter.Deserialize(stream));
        case 5:
          return (Driver5) formatter.Deserialize(stream);
        default:
          throw new Exception("Unknown driver version " + version.ToString());
      }
    }

    public CarHistory2 LoadCarHistory(ref Stream stream, ref IFormatter formatter, int version)
    {
      if (version == 1)
        return new CarHistory2((CarHistory) formatter.Deserialize(stream));
      if (version == 2)
        return (CarHistory2) formatter.Deserialize(stream);
      throw new Exception("Unknown carHistory version " + version.ToString());
    }

    public ArrayList LoadOldDrivers(ref Stream stream, ref IFormatter formatter, int version)
    {
      switch (version)
      {
        case 1:
          ArrayList arrayList1 = (ArrayList) formatter.Deserialize(stream);
          ArrayList arrayList2 = new ArrayList(arrayList1.Count);
          for (int index = 0; index < arrayList1.Count; ++index)
            arrayList2.Add((object) new Driver3((Driver2) arrayList1[index]));
          return arrayList2;
        case 2:
          ArrayList arrayList3 = (ArrayList) formatter.Deserialize(stream);
          ArrayList arrayList4 = new ArrayList(arrayList3.Count);
          for (int index = 0; index < arrayList3.Count; ++index)
          {
            if (arrayList3[index] is Driver3)
              arrayList4.Add((object) new Driver4((Driver3) arrayList3[index]));
            else
              arrayList4.Add(arrayList3[index]);
          }
          return arrayList4;
        case 3:
          ArrayList arrayList5 = (ArrayList) formatter.Deserialize(stream);
          ArrayList arrayList6 = new ArrayList(arrayList5.Count);
          for (int index = 0; index < arrayList5.Count; ++index)
          {
            if (arrayList5[index] is Driver4)
              arrayList6.Add((object) new Driver5((Driver4) arrayList5[index]));
            else
              arrayList6.Add(arrayList5[index]);
          }
          return arrayList6;
        default:
          return (ArrayList) formatter.Deserialize(stream);
      }
    }

    public string[] LoadTrackNotes(
      ref Stream stream,
      ref IFormatter formatter,
      int version,
      int numberOfTracks)
    {
      string[] sourceArray = (string[]) formatter.Deserialize(stream);
      if (sourceArray.Length < numberOfTracks)
      {
        string[] destinationArray = new string[numberOfTracks];
        Array.Copy((Array) sourceArray, (Array) destinationArray, sourceArray.Length);
        sourceArray = destinationArray;
      }
      return sourceArray;
    }

    public ArrayList LoadFinacialHistory(ref Stream stream, ref IFormatter formatter, int version)
    {
      return (ArrayList) formatter.Deserialize(stream);
    }

    public Staff LoadStaff(ref Stream stream, ref IFormatter formatter, int version)
    {
      return (Staff) formatter.Deserialize(stream);
    }

    public ArrayList LoadStaffHistory(ref Stream stream, ref IFormatter formatter, int version)
    {
      return (ArrayList) formatter.Deserialize(stream);
    }

    public TechnicalDirector LoadTechnicalDirector(
      ref Stream stream,
      ref IFormatter formatter,
      int version)
    {
      return (TechnicalDirector) formatter.Deserialize(stream);
    }

    public ArrayList LoadOldTechnicalDirectors(
      ref Stream stream,
      ref IFormatter formatter,
      int version)
    {
      return (ArrayList) formatter.Deserialize(stream);
    }

    public Manager LoadManager(ref Stream stream, ref IFormatter formatter, int version)
    {
      return (Manager) formatter.Deserialize(stream);
    }
  }
}
