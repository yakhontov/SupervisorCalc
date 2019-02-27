using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SupervisorCalc
{

    class Calculations
    {
        public double MinU, MaxU, MinI, MaxI;

        static bool CalcVolt(bool posVolt, double R1, double R2, double R3, out double minU, out double maxU)
        {
            if (double.IsNaN(R1) || double.IsNaN(R2) || double.IsNaN(R3))
            {
                minU = double.NaN;
                maxU = double.NaN;
                return false;
            }

            double R = R1 + R2 + R3;

            if (posVolt)
            {
                double I3, I23;
                I3 = 0.5 / R3;
                maxU = I3 * R;
                I23 = 0.5 / (R2 + R3);
                minU = I23 * R;
            }
            else
            {
                double I1, I12;
                I1 = 0.5 / R1;
                maxU = 1 - I1 * R;
                I12 = 0.5 / (R1 + R2);
                minU = 1 - I1 * R;
            }

            return true;
        }

        public ResultList Results = new ResultList();
        public ResistorSeries Resistors;

        public Calculations(ResistorSeries resistors)
        {
            Resistors = resistors;
        }

        public void CalcResistors(double minU, double maxU, double minI, double maxI, double maxErr)
        {
            //Thread t = new Thread(ThreadCalcResistors);
            //t.Start(new ThreadParameters(minU, maxU, minI, maxI, maxErr, resistorsList, ResultsList));

        }

        /*
        private void ThreadCalcResistors(object threadParams)
        {
            ThreadParameters tp = (ThreadParameters)threadParams;
            for(int i = 0; i<100; i++)
                tp.Results.AddResult(new CalcResult(100,200,300,400));
        }
        */
    }

}
