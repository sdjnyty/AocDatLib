using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace YTY.AocDatLib
{
  public class DatFile
  {
    private char[] _version;

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
          }
        }
      }
    }
  }
}
