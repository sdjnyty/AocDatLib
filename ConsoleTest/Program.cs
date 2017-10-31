using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public static class Program
  {
    const string DATFILE = @"C:\Program Files (x86)\Age of Empires II\DATA\empires2.dat";
    //const string DATFILE = @"D:\Hawkaoc\aoc\Data\empires2.dat";

    public static void Main(string[] args)
    {
      var dat = new DatFile(DATFILE);
      Console.ReadKey();
    }
  }
}
