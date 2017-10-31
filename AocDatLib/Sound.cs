using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class Sound
  {
    public short Id { get; set; }

    public short PlayAtUpdateCount { get; set; }

    public int CacheTime { get; set; }

    public List<SoundItem> Items { get; internal set; }
  }
}
