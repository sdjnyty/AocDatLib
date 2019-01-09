using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class Graphic
  {
    public byte[] Name0 { get; set; }

    public byte[] Name1 { get; set; }

    public int SlpId { get; set; }

    internal sbyte Unknown1 { get; set; }

    internal sbyte Unknown2 { get; set; }

    public sbyte Layer { get; set; }

    public sbyte PlayerColor { get; set; }

    public sbyte AdaptColor { get; set; }

    public byte LoopAnimation { get; set; }

    public short X1 { get; set; }

    public short Y1 { get; set; }

    public short X2 { get; set; }

    public short Y2 { get; set; }

    public short SoundId { get; set; }

    public sbyte AttackSoundUsed { get; set; }

    public short FramesPerAngle { get; set; }

    public short AngleCount { get; set; }

    public float UnitSpeedMultiplier { get; set; }

    public float FrameDurationInSecond { get; set; }

    public float ReplayDelay { get; set; }

    public sbyte SequenceKind { get; set; }

    public short Id { get; set; }

    public sbyte MirroringMode { get; set; }

    internal byte Unknown3 { get; set; }

    public List<GraphicDelta> Deltas { get; internal set; }

    public List<GraphicAttackSound> AttackSounds { get; internal set; }
  }
}
