using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class UnitBase
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

  }
}
