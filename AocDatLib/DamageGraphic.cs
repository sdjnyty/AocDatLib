using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class DamageGraphic
  {
    public short GraphicId { get; set; }
    public byte DamagePercent { get; set; }
    public byte OldApplyMode { get; set; }
    public byte ApplyMode { get; set; }
  }
}
