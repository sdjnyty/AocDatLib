using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTY.AocDatLib
{
  public class Technology
  {
    public char[] Name { get; internal set; }
    public List<Effect> Effects { get; internal set; }
  }
}
