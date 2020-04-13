using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class DiffBlock : BaseBlock
    {
        private double Prev { get; set; }
        private double Dt { get; set; }

        public double T { get; set; }

        public DiffBlock(double dt, double t)
        {
            Prev = 0;
            T = t;
            Dt = dt;
        }

        public override double Calc(double x)
        {
            double y = T * (x - Prev) / Dt;
            Prev = x;

            return y;
        }
    }
}
