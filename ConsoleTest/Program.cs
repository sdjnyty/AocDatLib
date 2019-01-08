using System;
using System.IO;
using Microsoft.Win32;

namespace YTY.AocDatLib
{
  public static class Program
  {

    public static void Main(string[] args)
    {
     var path=(string)Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft Games\Age of Empires II: The Conquerors Expansion\1.0").GetValue("EXE Path");
      path = Path.Combine(path, @"data\empires2_x1_p1.dat");
      var dat = new DatFile(path);
      Console.ReadKey();
    }
  }
}
