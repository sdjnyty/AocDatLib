using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class TerrainAnimation
  {
    public sbyte IsAnimated { get; set; }

    public short AnimationFrameCount { get; set; }

    public short PauseFrameCount { get; set; }

    public float Interval { get; set; }

    public float PauseAfterLoop { get; set; }

    public short Frame { get; set; }

    public short DrawFrame { get; set; }

    public float AnimateLast { get; set; }

    public sbyte HasFrameChanged { get; set; }

    public sbyte Drawn { get; set; }

    internal void BinaryReaderRead(System.IO.BinaryReader br)
    {
      IsAnimated = br.ReadSByte();
      AnimationFrameCount = br.ReadInt16();
      PauseFrameCount = br.ReadInt16();
      Interval = br.ReadSingle();
      PauseAfterLoop = br.ReadSingle();
      Frame = br.ReadInt16();
      DrawFrame = br.ReadInt16();
      AnimateLast = br.ReadSingle();
      HasFrameChanged = br.ReadSByte();
      Drawn = br.ReadSByte();
    }
  }
}
