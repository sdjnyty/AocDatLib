using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class CombatUnit:CombatUnitBase
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

    protected internal override void BinaryReaderRead(BinaryReader br)
    {
      base.BinaryReaderRead(br);
      Cost1Id = br.ReadInt16();
      Cost1Amount = br.ReadInt16();
      Cost1Used = br.ReadInt16();
      Cost2Id = br.ReadInt16();
      Cost2Amount = br.ReadInt16();
      Cost2Used = br.ReadInt16();
      Cost3Id = br.ReadInt16();
      Cost3Amount = br.ReadInt16();
      Cost3Used = br.ReadInt16();
      TrainTime = br.ReadInt16();
      TrainLocationId = br.ReadInt16();
      TrainButton = br.ReadByte();
      BackstabBonus = br.ReadSingle();
      FlankBonus = br.ReadSingle();
      CreateableTypes = br.ReadByte();
      HeroMode = br.ReadByte();
      GarrisonGraphic = br.ReadInt16();
      ProjectileCount = br.ReadSingle();
      MaxProjectiles = br.ReadByte();
      ProjectileSpawningAreaWidth = br.ReadSingle();
      ProjectileSpawningAreaLength = br.ReadSingle();
      ProjectileSpawningAreaRandomness = br.ReadSingle();
      SecondaryProjectileId = br.ReadInt16();
      SpecialGraphicId = br.ReadInt32();
      SpecialAbility = br.ReadByte();
      PierceArmorDisplay = br.ReadInt16();
    }
  }
}
