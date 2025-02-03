using System;
namespace program{
  class Program{
      public static void Main(String[] args){ 
//Implicit Casting
     int x=5;
     double y= x;

      Console.WriteLine(x);
      Console.WriteLine(y);  
//Explicit Casting
double a=3.5;
int b= (int) a;


      Console.WriteLine(a);
      Console.WriteLine(b);

    }
  }
}

//using default type convertion methods
using System;
namespace program{
  class Program{
      public static void Main(String[] args){ 
        int a=2;
        double b=3.5;
        
        bool val=false;

        Console.WriteLine(Convert.ToString(a));
        Console.WriteLine(Convert.ToDouble(a));
        Console.WriteLine(Convert.ToInt32(b));
        Console.WriteLine(Convert.ToString(val));
        
        
    }
  }
}
