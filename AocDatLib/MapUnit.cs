using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class MapUnit
  {
    public int Unit { get; set; }
    public int HostTerrain { get; set; }
    public byte GroupMode { get; set; }
    public byte ScaleByMapSize { get; set; }
    internal short _unknown1;
    public int ObjectsPerGroup { get; set; }
    public int Fluctuation { get; set; }
    public int GroupsPerPlayer { get; set; }
    public int GroupRadius { get; set; }
    public int PlayerNumber { get; set; }
    public int BaseLandNumber { get; set; }
    public int MinDistanceToPlayers { get; set; }
    public int MaxDistanceToPlayers { get; set; }
  }
}
