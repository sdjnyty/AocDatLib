using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class MovingUnit:AnimatedUnit
  {
    public short WalkingGraphic0 { get; set; }
    public short WalkingGraphic1 { get; set; }
    public float TurnSpeed { get; set; }
    public byte SizeClass { get; set; }
    public short TrailUnitId { get; set; }
    public byte TrailOptions { get; set; }
    public float TrailSpacing { get; set; }
    public byte MoveAlgorithm { get; set; }
    public float TurnRadius { get; set; }
    public float TurnRadiusSpeed { get; set; }
    public float MaxYPSMoving { get; set; }
    public float YawRoundTime { get; set; }
    public float MaxYPSStationary { get; set; }

    protected internal override void BinaryReaderRead(BinaryReader br)
    {
      base.BinaryReaderRead(br);
      WalkingGraphic0 = br.ReadInt16();
      WalkingGraphic1 = br.ReadInt16();
      TurnSpeed = br.ReadSingle();
      SizeClass = br.ReadByte();
      TrailUnitId = br.ReadInt16();
      TrailOptions = br.ReadByte();
      TrailSpacing = br.ReadSingle();
      MoveAlgorithm = br.ReadByte();
      TurnRadius = br.ReadSingle();
      TurnRadiusSpeed = br.ReadSingle();
      MaxYPSMoving = br.ReadSingle();
      YawRoundTime = br.ReadSingle();
      MaxYPSStationary = br.ReadSingle();
    }
  }
}
