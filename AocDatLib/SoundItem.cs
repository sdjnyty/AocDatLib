using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class SoundItem
  {
    public byte[] FileName { get; set; }

    public int Id { get; set; }

    public short Probability { get; set; }

    public short Civilization { get; set; }

    public short PlayerId { get; set; }
  }
}
