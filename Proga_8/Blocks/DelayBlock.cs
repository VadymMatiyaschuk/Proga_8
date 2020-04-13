using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_8.Blocks
{
    public class DelayBlock : BaseBlock
    {
        private Queue<double> Queue { get; set; }
        private int Capacity { get; set; }


        public DelayBlock(double time, double dt)
        {
            Capacity = (int)(time / dt);
            Queue = new Queue<double>(Capacity);
        } 

        public override double Calc(double x)
        {
            Queue.Enqueue(x);

            if (Queue.Count == Capacity)
            {
                return Queue.Dequeue();
            }
            else
            {
                return 0;
            }
        }
    }
}
