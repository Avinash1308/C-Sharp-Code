using System;
namespace program{
  class Program{
    public static void Main(String[] args){

      //String type of user input
      Console.WriteLine("Enter Your Name");
      string name = Console.ReadLine();
      Console.WriteLine("Your Name is" + name);

      // int type of user input
      Console.WriteLine("Enter Your Age");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("YOur age is" +age);


    }
  }
}
