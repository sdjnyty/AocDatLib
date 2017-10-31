using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class PlayerColor
  {
    public int Id { get; set; }

    public int BaseColorId { get; set; }

    public int OutlineColorId { get; set; }

    internal int Unknown1 { get; set; }

    internal int Unknown2 { get; set; }

    public int MinimapColorId { get; set; }

    internal int Unknown3 { get; set; }

    internal int Unknown4 { get; set; }

    public int StatisticsColorId { get; set; }
  }
}
