using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class Unit
  {
    public byte Type { get; set; }
    public short Id { get; set; }
    public ushort LanguageDllIdName { get; set; }
    public ushort LanguageDllIdCreate { get; set; }
    public short UnitClass { get; set; }
    public short StandingGraphic0 { get; set; }
    public short StandingGraphic1 { get; set; }
    public short DyingGraphic { get; set; }
    public short UndeadGraphic { get; set; }
    public sbyte UndeadMode { get; set; }
    public short HitPoints { get; set; }
    public float LineOfSight { get; set; }
    public sbyte GarrisonCapacity { get; set; }
    public float CollisionSizeX { get; set; }
    public float CollisionSizeY { get; set; }
    public float CollisionSizeZ { get; set; }
    public short TrainSound { get; set; }
    public short DamageSound { get; set; }
    public short DeadUnitId { get; set; }
    public sbyte SortNumber { get; set; }
    public sbyte CanBeBuiltOn { get; set; }
    public short IconId { get; set; }
    public sbyte HideInEditor { get; set; }
    public short OldPortraitPict { get; set; }
    public byte Enabled { get; set; }
    public byte Disabled { get; set; }
    public short PlacementSideTerrain0 { get; set; }
    public short PlacementSideTerrain1 { get; set; }
    public short PlacementTerrain0 { get; set; }
    public short PlacementTerrain1 { get; set; }
    public float ClearanceSizeX { get; set; }
    public float ClearanceSizeY { get; set; }
    public byte HillMode { get; set; }
    public byte FogVisibility { get; set; }
    public short TerrainRestriction { get; set; }
    public byte FlyMode { get; set; }
    public short ResourceCapacity { get; set; }
    public float ResourceDecay { get; set; }
    public byte BlastDefenseLevel { get; set; }
    public byte CombatLevel { get; set; }
    public byte InteractionMode { get; set; }
    public byte MinimapMode { get; set; }
    public byte InterfaceKind { get; set; }
    public float MultipleAttributeMode { get; set; }
    public byte MinimapColor { get; set; }
    public int LanguageDllIdHelp { get; set; }
    public int LanguageDllIdHotKeyText { get; set; }
    public int HotKey { get; set; }
    public byte Recyclable { get; set; }
    public byte EnableAutoGather { get; set; }
    public byte CreateDoppelgangerOnDeath { get; set; }
    public byte ResourceGatherGroup { get; set; }
    public sbyte OcclusionMode { get; set; }
    public byte ObstructionType { get; set; }
    public byte ObstructionClass { get; set; }
    public byte Trait { get; set; }
    public byte Civilization { get; set; }
    public short Nothing { get; set; }
    public byte SelectionEffect { get; set; }
    public byte EditorSelectionColor { get; set; }
    public float OutlineSizeX { get; set; }
    public float OutlineSizeY { get; set; }
    public float OutlineSizeZ { get; set; }
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
    public byte OldAttackReaction { get; set; }
    public byte ConvertTerrain { get; set; }
    public byte[] Name { get; set; }
    public short CopyId { get; set; }
    public short BaseId { get; set; }
    public float Speed { get; set; }
    public short WalkingGraphic { get; set; }
    public short RunnngGraphic { get; set; }
    public float RotationSpeed { get; set; }
    public byte OldSizeClass { get; set; }
    public short TrackingUnitId { get; set; }
    public byte TrackingUnitMode { get; set; }
    public float TrackingUnitDensity { get; set; }
    public byte OldMoveAlgorithm { get; set; }
    public float TurnRadius { get; set; }
    public float TurnRadiusSpeed { get; set; }
    public float MaxYawPerSecondMoving { get; set; }
    public float StationaryYawRevolutionTime { get; set; }
    public float MaxYawPerSecondStationary { get; set; }
    public short DefaultTaskId { get; set; }
    public float SearchRadius { get; set; }
    public float WorkRate { get; set; }
    public short DropSite0 { get; set; }
    public short DropSite1 { get; set; }
    public byte TaskSwapGroup { get; set; }
    public short AttackSoundId { get; set; }
    public short MoveSoundId { get; set; }
    public byte RunPattern { get; set; }
    public short BaseArmor { get; set; }
    public List<AttackArmor> Attacks { get; internal set; }
    public List<AttackArmor> Armors { get; internal set; }
    public short DefenseTerrainBonus { get; set; }
    public float MaxRange { get; set; }
    public float BlastWidth { get; set; }
    public float ReloadTime { get; set; }
    public short ProjectileUnitId { get; set; }
    public short AccuracyPercent { get; set; }
    public byte BreakOffCombat { get; set; }
    public short FrameDelay { get; set; }
    public float GraphicDisplacementX { get; set; }
    public float GraphicDisplacementY { get; set; }
    public float GraphicDisplacementZ { get; set; }
    public byte BlastAttackLevel { get; set; }
    public float MinRange { get; set; }
    public float AccuracyDispersion { get; set; }
    public short AttackGraphic { get; set; }
    public short DisplayedMeleeArmor { get; set; }
    public short DisplayedAttack { get; set; }
    public float DisplayedRange { get; set; }
    public float DisplayedReloadTime { get; set; }
    public byte ProjectileType { get; set; }
    public byte SmartMode { get; set; }
    public byte HitMode { get; set; }
    public byte VanishMode { get; set; }
    public byte AreaEffectSpecials { get; set; }
    public float ProjectileArc { get; set; }
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
    public byte ButtonId { get; set; }
    public float RearAttackModifier { get; set; }
    public float FlankAttackModifier { get; set; }
    public byte CreatableType { get; set; }
    public byte HeroMode { get; set; }
    public int GarrisonGraphic { get; set; }
    public float TotalProjectiles { get; set; }
    public byte MaxTotalProjectiles { get; set; }
    public float ProjectileSpawningAreaWidth { get; set; }
    public float ProjectileSpawningAreaLength { get; set; }
    public float ProjectileSpawningAreaRandomness { get; set; }
    public int SecondaryProjectileId { get; set; }
    public int SpecialGraphicId { get; set; }
    public byte SpecialAbility { get; set; }
    public short DisplayedPierceArmor { get; set; }
    public short ConstructionGraphicId { get; set; }
    public short SnowGraphicId { get; set; }
    public byte AdjacentMode { get; set; }
    public short GraphicsAngle { get; set; }
    public byte DisappearsWhenBuilt { get; set; }
    public short StackUnitId { get; set; }
    public short FoundationTerrainId { get; set; }
    public short OldOverlayId { get; set; }
    public short TechId { get; set; }
    public byte CanBurn { get; set; }
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
    public short TransformSound { get; set; }
    public short ConstructionSoundId { get; set; }
    public byte GarrisonType { get; set; }
    public float GarrisonHealRate { get; set; }
    public float GarrisonRepairRate { get; set; }
    public short PileUnit { get; set; }
    [System.Xml.Serialization.XmlIgnore]
    public byte[] LootingTable { get; set; }

    protected internal void BinaryReaderRead(System.IO.BinaryReader br)
    {
      Type = br.ReadByte();
      var nameLength = br.ReadUInt16();
      Id = br.ReadInt16();
      LanguageDllIdName = br.ReadUInt16();
      LanguageDllIdCreate = br.ReadUInt16();
      UnitClass = br.ReadInt16();
      StandingGraphic0 = br.ReadInt16();
      StandingGraphic1 = br.ReadInt16();
      DyingGraphic = br.ReadInt16();
      UndeadGraphic = br.ReadInt16();
      UndeadMode = br.ReadSByte();
      HitPoints = br.ReadInt16();
      LineOfSight = br.ReadSingle();
      GarrisonCapacity = br.ReadSByte();
      CollisionSizeX = br.ReadSingle();
      CollisionSizeY = br.ReadSingle();
      CollisionSizeZ = br.ReadSingle();
      TrainSound = br.ReadInt16();
      DamageSound = br.ReadInt16();
      DeadUnitId = br.ReadInt16();
      SortNumber = br.ReadSByte();
      CanBeBuiltOn = br.ReadSByte();
      IconId = br.ReadInt16();
      HideInEditor = br.ReadSByte();
      OldPortraitPict = br.ReadInt16();
      Enabled = br.ReadByte();
      Disabled = br.ReadByte();
      PlacementSideTerrain0 = br.ReadInt16();
      PlacementSideTerrain1 = br.ReadInt16();
      PlacementTerrain0 = br.ReadInt16();
      PlacementTerrain1 = br.ReadInt16();
      ClearanceSizeX = br.ReadSingle();
      ClearanceSizeY = br.ReadSingle();
      HillMode = br.ReadByte();
      FogVisibility = br.ReadByte();
      TerrainRestriction = br.ReadInt16();
      FlyMode = br.ReadByte();
      ResourceCapacity = br.ReadInt16();
      ResourceDecay = br.ReadSingle();
      BlastDefenseLevel = br.ReadByte();
      CombatLevel = br.ReadByte();
      InteractionMode = br.ReadByte();
      MinimapMode = br.ReadByte();
      InterfaceKind = br.ReadByte();
      MultipleAttributeMode = br.ReadSingle();
      MinimapColor = br.ReadByte();
      LanguageDllIdHelp = br.ReadInt32();
      LanguageDllIdHotKeyText = br.ReadInt32();
      HotKey = br.ReadInt32();
      Recyclable = br.ReadByte();
      EnableAutoGather = br.ReadByte();
      CreateDoppelgangerOnDeath = br.ReadByte();
      ResourceGatherGroup = br.ReadByte();
      OcclusionMode = br.ReadSByte();
      ObstructionType = br.ReadByte();
      ObstructionClass = br.ReadByte();
      Trait = br.ReadByte();
      Civilization = br.ReadByte();
      Nothing = br.ReadInt16();
      SelectionEffect = br.ReadByte();
      EditorSelectionColor = br.ReadByte();
      OutlineSizeX = br.ReadSingle();
      OutlineSizeY = br.ReadSingle();
      OutlineSizeZ = br.ReadSingle();
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
        dg.OldApplyMode = br.ReadByte();
        dg.ApplyMode = br.ReadByte();
      }
      SelectionSound = br.ReadInt16();
      DyingSound = br.ReadInt16();
      OldAttackReaction = br.ReadByte();
      ConvertTerrain = br.ReadByte();
      Name = br.ReadBytes(nameLength);
      CopyId = br.ReadInt16();
      BaseId = br.ReadInt16();
      if (Type >= 20)
      {
        Speed = br.ReadSingle();
      }
      if(Type>=30)
      {
        WalkingGraphic = br.ReadInt16();
        RunnngGraphic = br.ReadInt16();
        RotationSpeed = br.ReadSingle();
        OldSizeClass = br.ReadByte();
        TrackingUnitId = br.ReadInt16();
        TrackingUnitMode = br.ReadByte();
        TrackingUnitDensity = br.ReadSingle();
        OldMoveAlgorithm = br.ReadByte();
        TurnRadius = br.ReadSingle();
        TurnRadiusSpeed = br.ReadSingle();
        MaxYawPerSecondMoving = br.ReadSingle();
        StationaryYawRevolutionTime = br.ReadSingle();
        MaxYawPerSecondStationary = br.ReadSingle();
      }
      if(Type>=40)
      {
        DefaultTaskId = br.ReadInt16();
        SearchRadius = br.ReadSingle();
        WorkRate = br.ReadSingle();
        DropSite0 = br.ReadInt16();
        DropSite1 = br.ReadInt16();
        TaskSwapGroup = br.ReadByte();
        AttackSoundId = br.ReadInt16();
        MoveSoundId = br.ReadInt16();
        RunPattern = br.ReadByte();
      }
      if(Type>=50)
      {
        BaseArmor = br.ReadInt16();
        var nAttacks = br.ReadUInt16();
        Attacks = new List<AttackArmor>(nAttacks);
        for (var i = 0; i < nAttacks; i++)
        {
          var a = new AttackArmor();
          Attacks.Add(a);
          a.Id = br.ReadInt16();
          a.Amount = br.ReadInt16();
        }
        var nDefenses = br.ReadUInt16();
        Armors = new List<AttackArmor>(nDefenses);
        for (var i = 0; i < nDefenses; i++)
        {
          var d = new AttackArmor();
          Armors.Add(d);
          d.Id = br.ReadInt16();
          d.Amount = br.ReadInt16();
        }
        DefenseTerrainBonus = br.ReadInt16();
        MaxRange = br.ReadSingle();
        BlastWidth = br.ReadSingle();
        ReloadTime = br.ReadSingle();
        ProjectileUnitId = br.ReadInt16();
        AccuracyPercent = br.ReadInt16();
        BreakOffCombat = br.ReadByte();
        FrameDelay = br.ReadInt16();
        GraphicDisplacementX = br.ReadSingle();
        GraphicDisplacementY = br.ReadSingle();
        GraphicDisplacementZ = br.ReadSingle();
        BlastAttackLevel = br.ReadByte();
        MinRange = br.ReadSingle();
        AccuracyDispersion = br.ReadSingle();
        AttackGraphic = br.ReadInt16();
        DisplayedMeleeArmor = br.ReadInt16();
        DisplayedAttack = br.ReadInt16();
        DisplayedRange = br.ReadSingle();
        DisplayedReloadTime = br.ReadSingle();
      }
      if(Type==60)
      {
        ProjectileType = br.ReadByte();
        SmartMode = br.ReadByte();
        HitMode = br.ReadByte();
        VanishMode = br.ReadByte();
        AreaEffectSpecials = br.ReadByte();
        ProjectileArc = br.ReadSingle();
      }
      if(Type>=70)
      {
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
        ButtonId = br.ReadByte();
        RearAttackModifier = br.ReadSingle();
        FlankAttackModifier = br.ReadSingle();
        CreatableType = br.ReadByte();
        HeroMode = br.ReadByte();
        GarrisonGraphic = br.ReadInt32();
        TotalProjectiles = br.ReadSingle();
        MaxTotalProjectiles = br.ReadByte();
        ProjectileSpawningAreaWidth = br.ReadSingle();
        ProjectileSpawningAreaLength = br.ReadSingle();
        ProjectileSpawningAreaRandomness = br.ReadSingle();
        SecondaryProjectileId = br.ReadInt32();
        SpecialGraphicId = br.ReadInt32();
        SpecialAbility = br.ReadByte();
        DisplayedPierceArmor = br.ReadInt16();
      }
      if(Type==80)
      {
        ConstructionGraphicId = br.ReadInt16();
        SnowGraphicId = br.ReadInt16();
        AdjacentMode = br.ReadByte();
        GraphicsAngle = br.ReadInt16();
        DisappearsWhenBuilt = br.ReadByte();
        StackUnitId = br.ReadInt16();
        FoundationTerrainId = br.ReadInt16();
        OldOverlayId = br.ReadInt16();
        TechId = br.ReadInt16();
        CanBurn = br.ReadByte();
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
        TransformSound = br.ReadInt16();
        ConstructionSoundId = br.ReadInt16();
        GarrisonType = br.ReadByte();
        GarrisonHealRate = br.ReadSingle();
        GarrisonRepairRate = br.ReadSingle();
        PileUnit = br.ReadInt16();
        LootingTable = br.ReadBytes(6);
      }
    }
  }
}
