// Decompiled with JetBrains decompiler
// Type: go.Utils.Sourceforge.Release
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System.Collections.Generic;

#nullable disable
namespace go.Utils.Sourceforge
{
  public class Release
  {
    public object sf_release_id { get; set; }

    public string file_type { get; set; }

    public string vscan { get; set; }

    public int sf_file_id { get; set; }

    public string date { get; set; }

    public List<object> sf_platform { get; set; }

    public object sf_package_id { get; set; }

    public string date_modified { get; set; }

    public object sf_download_label { get; set; }

    public string md5sum { get; set; }

    public int bytes { get; set; }

    public object release_notes_url { get; set; }

    public string filename { get; set; }

    public string url { get; set; }

    public List<string> sf_platform_default { get; set; }

    public string mime_type { get; set; }

    public object sf_type { get; set; }

    public string vscan_when { get; set; }

    public object sf_release_notes_file { get; set; }
  }
}
