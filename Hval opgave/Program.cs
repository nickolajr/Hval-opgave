using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hval_opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class_A Convert = new Class_A();
            Console.WriteLine("how many km/t do you wanna convert to knob");         
            Convert.convertkm();
            
            Console.WriteLine("how many knobs do you wanna convert to km/t");           
            Convert.convertknob();
            
        }
    }
}
