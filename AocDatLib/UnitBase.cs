using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public abstract  class UnitBase
  {
    public short Id0 { get; set; }
    public ushort NameDllId { get; set; }
    public ushort CreateDllId { get; set; }
    public short UnitClass { get; set; }
    public short GraphicStanding0 { get; set; }
    public short GraphicStanding1 { get; set; }
    public short GraphicDying0 { get; set; }
    public short GraphicDying1 { get; set; }
    public sbyte DeathMode { get; set; }
    public short HitPoints { get; set; }
    public float LineOfSight { get; set; }
    public sbyte GarrisonCapacity { get; set; }
    public float RadiusX { get; set; }
    public float RadiusY { get; set; }
    public float RadiusZ { get; set; }
    public short SoundCreation0 { get; set; }
    public short SoundCreation1 { get; set; }
    public short DeadUnitId { get; set; }
    public sbyte PlacementMode { get; set; }
    public sbyte AirMode { get; set; }
    public short CreationIcon { get; set; }
    public sbyte Hidden { get; set; }
    public short Icon { get; set; }
    public short Available { get; set; }
    public short PlacementSideTerrain0 { get; set; }
    public short PlacementSideTerrain1 { get; set; }
    public short PlacementTerrain0 { get; set; }
    public short PlacementTerrain1 { get; set; }
    public float ClearanceSizeX { get; set; }
    public float ClearanceSizeY { get; set; }
    public byte BuildingMode { get; set; }
    public byte FogVisibility { get; set; }
    public short TerrainRestriction { get; set; }
    public byte MovementMode { get; set; }
    public short ResourceCapacity { get; set; }
    public float ResourceDecay { get; set; }
    public byte BlastDefenseLevel { get; set; }
    public byte CombatLevel { get; set; }
    public byte InteractionMode { get; set; }
    public byte MapDrawLevel { get; set; }
    public byte UnitLevel { get; set; }
    public float AttackReaction { get; set; }
    public byte MinimapColor { get; set; }
    public int HelpDllId { get; set; }
    public int HotKeyAoeDllId { get; set; }
    public int HotKeyDllId { get; set; }
    public byte Recyclable { get; set; }
    public byte AutoGather { get; set; }
    public byte CreateDoppelgangerOnDeath { get; set; }
    public byte ResourceGatherGroup { get; set; }
    public sbyte SelectionMask { get; set; }
    public byte SelectionShapeKind { get; set; }
    public byte SelectionShape { get; set; }
    public byte Attributes { get; set; }
    public byte Civilization { get; set; }
    public short AttributePiece { get; set; }
    public byte SelectionEffect { get; set; }
    public byte EditorSelectionColor { get; set; }
    public float SelectionShapeX { get; set; }
    public float SelectionShapeY { get; set; }
    public float SelectionShapeZ { get; set; }
    public short Storage1Id { get; set; }
    public float Storage1Amount { get; set; }
    public byte Storage1Mode { get; set; }
    public short Storage2Id { get; set; }
    public float Storage2Amount { get; set; }
    public byte Storage2Mode { get; set; }
    public short Storage3Id { get; set; }
    public float Storage3Amount { get; set; }
    public byte Storage3Mode { get; set; }
    public List<DamageGraphic> DamageGraphics { get; internal set; }
    public short SelectionSound { get; set; }
    public short DyingSound { get; set; }
    public byte AttackMode { get; set; }
    public byte ConvertTerrain { get; set; }
    public char [] Name { get; set; }
    public short Id1 { get; set; }
    public short Id2 { get; set; }

    protected internal virtual void BinaryReaderRead(System.IO.BinaryReader br)
    {
      var nameLength = br.ReadUInt16();
      Id0 = br.ReadInt16();
      NameDllId = br.ReadUInt16();
      CreateDllId = br.ReadUInt16();
      UnitClass = br.ReadInt16();
      GraphicStanding0 = br.ReadInt16();
      GraphicStanding1 = br.ReadInt16();
      GraphicDying0 = br.ReadInt16();
      GraphicDying1 = br.ReadInt16();
      DeathMode = br.ReadSByte();
      HitPoints = br.ReadInt16();
      LineOfSight = br.ReadSingle();
      GarrisonCapacity = br.ReadSByte();
      RadiusX = br.ReadSingle();
      RadiusY = br.ReadSingle();
      RadiusZ = br.ReadSingle();
      SoundCreation0 = br.ReadInt16();
      SoundCreation1 = br.ReadInt16();
      DeadUnitId = br.ReadInt16();
      PlacementMode = br.ReadSByte();
      AirMode = br.ReadSByte();
      CreationIcon = br.ReadInt16();
      Hidden = br.ReadSByte();
      Icon = br.ReadInt16();
      Available = br.ReadInt16();
      PlacementSideTerrain0 = br.ReadInt16();
      PlacementSideTerrain1 = br.ReadInt16();
      PlacementTerrain0 = br.ReadInt16();
      PlacementTerrain1 = br.ReadInt16();
      ClearanceSizeX = br.ReadSingle();
      ClearanceSizeY = br.ReadSingle();
      BuildingMode = br.ReadByte();
      FogVisibility = br.ReadByte();
      TerrainRestriction = br.ReadInt16();
      MovementMode = br.ReadByte();
      ResourceCapacity = br.ReadInt16();
      ResourceDecay = br.ReadSingle();
      BlastDefenseLevel = br.ReadByte();
      CombatLevel = br.ReadByte();
      InteractionMode = br.ReadByte();
      MapDrawLevel = br.ReadByte();
      UnitLevel = br.ReadByte();
      AttackReaction = br.ReadSingle();
      MinimapColor = br.ReadByte();
      HelpDllId = br.ReadInt32();
      HotKeyAoeDllId = br.ReadInt32();
      HotKeyDllId = br.ReadInt32();
      Recyclable = br.ReadByte();
      AutoGather = br.ReadByte();
      CreateDoppelgangerOnDeath = br.ReadByte();
      ResourceGatherGroup = br.ReadByte();
      SelectionMask = br.ReadSByte();
      SelectionShapeKind = br.ReadByte();
      SelectionShape = br.ReadByte();
      Attributes = br.ReadByte();
      Civilization = br.ReadByte();
      AttributePiece = br.ReadInt16();
      SelectionEffect = br.ReadByte();
      EditorSelectionColor = br.ReadByte();
      SelectionShapeX = br.ReadSingle();
      SelectionShapeY = br.ReadSingle();
      SelectionShapeZ = br.ReadSingle();
      Storage1Id = br.ReadInt16();
      Storage1Amount = br.ReadSingle();
      Storage1Mode = br.ReadByte();
      Storage2Id = br.ReadInt16();
      Storage2Amount = br.ReadSingle();
      Storage2Mode = br.ReadByte();
      Storage3Id = br.ReadInt16();
      Storage3Amount = br.ReadSingle();
      Storage3Mode = br.ReadByte();
      var nDamageGraphics = br.ReadByte();
      DamageGraphics = new List<DamageGraphic>(nDamageGraphics);
      for(var i=0;i<nDamageGraphics;i++)
      {
        var dg = new DamageGraphic();
        DamageGraphics.Add(dg);
        dg.GraphicId = br.ReadInt16();
        dg.DamagePercent = br.ReadByte();
        dg.ApplyModeOld = br.ReadByte();
        dg.ApplyMode = br.ReadByte();
      }
      SelectionSound = br.ReadInt16();
      DyingSound = br.ReadInt16();
      AttackMode = br.ReadByte();
      ConvertTerrain = br.ReadByte();
      Name = br.ReadChars(nameLength);
      Id1 = br.ReadInt16();
      Id2 = br.ReadInt16();
    }
  }
}
