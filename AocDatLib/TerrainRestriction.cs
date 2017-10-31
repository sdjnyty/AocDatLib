using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class TerrainRestriction
  {
    public List<float> AccessibleDamageMultiplier { get; internal set; }

    public List<TerrainPassGraphic> PassGraphics { get; internal set; }
  }
}
