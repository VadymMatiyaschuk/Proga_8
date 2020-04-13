using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class NoiseBlock : BaseBlock
    {
        private double Noise { get; set; }

        public NoiseBlock(double noise)
        {
            Noise = noise;
        }

        public override double Calc(double x)
        {
            Random random = new Random();
            var nn = x * Noise / 100;

            return x + nn * random.NextDouble() - nn / 2;
        }
    }
}
