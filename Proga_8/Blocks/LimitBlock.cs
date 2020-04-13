using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class LimitBlock : BaseBlock
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public LimitBlock(double min, double max)
        {
            Min = min;
            Max = max;
        }

        public override double Calc(double x)
        {
            var y = x < Min ? Min : x;

            return y > Max ? Max : y;
        }
    }
}
