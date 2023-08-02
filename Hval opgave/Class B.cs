using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hval_opgave
{
    internal class Class_B
    {

        public Class_B()
        { }
        public double KnobsToKm(double knobs)
        {
            return knobs * 1.85;
        }
        public double KmToKnobs(double km)
        {
            return km / 1.85;
        }
    }
}
