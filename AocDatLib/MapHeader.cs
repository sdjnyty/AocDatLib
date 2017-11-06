using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class MapHeader
  {
    public int ScriptNumber { get; set; }

    public int BorderSW { get; set; }

    public int BorderNW { get; set; }

    public int BorderNE { get; set; }

    public int BorderSE { get; set; }

    public int BorderUsage { get; set; }

    public int WaterShape { get; set; }

    public int NonBaseTerrain { get; set; }

    public int BaseZoneCoverage { get; set; }

    internal int _unknown1;

    public int BaseZoneCount { get; set; }

    public int BaseZonePtr { get; set; }

    public int MapTerrainCount { get; set; }

    public int MapTerrainPtr { get; set; }

    public int MapUnitCount { get; set; }

    public int MapUnitPtr { get; set; }

    internal int _unknown2;
    internal int _unknown3;
  }
}
