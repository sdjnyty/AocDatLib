using System.IO;

namespace YTY.AocDatLib
{
  public class Research
  {
    public short RequiredTech1 { get; set; }
    public short RequiredTech2 { get; set; }
    public short RequiredTech3 { get; set; }
    public short RequiredTech4 { get; set; }
    public short RequiredTech5 { get; set; }
    public short RequiredTech6 { get; set; }
    public short Cost1Type { get; set; }
    public short Cost1Amount { get; set; }
    public short Cost1Flag { get; set; }
    public short Cost2Type { get; set; }
    public short Cost2Amount { get; set; }
    public short Cost2Flag { get; set; }
    public short Cost3Type { get; set; }
    public short Cost3Amount { get; set; }
    public short Cost3Flag { get; set; }
    public short RequiredTechCount { get; set; }
    public short Civilization { get; set; }
    public short FullTechMode { get; set; }
    public short ResearchLocation { get; set; }
    public ushort LanguageDllName { get; set; }
    public ushort LanguageDllDescription { get; set; }
    public short ResearchTime { get; set; }
    public short EffectId { get; set; }
    public short Type { get; set; }
    public short IconId { get; set; }
    public byte ButtonId { get; set; }
    public int LanguageDllHelp { get; set; }
    public int LanguageDllTechTree { get; set; }
    public int HotKey { get; set; }
    public byte[] Name { get; set; }

    protected internal void BinaryReaderRead(BinaryReader br)
    {
      RequiredTech1 = br.ReadInt16();
      RequiredTech2 = br.ReadInt16();
      RequiredTech3 = br.ReadInt16();
      RequiredTech4 = br.ReadInt16();
      RequiredTech5 = br.ReadInt16();
      RequiredTech6 = br.ReadInt16();
      Cost1Type = br.ReadInt16();
      Cost1Amount = br.ReadInt16();
      Cost1Flag = br.ReadByte();
      Cost2Type = br.ReadInt16();
      Cost2Amount = br.ReadInt16();
      Cost2Flag = br.ReadByte();
      Cost3Type = br.ReadInt16();
      Cost3Amount = br.ReadInt16();
      Cost3Flag = br.ReadByte();
      RequiredTechCount = br.ReadInt16();
      Civilization = br.ReadInt16();
      FullTechMode = br.ReadInt16();
      ResearchLocation = br.ReadInt16();
      LanguageDllName = br.ReadUInt16();
      LanguageDllDescription = br.ReadUInt16();
      ResearchTime = br.ReadInt16();
      EffectId = br.ReadInt16();
      Type = br.ReadInt16();
      IconId = br.ReadInt16();
      ButtonId = br.ReadByte();
      LanguageDllHelp = br.ReadInt32();
      LanguageDllTechTree = br.ReadInt32();
      HotKey = br.ReadInt32();
      Name = br.ReadBytes(br.ReadUInt16());
    }

  }
}
