
//Short Hand ifelse also known as ternary operator
using System;
namespace Program{
  class Prog{
    public static void main(String[] args){
      int age=23;
      string result= (age<18) ? "Not eligible for voting " : "Eligible for voting" ;
      Console.WriteLine(result);
    }
  }
}
