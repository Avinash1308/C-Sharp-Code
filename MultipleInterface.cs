using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LearnC_
{
   interface Ilearn //interface1
    {
        String Info(String name);
    }
    interface Ilearn2 //interface2
    {
        String Info2(String name);
    }
    public class Learn : Ilearn, Ilearn2
    {
        public String Info(string name) { return name; } //interface1 method
        public String Info2(String name) { return name; } // interface2 method
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
            string result2 = learn.Info2("Kedar");
            Console.WriteLine(result);
            Console.WriteLine(result2);
     

            
            Console.ReadLine();
            
        }
    }
}
