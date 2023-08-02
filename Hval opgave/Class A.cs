using System;

namespace Hval_opgave
{
    internal class Class_A
    {
        Program test1 = new Program();

        public void convertknob()
        {
            Class_B bInput = new Class_B();

            double knobs = Convert.ToDouble(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine($"Knobs to km/t:{bInput.KnobsToKm(knobs)} km/t");
            Console.ReadKey();
        }
        public void convertkm()
        {
            Class_B bInput = new Class_B();

            
            double km = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Km/t to Knobs:{bInput.KmToKnobs(km)} knobs");
            Console.ReadKey();
        }

    }
}
