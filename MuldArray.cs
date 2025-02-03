using System;
using System.Linq;

namespace LearnC_
{
    class Learn
    {
        public void Learning()
        {

            //Multidimentional array
            int[,] num = { { 1, 2, 3, }, { 4, 5, 6 } };
            Console.WriteLine(num[0,1]);
            num[0,1] = 3;
            Console.WriteLine(num[0,1]);
                
          
        }
    }
}
