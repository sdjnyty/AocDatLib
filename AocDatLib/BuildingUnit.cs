using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class BuildingUnit:LivingUnit
  {
    public short ConstructionGraphicId { get; set; }
    public short SnowGraphicId { get; set; }
    public byte AdjacentMode { get; set; }
    public short IconDisabler { get; set; }
    public byte DisappearsWhenBuilt { get; set; }
    public short StackUnitId { get; set; }
    public short FoundationTerrainId { get; set; }
    public short OverlayId { get; set; }
    public short ResearchId { get; set; }
    public byte AnnexMode { get; set; }
    public short Annex1Id { get; set; }
    public float Annex1Misplacement0 { get; set; }
    public float Annex1Misplacement1 { get; set; }
    public short Annex2Id { get; set; }
    public float Annex2Misplacement0 { get; set; }
    public float Annex2Misplacement1 { get; set; }
    public short Annex3Id { get; set; }
    public float Annex3Misplacement0 { get; set; }
    public float Annex3Misplacement1 { get; set; }
    public short Annex4Id { get; set; }
    public float Annex4Misplacement0 { get; set; }
    public float Annex4Misplacement1 { get; set; }
    public short HeadUnitId { get; set; }
    public short TransformUnitId { get; set; }
    public short PileUnit { get; set; }
    public short ConstructionSoundId { get; set; }
    public byte GarrisonType { get; set; }
    public float GarrisonHealRate { get; set; }
    public float GarrisonRepairRate { get; set; }
    public short CanBurn { get; set; }
    public byte[] Loot { get; set; }
  }
}
