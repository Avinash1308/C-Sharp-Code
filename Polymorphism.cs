using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LearnC_
{
    class Learn
    {

      
        public void details()
        {
            Console.WriteLine("welcome");
        }

    }
    class Info : Learn
    {
        public void details()
        {
            Console.WriteLine("welcome To info");
        }
    }
    class Knowledge : Learn {
        public void details()
        {
            Console.WriteLine("welcome To knowledge");
        }
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

            Learn learn = new Learn();
            Info info = new Info();
            Knowledge knowledge = new Knowledge();
            learn.details();
            info.details();
            knowledge.details();

            
            Console.ReadLine();

            
        }
    }
}
