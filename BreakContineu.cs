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
            //Break statement 
            for (int i = 0; i < 10; i++) {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            // Continue statement
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }



        }
    }
}
