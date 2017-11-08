using System;
using System.Collections.Generic;
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
    public short TurnRadius { get; set; }
    public short TurnRadiusSpeed { get; set; }
    public short MaxYPSMoving { get; set; }
    public short YawRoundTime { get; set; }
    public short MaxYPSStationary { get; set; }
  }
}
