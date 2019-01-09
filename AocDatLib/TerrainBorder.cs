using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class TerrainBorder
  {
    public sbyte IsEnabled { get; set; }

    internal sbyte Unknown1 { get; set; }

    public byte[] Name0 { get; set; }

    public byte[] Name1 { get; set; }

    public int SlpId { get; set; }

    internal int Unknown2 { get; set; }

    public int SoundId { get; set; }

    public int ColorHi { get; set; }

    public int ColorMed { get; set; }

    public int ColorLow { get; set; }

    public TerrainAnimation Animation { get; } = new TerrainAnimation();

    public TerrainFrame[] Frames { get; } = new TerrainFrame[Terrain.TILEGRAPHICSCOUNT * 12];

    public short DrawTile { get; set; }

    public short UnderlayTerrain { get; set; }

    public short BorderStyle { get; set; }
  }
}
