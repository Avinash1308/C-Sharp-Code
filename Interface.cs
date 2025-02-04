using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LearnC_
{
   interface Ilearn
    {
        String Info(String name);
    }
    public class Learn : Ilearn
    {
        public String Info(string name) { return name; }
    }

    
    
}

using System;


namespace LearnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

          Learn learn = new Learn();
            String result = learn.Info("Avinash");
            Console.WriteLine(result);
     

            
            Console.ReadLine();

            
        }
    }
}

