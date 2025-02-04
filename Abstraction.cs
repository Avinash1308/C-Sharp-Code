using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LearnC_
{
    abstract class Learn
    {
        public abstract void voice();
        public void ring() {
            Console.WriteLine("ring ring ring");
        }
      
    }
    class Info : Learn
    {
        public override void voice()
        {
            Console.WriteLine("your voice");
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
           Info info = new Info();
            info.voice();
            info.ring();
     

            
            Console.ReadLine();

            
        }
    }
}



