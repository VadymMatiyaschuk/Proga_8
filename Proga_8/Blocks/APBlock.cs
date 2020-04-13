using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class APBlock : BaseBlock
    {
        private double Dt { get; set; }
        private double Prev { get; set; }
        private double T { get; set; }
        private LimitBlock Limit { get; set; }

        public APBlock(double dt, double t, double min, double max)
        {
            Limit = new LimitBlock(min, max);

            Prev = 0;
            T = t;
            Dt = dt;
        }

        public override double Calc(double x)
        {
            var y = Limit.Calc((x * Dt + T * Prev) / (T + Dt));
            Prev = y;

            return y;
        }
    }
}
