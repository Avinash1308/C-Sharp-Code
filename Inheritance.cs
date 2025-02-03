using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LearnC_
{
    class Learn
    {

        public string name = "avinash";
        public void details()
        {
            Console.WriteLine("welcome");
        }

    }
    class Info : Learn
    {

    }
    
}


using System;


namespace LearnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //Learn learn = new Learn();
          // Console.WriteLine(learn.name);
           //learn.details();

            

            Info info= new Info();
            info.details();
            Console.WriteLine(info.name);
            Console.ReadLine();

            
        }
    }
}
