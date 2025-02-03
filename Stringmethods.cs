using System;
namespace Program{
  class Program{
    public static void Main(String[] args){
        //String fname="Avinash";
        //String lname = "Kedar";
        String fullname="Avinash Kedar";

        // indexof
        int space=fullname.IndexOf(" ");
        Console.WriteLine(space);

        //substring
        String lname=fullname.Substring(space+1);
        Console.WriteLine(lname);

        //concat
        Console.WriteLine(String.Concat("avi","raje"));
    }
  }
}
