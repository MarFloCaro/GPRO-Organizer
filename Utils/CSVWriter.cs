 
// Type: go.Utils.CSVWriter
 
 
 

using System.IO;
using System.Windows.Forms;

#nullable disable
namespace go.Utils
{
  public class CSVWriter
  {
    private ListView view;

    public CSVWriter(ListView view) => this.view = view;

    public void save(Form owner)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = "go.csv";
      saveFileDialog.DefaultExt = "csv";
      saveFileDialog.Filter = "Comma-separated files | *.csv";
      if (DialogResult.OK != saveFileDialog.ShowDialog((IWin32Window) owner))
        return;
      StreamWriter stream = new StreamWriter((Stream) new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None));
      this.WriteToStream((TextWriter) stream);
      stream.Close();
    }

    private void WriteToStream(TextWriter stream)
    {
      for (int index = 0; index < this.view.Columns.Count; ++index)
      {
        CSVWriter.WriteItem(stream, (object) this.view.Columns[index].Text);
        if (index < this.view.Columns.Count - 1)
          stream.Write(',');
        else
          stream.WriteLine();
      }
      foreach (ListViewItem listViewItem in this.view.Items)
      {
        for (int index = 0; index < listViewItem.SubItems.Count; ++index)
        {
          CSVWriter.WriteItem(stream, (object) listViewItem.SubItems[index].Text);
          if (index < listViewItem.SubItems.Count - 1)
            stream.Write(',');
          else
            stream.WriteLine();
        }
      }
    }

    private static void WriteItem(TextWriter stream, object item)
    {
      if (item == null)
        return;
      string str = item.ToString();
      if (str.IndexOfAny("\",\n\r".ToCharArray()) > -1)
        stream.Write("\"" + str.Replace("\"", "\"\"") + "\"");
      else
        stream.Write(str);
    }
  }
}
