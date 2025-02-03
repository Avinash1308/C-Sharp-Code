using System;
using System.Linq;

namespace LearnC_
{
    class Learn
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}

//program class to call object of Learn class
using System;


namespace LearnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Learn learn = new Learn();
            learn.Name = "Avinash";
            Console.WriteLine(learn.Name);

            Console.ReadLine();
            
        }
    }
}



//Short Hand property

using System;
using System.Linq;

namespace LearnC_
{
    class Learn
    {
       
        public string Name
        {
            get;
            set;
        }

    }
}
