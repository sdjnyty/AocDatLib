using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class Map
  {
    public int BorderSW { get; set; }
    public int BorderNW { get; set; }
    public int BorderNE { get; set; }
    public int BorderSE { get; set; }
    public int BorderUsage { get; set; }
    public int WaterShape { get; set; }
    public int NonBaseTerrain { get; set; }
    public int BaseZoneCoverage { get; set; }
    internal int _unknown1;
    public int BaseZonePtr { get; set; }
    public List<BaseZone> BaseZones { get; internal set; }
    public int MapTerrainPtr { get; set; }
    public List<MapTerrain> MapTerrains { get; internal set; }
    public int MapUnitPtr { get; set; }
    public List<MapUnit> MapUnits { get; internal set; }
    public int MapElevationPtr { get; set; }
    public List<MapElevation> MapElevations { get; internal set; }
  }
}
