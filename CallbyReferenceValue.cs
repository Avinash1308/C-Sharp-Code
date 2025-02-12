using System;


namespace LearnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 5;
            Learn learn = new Learn();

            learn.method1(val); // 25 call by value
            Console.WriteLine("value after method1 call" + val); //5
            learn.method2(ref val);//25  call by reference
            Console.WriteLine("value after method2 call" + val);//25



            Console.ReadLine();
        }
    }
}






namespace LearnC_
{
   public class Learn
    {
        public void method1(int a) 
        {
            a *= a;
            Console.WriteLine("Method1 value"+ a);
        }

        public void method2(ref int a) {
            a*=a; 
            Console.WriteLine("Method2 value"+ a);
        }

    }
}

