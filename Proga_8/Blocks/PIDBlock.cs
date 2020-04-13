using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proga_8.Blocks;

namespace Proga_8.Blocks
{
    public class PIDBlock : BaseBlock
    {
        public double Td { get; set; }
        public double Ti { get; set; }
        public double K { get; set; }
        
        public bool IsManual { get; set; }

        public GainBlock gainBlock;
        public IntegroBlock integroBlock;
        public DiffBlock diffBlock;

        private APBlock kDamper;
        private APBlock tiDamper;
        private APBlock tdDamper;

        public PIDBlock(double dt, double td, double ti, double k)
        {
            gainBlock = new GainBlock(k);
            integroBlock = new IntegroBlock(dt, ti, 0, 100);
            diffBlock = new DiffBlock(dt, td);

            kDamper = new APBlock(dt, 3, 0, 100);
            tiDamper = new APBlock(dt, 3, 0, 100);
            tdDamper = new APBlock(dt, 3, 0, 100);

            Td = td;
            Ti = ti;
            K = k;
        }

        public override double Calc(double x)
        {
            gainBlock.Gain = kDamper.Calc(K);
            diffBlock.T = Td;
            integroBlock.Ti = tiDamper.Calc(Ti);

            return gainBlock.Calc(x + integroBlock.Calc(x) + diffBlock.Calc(x));
        }
    }
}
