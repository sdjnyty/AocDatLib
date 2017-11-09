using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class BuildingUnit:CombatUnit
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

    protected internal override void BinaryReaderRead(BinaryReader br)
    {
      base.BinaryReaderRead(br);
      ConstructionGraphicId = br.ReadInt16();
      SnowGraphicId = br.ReadInt16();
      AdjacentMode = br.ReadByte();
      IconDisabler = br.ReadInt16();
      DisappearsWhenBuilt = br.ReadByte();
      StackUnitId = br.ReadInt16();
      FoundationTerrainId = br.ReadInt16();
      OverlayId = br.ReadInt16();
      ResearchId = br.ReadInt16();
      AnnexMode = br.ReadByte();
      Annex1Id = br.ReadInt16();
      Annex1Misplacement0 = br.ReadSingle();
      Annex1Misplacement1 = br.ReadSingle();
      Annex2Id = br.ReadInt16();
      Annex2Misplacement0 = br.ReadSingle();
      Annex2Misplacement1 = br.ReadSingle();
      Annex3Id = br.ReadInt16();
      Annex3Misplacement0 = br.ReadSingle();
      Annex3Misplacement1 = br.ReadSingle();
      Annex4Id = br.ReadInt16();
      Annex4Misplacement0 = br.ReadSingle();
      Annex4Misplacement1 = br.ReadSingle();
      HeadUnitId = br.ReadInt16();
      TransformUnitId = br.ReadInt16();
      PileUnit = br.ReadInt16();
      ConstructionSoundId = br.ReadInt16();
      GarrisonType = br.ReadByte();
      GarrisonHealRate = br.ReadSingle();
      GarrisonRepairRate = br.ReadSingle();
      CanBurn = br.ReadInt16();
      Loot = br.ReadBytes(6);
    }
  }
}
