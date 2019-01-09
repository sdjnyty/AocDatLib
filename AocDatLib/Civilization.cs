using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace YTY.AocDatLib
{
  public class Civilization
  {
    public byte PlayerType { get; set; }

    public byte[] Name { get; set; }

    public short TechTreeId { get; set; }

    public short TeamBonusId { get; set; }

    public List<float> Resources { get; set; }

    public byte IconSet { get; set; }

    public List<Unit> Units { get; set; }
  }
}
