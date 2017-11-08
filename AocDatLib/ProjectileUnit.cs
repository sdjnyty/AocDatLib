using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class ProjectileUnit:BattleUnitBase
  {
    public byte StretchMode { get; set; }
    public byte SmartMode { get; set; }
    public byte DropAnimationMode { get; set; }
    public byte PenetrationMode { get; set; }
    public byte AreaEffects { get; set; }
    public float Arc { get; set; }
  }
}
