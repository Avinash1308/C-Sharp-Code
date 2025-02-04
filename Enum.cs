using System;


namespace LearnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number num = number.four;
            Console.WriteLine(num);

            int no = (int) number.two;
            Console.WriteLine(no);

            
            Console.ReadLine();
            
        }
        enum number
        {
            one,
            two, three, four, five, six
        }
    }
}
