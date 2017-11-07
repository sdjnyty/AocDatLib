using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class Civilization
  {
    public byte Enabled { get; set; }

    public char[] Name { get; set; }

    public short TechTreeId { get; set; }

    public short TeamBonusId { get; set; }

    public List<float> Resources { get; internal set; }

    public byte IconSet { get; set; }


  }
}
