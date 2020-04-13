using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proga_8.Blocks;

namespace Proga_8
{
    public class ObjectModel
    {
        private double dt;

        private List<BaseBlock> firstVessel;
        private List<BaseBlock> secondVessel;
        private double firstVesselValue;
        private double secondVesselValue;

        private ComplexBlock pipe1;
        private ComplexBlock pipe2;
        private ComplexBlock pipe3;
        private ComplexBlock pipe4;

        private double valve1;
        private double valve2;
        private double valve3;
        private double valve4;
        private LimitBlock valveLimit;

        public double Time { get; set; }

        public double Valve1 { get { return valve1; } set { valve1 = valveLimit.Calc(value); } }
        public double Valve2 { get { return valve2; } set { valve2 = valveLimit.Calc(value); } }
        public double Valve3 { get { return valve3; } set { valve3 = valveLimit.Calc(value); } }
        public double Valve4 { get { return valve4; } set { valve4 = valveLimit.Calc(value); } }

        public double FirstVesselValue { get { return firstVesselValue; } }
        public double SecondVesselValue { get { return secondVesselValue; } }

        public ObjectModel(double dt)
        {
            this.dt = dt;

            firstVessel = new List<BaseBlock>();
            secondVessel = new List<BaseBlock>();
            pipe1 = new ComplexBlock();
            pipe2 = new ComplexBlock();
            pipe3 = new ComplexBlock();
            pipe4 = new ComplexBlock();
            valveLimit = new LimitBlock(0, 100);

            firstVessel.Add(new APBlock(dt, 30, 0, 150));
            secondVessel.Add(new APBlock(dt, 30, 0, 100));
            pipe1.Blocks.Add(new GainBlock(1));
            pipe2.Blocks.Add(new GainBlock(1));
            pipe3.Blocks.Add(new GainBlock(1));
            pipe3.Blocks.Add(new DelayBlock(1, dt));
            pipe4.Blocks.Add(new GainBlock(1));
            pipe4.Blocks.Add(new DelayBlock(1, dt));

            valve1 = 0;
            valve2 = 0;
            valve3 = 0;
            valve4 = 0;
            Time = 0;
            firstVesselValue = 0;
            secondVesselValue = 0;
        }

        public double GetValue()
        {
            double p1 = pipe1.Calc(valve1);
            double p2 = pipe2.Calc(valve2);
            double p3 = pipe3.Calc(valve3);
            double p4 = pipe4.Calc(valve4);

            double y1 =  p1 + p2 - p3;
            double y2 = p3 - p4;

            foreach(BaseBlock block in firstVessel)
            {
                y1 = block.Calc(y1);
            }
            firstVesselValue = y1;
            
            if((p1 + p2) < p3)
            {
                y2 = p1 + p2 - p4;
            }

            foreach (BaseBlock block in secondVessel)
            {
                y2 = block.Calc(y2);
            }

            secondVesselValue = y2;

            return y2;
        }
    }
}
