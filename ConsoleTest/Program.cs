using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public static class Program
  {
    const string DATFILE = @"D:\Hawkaoe\aoc\Data\empires2_x1_p1.dat";

    public static void Main(string[] args)
    {
      var dat = new DatFile(DATFILE);
      Console.ReadKey();
    }
  }
}
