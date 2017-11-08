using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public abstract class BattleUnitBase:ActionUnit
  {
    public short BaseArmor { get; set; }
    public List<AtkDefEntry> Attacks { get; internal set; }
    public List<AtkDefEntry> Defenses { get; internal set; }
    public short BoundaryId { get; set; }
    public float MaxRange { get; set; }
    public float BlastRadius { get; set; }
    public float ReloadTime { get; set; }
    public short ProjectileUnitId { get; set; }
    public short Accuracy { get; set; }
    public byte BreakOffCombat { get; set; }
    public short Delay { get; set; }
    public float GraphicDisplacementX { get; set; }
    public float GraphicDisplacementY { get; set; }
    public float GraphicDisplacementZ { get; set; }
    public byte BlastLevel { get; set; }
    public float MinRange { get; set; }
    public float AccuracyDispersion { get; set; }
    public short FightSpriteId { get; set; }
    public short MeleeArmorDisplay { get; set; }
    public short AttackDisplay { get; set; }
    public float RangeDisplay { get; set; }
    public float ReloadTimeDisplay { get; set; }
  }
}
