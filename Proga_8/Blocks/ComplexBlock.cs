using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class ComplexBlock : BaseBlock
    {
        public List<BaseBlock> Blocks { get; set; }

        public ComplexBlock()
        {
            Blocks = new List<BaseBlock>();
        }

        public override double Calc(double x)
        {
            foreach(BaseBlock Block in Blocks)
            {
                x = Block.Calc(x);
            }

            return x;
        }
    }
}
