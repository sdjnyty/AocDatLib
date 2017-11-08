using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class LivingUnit:BattleUnitBase
  {
    public short Cost1Id { get; set; }
    public short Cost1Amount { get; set; }
    public short Cost1Used { get; set; }
    public short Cost2Id { get; set; }
    public short Cost2Amount { get; set; }
    public short Cost2Used { get; set; }
    public short Cost3Id { get; set; }
    public short Cost3Amount { get; set; }
    public short Cost3Used { get; set; }
    public short TrainTime { get; set; }
    public short TrainLocationId { get; set; }
    public byte TrainButton { get; set; }
    public float BackstabBonus { get; set; }
    public float FlankBonus { get; set; }
    public byte CreateableTypes { get; set; }
    public byte HeroMode { get; set; }
    public int GarrisonGraphic { get; set; }
    public float ProjectileCount { get; set; }
    public byte MaxProjectiles { get; set; }
    public float ProjectileSpawningAreaWidth { get; set; }
    public float ProjectileSpawningAreaLength { get; set; }
    public float ProjectileSpawningAreaRandomness { get; set; }
    public short SecondaryProjectileId { get; set; }
    public int SpecialGraphicId { get; set; }
    public byte SpecialAbility { get; set; }
    public short PierceArmorDisplay { get; set; }
  }
}
