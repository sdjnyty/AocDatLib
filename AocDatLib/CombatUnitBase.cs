using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public abstract class CombatUnitBase:ActionUnit
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
    public short DelayFrame { get; set; }
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

    protected internal override void BinaryReaderRead(BinaryReader br)
    {
      base.BinaryReaderRead(br);
      BaseArmor = br.ReadInt16();
      var nAttacks = br.ReadUInt16();
      Attacks = new List<AtkDefEntry>(nAttacks);
      for(var i=0;i<nAttacks;i++)
      {
        var a = new AtkDefEntry();
        Attacks.Add(a);
        a.Id = br.ReadInt16();
        a.Amount = br.ReadInt16();
      }
      var nDefenses = br.ReadUInt16();
      Defenses = new List<AtkDefEntry>(nDefenses);
      for(var i=0;i<nDefenses;i++)
      {
        var d = new AtkDefEntry();
        Defenses.Add(d);
        d.Id = br.ReadInt16();
        d.Amount = br.ReadInt16();
      }
      BoundaryId = br.ReadInt16();
      MaxRange = br.ReadSingle();
      BlastRadius = br.ReadSingle();
      ReloadTime = br.ReadSingle();
      ProjectileUnitId = br.ReadInt16();
      Accuracy = br.ReadInt16();
      BreakOffCombat = br.ReadByte();
      DelayFrame = br.ReadInt16();
      GraphicDisplacementX = br.ReadSingle();
      GraphicDisplacementY = br.ReadSingle();
      GraphicDisplacementZ = br.ReadSingle();
      BlastLevel = br.ReadByte();
      MinRange = br.ReadSingle();
      AccuracyDispersion = br.ReadSingle();
      FightSpriteId = br.ReadInt16();
      MeleeArmorDisplay = br.ReadInt16();
      AttackDisplay = br.ReadInt16();
      RangeDisplay = br.ReadInt16();
      ReloadTimeDisplay = br.ReadSingle();
    }
  }
}
