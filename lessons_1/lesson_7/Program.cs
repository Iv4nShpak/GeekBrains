// Decompiled with JetBrains decompiler
// Type: ConsoleApplication1.Program
// Assembly: ConsoleApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2811EDC-FB59-439B-81F0-8F01E34E2596
// Assembly location: C:\Users\lluta\Desktop\ReadIL.exe

using System;
using System.IO;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      string[] files = Directory.GetFiles(Console.ReadLine());
      for (int index = 0; index < files.Length; ++index)
      {
        Console.WriteLine(files[index]);
        File.AppendAllText("FIleName2.txt", files[index]);
        File.AppendAllText("FIleName2.txt", Environment.NewLine);
      }
      Console.ReadKey();
    }
  }
}
