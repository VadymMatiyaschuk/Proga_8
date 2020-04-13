using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proga_8.Blocks;

namespace Proga_8
{
    public class ControlSystem
    {
        public ObjectModel objectModel;
        private PIDBlock PID;
        private double dt;
        private double setpoint;
        private LimitBlock setpointLimit;
        private APBlock setpointDamper;

        public double Time { get; set; }
        public double K { get { return PID.K; } set { PID.K = value; } }
        public double Ti { get { return PID.Ti; } set { PID.Ti = value; } }
        public double Td { get { return PID.Td; } set { PID.Td = value; } }
        public bool IsManual { get; set; }

        public double Setpoint { get { return setpoint; } set { setpoint = setpointLimit.Calc(value); } }

        public ControlSystem(double dt)
        {
            this.dt = dt;
            objectModel = new ObjectModel(dt);
            PID = new PIDBlock(dt, 0, 0.05, 1.8);
            IsManual = false;
            setpointLimit = new LimitBlock(0, 100);
            setpointDamper = new APBlock(dt, 3, 0, 100);
        }

        public double GetValue()
        {
            var e = setpointDamper.Calc(setpoint) - objectModel.SecondVesselValue;
            double u;

            if (!IsManual)
            {
                u = PID.Calc(e);
                objectModel.Valve3 = u;
            }
            else
            {
                PID.integroBlock.Sum = (objectModel.Valve3 / PID.gainBlock.Gain) - (e + PID.diffBlock.Calc(e));
                PID.integroBlock.Prev = e;
                u = PID.gainBlock.Calc(e + PID.integroBlock.Sum + PID.diffBlock.Calc(e));
            }

            Time += dt;

            return objectModel.GetValue();
        }
    }
}
