sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC_
{
    class Learn
    {
        public void Learning()
        {
          //for loop
            string[] cars = { "volvo", "mercedes", "bmw" };
            for (int i = 0; i < cars.Length; i++) { 
                Console.WriteLine(cars[i]);
            };
//foreach loop
            String[] names = { "Avinash","Aakash","Rohit"};
            foreach (string name in names) { Console.WriteLine(name); };


        }
    }
}
