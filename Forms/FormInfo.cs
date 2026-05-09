// Decompiled with JetBrains decompiler
// Type: go.Forms.FormInfo
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;
using System.Collections;

#nullable disable
namespace go.Forms
{
  [Serializable]
  public class FormInfo
  {
    public ArrayList columnInfo = new ArrayList();
    public ArrayList columnWidths = new ArrayList();
    public int formWidth;
    public int formHeight;
  }
}
