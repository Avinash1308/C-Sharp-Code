using System;
using System.Runtime.CompilerServices;


namespace LearnC_
{
   public static class Learn
    {
        public static int LenOfString(this string str)
        {
            return str.Length;
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
            string name = "avinash";
            
            int len = name.LenOfString();
            Console.WriteLine(len);
            

            Console.ReadLine();
        }
    }
}

