using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class MapTerrain
  {
    public int Proportion { get; set; }
    public int Terrain { get; set; }
    public int ClumpCount { get; set; }
    public int SpacingToOtherTerrains { get; set; }
    public int PlacementZone { get; set; }
    public int ClumpinessFactor { get; set; }
  }
}
