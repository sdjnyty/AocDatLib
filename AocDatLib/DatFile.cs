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
    private char[] _version;

    public List<TerrainRestriction> TerrainRestrictions { get; private set; }

    public List<PlayerColor> PlayerColors { get; private set; }

    public List<Sound> Sounds { get; private set; }

    public List<Graphic> Graphics { get; private set; }

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
            Console.WriteLine(ms.Position);
          }
        }
      }
    }
  }
}
