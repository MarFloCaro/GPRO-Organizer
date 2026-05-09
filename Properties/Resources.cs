// Decompiled with JetBrains decompiler
// Type: Properties.Resources
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Properties.Resources.resourceMan == null)
          Properties.Resources.resourceMan = new ResourceManager("Properties.Resources", typeof (Properties.Resources).Assembly);
        return Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Properties.Resources.resourceCulture;
      set => Properties.Resources.resourceCulture = value;
    }

    internal static Icon Car
    {
      get => (Icon) Properties.Resources.ResourceManager.GetObject(nameof (Car), Properties.Resources.resourceCulture);
    }

    internal static Bitmap CarPng
    {
      get
      {
        return (Bitmap) Properties.Resources.ResourceManager.GetObject(nameof (CarPng), Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap Sourceforge
    {
      get => (Bitmap) Properties.Resources.ResourceManager.GetObject("sourceforge", Properties.Resources.resourceCulture);
    }
  }
}
