using System;
using System.Linq;

namespace LearnC_
{
    class Learn
    {
        public void Learning()
        {
            
            //array sorting
            string[] cars = { "volvo", "mercedes", "bmwwwweeewwe" };
            Array.Sort(cars);
            foreach (string car in cars) { 
            Console.WriteLine(car);
            }
            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
            Console.WriteLine(cars.Min());
        }
    }
}

