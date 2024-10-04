public class Program{
  public static void Main(String[] args){
    int [] number = {1,2,3,4,5,6,7,8,9};
    var num = number.Where(i=>i >2 );
    foreach( var x in num){
      Console.WriteLine(x);
    }
  }
}
