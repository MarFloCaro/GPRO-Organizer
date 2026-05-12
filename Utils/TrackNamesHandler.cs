 
// Type: go.Utils.TrackNamesHandler
 
 
 

using System.Collections;

#nullable disable
namespace go.Utils
{
  public class TrackNamesHandler
  {
    private ArrayList names = new ArrayList();

    public void InsertTrackname(string name)
    {
      for (int index = 0; index < this.names.Count; ++index)
      {
        if (name == (string) this.names[index])
          return;
        if (name.CompareTo((string) this.names[index]) < 0)
        {
          this.names.Insert(index, (object) name);
          return;
        }
      }
      this.names.Add((object) name);
    }

    public ArrayList GetContents() => this.names;
  }
}
