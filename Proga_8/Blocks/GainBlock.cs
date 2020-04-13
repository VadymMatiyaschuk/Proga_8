using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class GainBlock : BaseBlock
    {
        public double Gain { get; set; }

        public GainBlock(double gain)
        {
            Gain = gain;
        }

        public override double Calc(double x)
        {
            return Gain * x;
        }
    }
}
