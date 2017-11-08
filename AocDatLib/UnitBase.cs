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
    public ushort HelpDllId { get; set; }
    public ushort[] HotKeyDllId { get; set; }
    internal byte _unknown1 { get; set; }
    internal byte _unknown2 { get; set; }
    public byte Unselectable { get; set; }
    internal byte _unknown3 { get; set; }
    internal byte _unknown4 { get; set; }
    internal byte _unknown5 { get; set; }
    public byte SelectionMask { get; set; }
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
    public List<DamageGraphic> DamangeGraphics { get; internal set; }
    public short SelectionSound { get; set; }
    public short DyingSound { get; set; }
    public byte AttackMode { get; set; }
    internal byte _unknown6 { get; set; }
    public char [] Name { get; set; }
    public short Id1 { get; set; }
    public short Id2 { get; set; }
  }
}
