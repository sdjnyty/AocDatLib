using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class TerrainFrame
  {
    public short FrameCount { get; set; }

    public short AngleCount { get; set; }

    public short ShapeId { get; set; }

    internal void BinaryReaderRead(System.IO.BinaryReader br)
    {
      FrameCount = br.ReadInt16();
      AngleCount = br.ReadInt16();
      ShapeId = br.ReadInt16();
    }
  }
}
