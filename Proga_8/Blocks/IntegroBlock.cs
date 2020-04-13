using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class IntegroBlock : BaseBlock
    {
        private double Dt { get; set; }

        private double Min { get; set; }
        private double Max { get; set; }      

        public double Ti { get; set; }
        public double Sum { get; set; }
        public double Prev { get; set; }

        public IntegroBlock(double dt, double ti, double min, double max)
        {
            Min = min;
            Max = max;

            Ti = ti;
            Prev = 0;
            Sum = 0;

            Dt = dt;
        }

        public override double Calc(double x)
        {
            Sum += Ti * (x + Prev) * Dt / 2;

            if (Sum < Min) {
                Sum = Min;
            } else if (Sum > Max) {
                Sum = Max;
            }

            Prev = x;

            return Sum;
        }
    }
}
