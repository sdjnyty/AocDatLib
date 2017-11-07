using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class UnitCommand
  {
    public short CommandUsed { get; set; }
    public short Id { get; set; }
    internal byte _unknown1;
    public short Kind { get; set; }
    public short ClassId { get; set; }
    public short UnitId { get; set; }
    public short TerrainId { get; set; }
    public short Attr1 { get; set; }

    public short Attr2 { get; set; }
    public short Attr3 { get; set; }
    public short Attr4 { get; set; }
    public float WorkValue1 { get; set; }
    public float WorkValue2 { get; set; }
    public float WorkRange { get; set; }
    public byte SearchMode { get; set; }
    public float SearchTime { get; set; }
    public byte CombatLevel { get; set; }
    public byte CombatMode { get; set; }
    public short WorkMode1 { get; set; }
    public short WorkMode2 { get; set; }
    public byte OwnerKind { get; set; }
    public byte HoldingMode { get; set; }
    public byte StateBuild { get; set; }
    public short MoveSpriteId { get; set; }
    public short WorkSpriteId1 { get; set; }
    public short WorkSpriteId2 { get; set; }
    public short CarrySpriteId { get; set; }
    public short WorkSoundId1 { get; set; }
    public short WorkSoundId2 { get; set; }
  }
}
