using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class Terrain
  {
    internal const int TILEGRAPHICSCOUNT = 19;
    public const int TerrainUnitCount = 30;

    public sbyte Enabled { get; set; }

    internal sbyte Unknown1 { get; set; }

    public byte[] Name0 { get; set; }

    public byte[] Name1 { get; set; }

    public int SlpId { get; set; }

    internal int ShapePtr { get; set; }

    public int SoundId { get; set; }

    public int BlendPriority { get; set; }

    public int BlendMode { get; set; }

    public byte MapColorHi { get; set; }

    public byte MapColorMed { get; set; }

    public byte MapColorLow { get; set; }

    public byte CliffColorLeft { get; set; }

    public byte CliffColorRight { get; set; }

    public sbyte Passable { get; set; }

    public sbyte Impassable { get; set; }

    public TerrainAnimation Animation { get; } = new TerrainAnimation();

    public TerrainFrame[] TileGraphics { get; } = new TerrainFrame[TILEGRAPHICSCOUNT];

    public short TerrainToDraw { get; set; }

    public short Dimension0 { get; set; }

    public short Dimension1 { get; set; }

    public short[] Borders { get; set; }

    public short[] UnitIds { get; } = new short[TerrainUnitCount];

    public short[] UnitDensities { get; } = new short[TerrainUnitCount];

    public byte[] ReplacementFlag { get; } = new byte[TerrainUnitCount];

    public short TerrainUnitsUsedCount { get; set; }

    internal ushort Unknown3 { get; set; }
  }
}
