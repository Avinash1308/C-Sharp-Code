using System;
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
            int num = 10;
            for (int i = 1; i <= num; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            //foreach loop
            int[] arr= { 1, 2, 3, 4, 5 };
            foreach(int i in arr)
            {

            Console.WriteLine(i); } }
        }
    }

