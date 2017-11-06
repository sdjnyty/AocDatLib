using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace YTY.AocDatLib
{
  public class DatFile
  {
    public const int TerrainBorderCount = 16;

    private char[] _version;

    public List<TerrainRestriction> TerrainRestrictions { get; private set; }

    public List<PlayerColor> PlayerColors { get; private set; }

    public List<Sound> Sounds { get; private set; }

    public List<Graphic> Graphics { get; private set; }

    private int _pMap;
    private int _unknown1;
    private int _mapWidth;
    private int _mapHeight;
    private int _worldWidth;
    private int _worldHeight;

    private const int TILESIZECOUNT = 19;
    public TileSize[] TileSizes => new TileSize[TILESIZECOUNT];

    private short _unknown2;

    public Terrain[] Terrains { get; private set; }

    public TerrainBorder[] TerrainBorders { get; } = new TerrainBorder[TerrainBorderCount];

    private int _unknown3;

    public float MapMinX { get; set; } 
    public float MapMinY { get; set; }
        public float MapMaxX { get; set; }
    public float MapMaxY { get; set; }
    public float MapMaxXPlus1 { get; set; }
    public float MapMaxYPlus1 { get; set; }
    public ushort TerrainCountAdditional { get; set; }
    public ushort BordersUsed { get; set; }
public short MaxTerrain { get; set; }
    public short TileWidth { get; set; }
    public short TileHeight { get; set; }
    public short TileHalfHeight { get; set; }
    public short TileHalfWidth { get; set; }
    public short ElevHeight { get; set; }
    public short CurrentRow { get; set; }
    public short CurrentColumn { get; set; }
    public short BlockBeginRow { get; set; }
    public short BlockEndRow { get; set; }
    public short BlockBeginColumn { get; set; }
    public short BlockEndColumn { get; set; }
    internal uint _unknown4;
    internal uint _unknown5;
    public sbyte AnyFrameChange { get; set; }
    public sbyte MapVisibleFlag { get; set; }
    public sbyte FogFlag { get; set; }
    internal byte[] TerrainBlob0 { get; set; }
    internal uint[] TerrainBlob1 { get; set; }
    public List<MapHeader> MapHeaders { get; }
    public List<Map> Maps { get; }

    public DatFile(string fileName)
    {
      using (var ds = new DeflateStream(new FileStream(fileName, FileMode.Open), CompressionMode.Decompress))
      {
        using (var ms = new MemoryStream())
        {
          ds.CopyTo(ms);
          ms.Seek(0, SeekOrigin.Begin);
          using (var br = new BinaryReader(ms, Encoding.ASCII))
          {
            _version = br.ReadChars(8);
            var nTerrainRestrictions = br.ReadUInt16();
            var nTerrains = br.ReadUInt16();
            var pTerrainRestrictions0 = new int[nTerrainRestrictions];
            var pTerrainRestrictions1 = new int[nTerrainRestrictions];
            for (var i = 0; i < nTerrainRestrictions; i++)
            {
              pTerrainRestrictions0[i] = br.ReadInt32();
            }
            for (var i = 0; i < nTerrainRestrictions; i++)
            {
              pTerrainRestrictions1[i] = br.ReadInt32();
            }
            TerrainRestrictions = new List<TerrainRestriction>(nTerrainRestrictions);
            for(var i = 0;i<nTerrainRestrictions;i++)
            {
              var tr = new TerrainRestriction();
              TerrainRestrictions.Add(tr);
              tr.AccessibleDamageMultiplier = new List<float>(nTerrains);
              for(var j=0;j<nTerrains;j++)
              {
                tr.AccessibleDamageMultiplier.Add(br.ReadSingle());
              }
              tr.PassGraphics = new List<TerrainPassGraphic>(nTerrains);
              for(var j=0;j<nTerrains;j++)
              {
                var tpg = new TerrainPassGraphic();
                tr.PassGraphics.Add(tpg);
                tpg.SlpIdExitTile = br.ReadInt32();
                tpg.SlpIdEnterTile = br.ReadInt32();
                tpg.SlpIdWalkTile = br.ReadInt32();
                tpg.WalkSpriteRate = br.ReadSingle();
              }
            }
            var nPlayerColors = br.ReadUInt16();
            PlayerColors = new List<PlayerColor>(nPlayerColors);
            for(var i=0;i<nPlayerColors;i++)
            {
              var pc = new PlayerColor();
              PlayerColors.Add(pc);
              pc.Id = br.ReadInt32();
              pc.BaseColorId = br.ReadInt32();
              pc.OutlineColorId = br.ReadInt32();
              pc.Unknown1 = br.ReadInt32();
              pc.Unknown2 = br.ReadInt32();
              pc.MinimapColorId = br.ReadInt32();
              pc.Unknown3 = br.ReadInt32();
              pc.Unknown4 = br.ReadInt32();
              pc.StatisticsColorId = br.ReadInt32();
            }
            var nSounds = br.ReadUInt16();
            Sounds = new List<Sound>(nSounds);
            for(var i=0;i<nSounds;i++)
            {
              var s = new Sound();
              Sounds.Add(s);
              s.Id = br.ReadInt16();
              s.PlayAtUpdateCount = br.ReadInt16();
              var nItems = br.ReadUInt16();
              s.CacheTime = br.ReadInt32();
              s.Items = new List<SoundItem>(nItems);
              for (var j = 0; j < nItems; j++)
              {
                var it = new SoundItem();
                s.Items.Add(it);
                it.FileName = br.ReadChars(13);
                it.Id = br.ReadInt32();
                it.Probability = br.ReadInt16();
                it.Civilization = br.ReadInt16();
                it.PlayerId = br.ReadInt16();
              }
            }
            var nGraphics = br.ReadUInt16();
            var pGraphics = new uint[nGraphics];
            for(var i=0;i<nGraphics;i++)
            {
              pGraphics[i] = br.ReadUInt32();
            }
            Graphics = new List<Graphic>(nGraphics);
            for(var i=0;i<nGraphics;i++)
            {
              if(pGraphics[i]==0)
              {
                continue;
              }
              var g = new Graphic();
              Graphics.Add(g);
              g.Name0 = br.ReadChars(21);
              g.Name1 = br.ReadChars(13);
              g.SlpId = br.ReadInt32();
              g.Unknown1 = br.ReadSByte();
              g.Unknown2 = br.ReadSByte();
              g.Layer = br.ReadSByte();
              g.PlayerColor = br.ReadSByte();
              g.AdaptColor = br.ReadSByte();
              g.LoopAnimation = br.ReadByte();
              g.X1 = br.ReadInt16();
              g.Y1 = br.ReadInt16();
              g.X2 = br.ReadInt16();
              g.Y2 = br.ReadInt16();
              var nDeltas = br.ReadUInt16();
              g.SoundId = br.ReadInt16();
              g.AttackSoundUsed = br.ReadSByte();
              g.FramesPerAngle = br.ReadInt16();
              g.AngleCount = br.ReadInt16();
              g.UnitSpeedMultiplier = br.ReadSingle();
              g.FrameDurationInSecond = br.ReadSingle();
              g.ReplayDelay = br.ReadSingle();
              g.SequenceKind = br.ReadSByte();
              g.Id = br.ReadInt16();
              Debug.Assert(g.Id == i);
              g.MirroringMode = br.ReadSByte();
              g.Unknown3 = br.ReadByte();
              g.Deltas = new List<GraphicDelta>(nDeltas);
              for(var j=0;j<nDeltas;j++)
              {
                var d = new GraphicDelta();
                g.Deltas.Add(d);
                d.GraphicId = br.ReadInt16();
                d.Unknown1 = br.ReadInt16();
                d.Unknown2 = br.ReadInt16();
                d.Unknown3 = br.ReadInt16();
                d.DirectionX = br.ReadInt16();
                d.DirectionY = br.ReadInt16();
                d.Unknown4 = br.ReadInt16();
                d.Unknown5 = br.ReadInt16();
              }
              if(g.AttackSoundUsed>0)
              {
                g.AttackSounds = new List<GraphicAttackSound>(g.AngleCount);
                for (var j = 0; j < g.AngleCount; j++)
                {
                  var gas = new GraphicAttackSound();
                  g.AttackSounds.Add(gas);
                  gas.Delay1 = br.ReadInt16();
                  gas.Id1 = br.ReadInt16();
                  gas.Delay2 = br.ReadInt16();
                  gas.Id2 = br.ReadInt16();
                  gas.Delay3 = br.ReadInt16();
                  gas.Id3 = br.ReadInt16();
                }
              }
            }
            _pMap = br.ReadInt32();
            _unknown1 = br.ReadInt32();
            _mapWidth = br.ReadInt32();
            _mapHeight = br.ReadInt32();
            _worldWidth = br.ReadInt32();
            _worldHeight = br.ReadInt32();
            for(var i = 0; i < TILESIZECOUNT;i++)
            {
              var ts = new TileSize();
              TileSizes[i] = ts;
              ts.Width = br.ReadInt16();
              ts.Height = br.ReadInt16();
              ts.DeltaZ = br.ReadInt16();
            }
            _unknown2 = br.ReadInt16();
            Terrains = new Terrain[GetTerrainCount()];
            for(var i=0;i<GetTerrainCount();i++)
            {
              var t = new Terrain();
              Terrains[i] = t;
              t.Enabled = br.ReadSByte();
              t.Unknown1 = br.ReadSByte();
              t.Name0 = br.ReadChars(13);
              t.Name1 = br.ReadChars(13);
              t.SlpId = br.ReadInt32();
              t.Unknown2 = br.ReadInt32();
              t.SoundId = br.ReadInt32();
              t.BlendPriority = br.ReadInt32();
              t.BlendMode = br.ReadInt32();
              t.MapColorHi = br.ReadByte();
              t.MapColorMed = br.ReadByte();
              t.MapColorLow = br.ReadByte();
              t.CliffColorLeft = br.ReadByte();
              t.CliffColorRight = br.ReadByte();
              t.Passable = br.ReadSByte();
              t.Impassable = br.ReadSByte();
              t.Animation.BinaryReaderRead( br);
              for(var j=0;j<Terrain.TILEGRAPHICSCOUNT;j++)
              {
                var tf = new TerrainFrame();
                t.TileGraphics[j] = tf;
                tf.BinaryReaderRead(br);
              }
              t.ReplacementId = br.ReadInt16();
              t.Dimension0 = br.ReadInt16();
              t.Dimension1 = br.ReadInt16();
              t.Borders = new short[GetTerrainCount()];
              for(var j=0;j<GetTerrainCount();j++)
              {
                t.Borders[j] = br.ReadInt16();
              }
              for(var j=0;j<Terrain.TerrainUnitCount;j++)
              {
                t.UnitIds[j] = br.ReadInt16();
              }
              for (var j = 0; j < Terrain.TerrainUnitCount; j++)
              {
                t.UnitDensities[j] = br.ReadInt16();
              }
              for (var j = 0; j < Terrain.TerrainUnitCount; j++)
              {
                t.ReplacementFlag[j] = br.ReadByte();
              }
              t.TerrainUnitsUsedCount = br.ReadInt16();
              t.Unknown3 = br.ReadUInt16();
            }
            for(var i=0;i<TerrainBorderCount;i++)
            {
              var b = new TerrainBorder();
              TerrainBorders[i] = b;
              b.IsEnabled = br.ReadSByte();
              b.Unknown1 = br.ReadSByte();
              b.Name0 = br.ReadChars(13);
              b.Name1 = br.ReadChars(13);
              b.SlpId = br.ReadInt32();
              b.Unknown2 = br.ReadInt32();
              b.SoundId = br.ReadInt32();
              b.ColorHi = br.ReadByte();
              b.ColorMed = br.ReadByte();
              b.ColorLow = br.ReadByte();
              b.Animation.BinaryReaderRead(br);
              for(var j=0;j<b.Frames.Length;j++)
              {
                b.Frames[j] = new TerrainFrame();
                b.Frames[j].BinaryReaderRead(br);
              }
              b.DrawTile = br.ReadInt16();
              b.UnderlayTerrain = br.ReadInt16();
              b.BorderStyle = br.ReadInt16();
            }
            _unknown3 = br.ReadInt32();
            MapMinX = br.ReadSingle();
            MapMinY = br.ReadSingle();
            MapMaxX = br.ReadSingle();
            MapMaxY = br.ReadSingle();
            MapMaxXPlus1 = br.ReadSingle();
            MapMaxYPlus1 = br.ReadSingle();
            TerrainCountAdditional = br.ReadUInt16();
            BordersUsed = br.ReadUInt16();
            MaxTerrain = br.ReadInt16();
            TileWidth = br.ReadInt16();
            TileHeight = br.ReadInt16();
            TileHalfHeight = br.ReadInt16();
            TileHalfWidth = br.ReadInt16();
            ElevHeight = br.ReadInt16();
            CurrentRow = br.ReadInt16();
            CurrentColumn = br.ReadInt16();
            BlockBeginRow = br.ReadInt16();
            BlockEndRow = br.ReadInt16();
            BlockBeginColumn = br.ReadInt16();
            BlockEndColumn = br.ReadInt16();
            _unknown4 = br.ReadUInt32();
            _unknown5 = br.ReadUInt32();
            AnyFrameChange = br.ReadSByte();
            MapVisibleFlag = br.ReadSByte();
            FogFlag = br.ReadSByte();
            TerrainBlob0 = br.ReadBytes(21);
            TerrainBlob1 = new uint[157];
            for(var i=0;i<157;i++)
            {
              TerrainBlob1[i] = br.ReadUInt32();
            }
            var nRandomMaps = br.ReadUInt32();
            var pRandomMaps = br.ReadUInt32();
            MapHeaders = new List<MapHeader>((int)nRandomMaps);
            for(var i=0;i<nRandomMaps;i++)
            {
              var mh = new MapHeader();
              MapHeaders.Add(mh);
              mh.ScriptNumber = br.ReadInt32();
              mh.BorderSW = br.ReadInt32();
              mh.BorderNW = br.ReadInt32();
              mh.BorderNE = br.ReadInt32();
              mh.BorderSE = br.ReadInt32();
              mh.BorderUsage = br.ReadInt32();
              mh.WaterShape = br.ReadInt32();
              mh.NonBaseTerrain = br.ReadInt32();
              mh.BaseZoneCoverage = br.ReadInt32();
              mh._unknown1 = br.ReadInt32();
              mh.BaseZoneCount = br.ReadInt32();
              mh.BaseZonePtr = br.ReadInt32();
              mh.MapTerrainCount = br.ReadInt32();
              mh.MapTerrainPtr = br.ReadInt32();
              mh.MapUnitCount = br.ReadInt32();
              mh.MapUnitPtr = br.ReadInt32();
              mh._unknown2 = br.ReadInt32();
              mh._unknown3 = br.ReadInt32();
            }
            Maps = new List<Map>((int)nRandomMaps);
            for(var i=0;i<nRandomMaps;i++)
            {
              var m = new Map();
              Maps.Add(m);
              m.BorderSW = br.ReadInt32();
              m.BorderNW = br.ReadInt32();
              m.BorderNE = br.ReadInt32();
              m.BorderSE = br.ReadInt32();
              m.BorderUsage = br.ReadInt32();
              m.WaterShape = br.ReadInt32();
              m.NonBaseTerrain = br.ReadInt32();
              m.BaseZoneCoverage = br.ReadInt32();
              m._unknown1 = br.ReadInt32();
              var nBaseZones = br.ReadInt32();
              m.BaseZonePtr = br.ReadInt32();
              m.BaseZones = new List<BaseZone>(nBaseZones);
              for(var j=0;j<nBaseZones;j++)
              {
                var bz = new BaseZone();
                m.BaseZones.Add(bz);
                bz.LandId = br.ReadInt32();
                bz.BaseTerrain = br.ReadInt32();
                bz.SpacingBetweenPlayers = br.ReadInt32();
                bz.BaseSize = br.ReadInt32();
                bz.Zone = br.ReadByte();
                bz.PlacementKind = br.ReadByte();
                bz._unknown1 = br.ReadInt16();
                bz.BaseX = br.ReadInt32();
                bz.BaseY = br.ReadInt32();
                bz.LandProportion = br.ReadByte();
                bz.PlayerPlacement = br.ReadByte();
                bz.StartAreaRadius = br.ReadInt32();
                bz.TerrainEdgeFade = br.ReadInt32();
                bz.ClumpinessFactor = br.ReadInt32();
                bz._unknown2 = br.ReadInt16();
              }
              var nMapTerrains = br.ReadInt32();
              m.MapTerrainPtr = br.ReadInt32();
              m.MapTerrains = new List<MapTerrain>(nMapTerrains);
              for(var j=0;j<nMapTerrains;j++)
              {
                var mt = new MapTerrain();
                m.MapTerrains.Add( mt);
                mt.Proportion = br.ReadInt32();
                mt.Terrain = br.ReadInt32();
                mt.ClumpCount = br.ReadInt32();
                mt.SpacingToOtherTerrains = br.ReadInt32();
                mt.PlacementZone = br.ReadInt32();
                mt.ClumpinessFactor = br.ReadInt32();
              }
              var nMapUnits = br.ReadInt32();
              m.MapUnitPtr = br.ReadInt32();
              m.MapUnits = new List<MapUnit>(nMapUnits);
              for(var j=0;j<nMapUnits;j++)
              {
                var mu = new MapUnit();
                m.MapUnits.Add(mu);
                mu.Unit = br.ReadInt32();
                mu.HostTerrain = br.ReadInt32();
                mu.GroupMode = br.ReadByte();
                mu.ScaleByMapSize = br.ReadByte();
                mu._unknown1 = br.ReadInt16();
                mu.ObjectsPerGroup = br.ReadInt32();
                mu.Fluctuation = br.ReadInt32();
                mu.GroupsPerPlayer = br.ReadInt32();
                mu.GroupRadius = br.ReadInt32();
                mu.PlayerNumber = br.ReadInt32();
                mu.BaseLandNumber = br.ReadInt32();
                mu.MinDistanceToPlayers = br.ReadInt32();
                mu.MaxDistanceToPlayers = br.ReadInt32();
              }
              var nMapElevations = br.ReadInt32();
              m.MapElevationPtr = br.ReadInt32();
              m.MapElevations = new List<MapElevation>(nMapElevations);
              for(var j=0;j<nMapElevations;j++)
              {
                var me = new MapElevation();
                m.MapElevations.Add( me);
                me.Proportion = br.ReadInt32();
                me.Terrain = br.ReadInt32();
                me.ClumpCount = br.ReadInt32();
                me.BaseTerrain = br.ReadInt32();
                me.BaseElevation = br.ReadInt32();
                me.TileSpacing = br.ReadInt32();
              }
            }
            var nTechs = br.ReadInt32();
            
            Console.WriteLine(ms.Position);
          }
        }
      }
    }

    private int GetTerrainCount()
    {
      switch(new string(_version).Trim('\0'))
      {
        case "VER 5.7":
          return 32;
      }
      throw new ArgumentOutOfRangeException();
    }
  }
}
