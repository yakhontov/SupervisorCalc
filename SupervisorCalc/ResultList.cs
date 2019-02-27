using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisorCalc
{
    public class CalcResult: IComparable<CalcResult>
    {
        public double R1, R2, R3, Error;

        public CalcResult(double r1, double r2, double r3, double error)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
            Error = error;
        }

        public int CompareTo(CalcResult other)
        {
            if (other == null) return 1;
            return Error.CompareTo(other.Error);
        }

        private string RToString(double r)
        {
            if (r < 1000)
                return r.ToString("F"+(3-(int)Math.Log10(r)).ToString()) + "Ohm";
            if(r < 1000000)
                return (r / 1000).ToString("F" + (6 - (int)Math.Log10(r)).ToString()) + "kOhm";
            return (r / 1000000).ToString("F" + (9 - (int)Math.Log10(r)).ToString()) + "MOhm";
        }

        public override string ToString()
        {
            return "Error = " + (Error * 1000).ToString("F2") +
                "mV; R1 = " + RToString(R1) +
                "; R2 = " + RToString(R2) +
                "; R3 = " + RToString(R3);
        }
    }

    public class ResultList: List<CalcResult>
    {
        int MaxResults = 10;
        double MaxError = double.MaxValue;

        public ResultList(int maxResults = 10)
        {
            MaxResults = maxResults;
        }

        public ResultList(ResultList rl, int maxResults = 10)
        {
            AddRange(rl);
            MaxResults = maxResults;
        }

        public void AddResult(CalcResult res)
        {
            if (res.Error > MaxError)
                return;
            Add(res);
            Sort();
            if (Count > MaxResults)
            {
                RemoveAt(Count - 1);
                MaxError = this[Count - 1].Error;
            }
        }

        public void AddResult(double r1, double r2, double r3, double  dV1, double dV2)
        {
            double error = Math.Abs((Math.Abs(dV1) > Math.Abs(dV2)) ? (dV1) : (dV2));
            if (error > MaxError)
                return;
            AddResult(new CalcResult(r1, r2, r3, error));
        }
    }
}
