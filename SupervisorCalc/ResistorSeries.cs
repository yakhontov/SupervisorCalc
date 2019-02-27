using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SupervisorCalc
{
    class ResistorSeries: List<double>
    {

        public ResistorSeries() { }

        public ResistorSeries(ResistorSeries r)
        {
            AddRange(r);
        }

        public ResistorSeries(string s)
        {
            Fill(s);
        }

        public void Fill(string s)
        {
            double R;
            Clear();
            string[] resistors = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach(string resistor in resistors)
            {
                int i = resistor.LastIndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' });
                if (i < 0 ||
                    !double.TryParse(resistor.Substring(0, i + 1), NumberStyles.Any, CultureInfo.InvariantCulture, out R) ||
                    R == 0)
                    continue;

                if (resistor.Contains("k"))
                    R *= 1000;
                else
                    if (resistor.Contains("M"))
                        R *= 1000000;
                Add(R);
            }
            Sort();
        }

        public int FindLowerId(double r)
        {
            int i = BinarySearch(r);
            if (i < 0)
                return ~i - 1;
            else
                return i;
        }

        public int FindGreaterId(double r)
        {
            int i = BinarySearch(r);
            if (i < 0)
                return ~i;
            else
                return i;
        }

        public double FindLowerR(double r) { return this[FindLowerId(r)]; }

        public double FindGreaterR(double r) { return this[FindGreaterId(r)]; }
    }

    class ThreadParameters
    {
        public double MinU, MaxU, MinI, MaxI, MaxErr;
        public ResistorSeries Resistors;
        public ResultList Results;

        public ThreadParameters(string serie)
        {
            Results = new ResultList();
            Resistors = new ResistorSeries(serie);
        }

        public ThreadParameters(
            double minU,
            double maxU,
            double minI,
            double maxI,
            double maxErr,
            ResistorSeries resistors,
            ResultList results)
        {
            MinU = minU;
            MaxU = maxU;
            MinI = minI;
            MaxI = maxI;
            MaxErr = maxErr;
            Results = results;
            Resistors = new ResistorSeries(resistors);
        }
    }
}