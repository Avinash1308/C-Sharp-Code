//try/catch

using System;
class Program{
    public static void Main(string[] args){
        try{
            int a=10;
            int b=0;
            int c=a/b;
            }
        catch(Exception e){Console.WriteLine(e); }

        Console.WriteLine("Rest of the code");

    }
}



using System;
class Program{
    public static void Main(string[] args){
        try{
            int a=10;
            int b=0;
            int c=a/b;
            }
        catch(Exception e){Console.WriteLine(e); }
        finally{
            System.Console.WriteLine();
        }

        Console.WriteLine("Rest of the code");

    }
}


