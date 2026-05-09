// Decompiled with JetBrains decompiler
// Type: go.Utils.PartsWear
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

#nullable disable
namespace go.Utils
{
  internal class PartsWear
  {
    public IntPair[] wear = new IntPair[9];

    public PartsWear()
    {
      for (int index = 0; index < this.wear.Length; ++index)
        this.wear[index] = new IntPair();
    }
  }
}
