using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LearnC_
{
    class Learn
    {
        public void cHeck()
        {
           var num= new List<int> {1,2,3,4,5};
           var evennum= num.Where(n => n%2==0).ToList();
            foreach (var n in evennum) {
                Console.WriteLine(n);
            }

        }
    }
}
