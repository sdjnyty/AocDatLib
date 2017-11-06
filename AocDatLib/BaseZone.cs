using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class BaseZone
  {
    public int LandId { get; set; }
    public int BaseTerrain { get; set; }
    public int SpacingBetweenPlayers { get; set; }
    public int BaseSize { get; set; }
    public byte Zone { get; set; }
    public byte PlacementKind { get; set; }
    internal short _unknown1;
    public int BaseX { get; set; }
    public int BaseY { get; set; }
    public byte LandProportion { get; set; }
    public byte PlayerPlacement { get; set; }
    internal short _unknown2;
    public int StartAreaRadius { get; set; }
    public int TerrainEdgeFade { get; set; }
    public int ClumpinessFactor { get; set; }
  }
}
