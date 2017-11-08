using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class ActionUnit:MovingUnit
  {
    public short DefaultTaskId { get; set; }
    public float SearchRadius { get; set; }
    public float WorkRate { get; set; }
    public short DropSite0 { get; set; }
    public short DropSite1 { get; set; }
    public byte TaskByGroup { get; set; }
    public short CommandSoundId { get; set; }
    public short StopSoundId { get; set; }
    public byte RunPattern { get; set; }
  }
}
