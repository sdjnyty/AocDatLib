using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class ProjectileUnit:CombatUnitBase
  {
    public byte StretchMode { get; set; }
    public byte SmartMode { get; set; }
    public byte DropAnimationMode { get; set; }
    public byte PenetrationMode { get; set; }
    public byte AreaEffects { get; set; }
    public float Arc { get; set; }

    protected internal override void BinaryReaderRead(BinaryReader br)
    {
      base.BinaryReaderRead(br);
      StretchMode = br.ReadByte();
      SmartMode = br.ReadByte();
      DropAnimationMode = br.ReadByte();
      PenetrationMode = br.ReadByte();
      AreaEffects = br.ReadByte();
      Arc = br.ReadSingle();
    }
  }
}
