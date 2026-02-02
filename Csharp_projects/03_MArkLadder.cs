using System;
namespace Controlstatements{
  public class Conditionals{
    public static void Main(){
      int a;
      Console.WriteLine("Enter Your mark:");
      a=Convert.ToInt32(Console.ReadLine());
       
        if(a<40 && a>=60){
        Console.WriteLine("c");
       }
       else if(a<60 && a>=50){
        Console.WriteLine("c+");
       }
        else if(a<70 && a>=60){
        Console.WriteLine("B");
       }else if(a<80 && a>=70){
        Console.WriteLine("B+");
       }else if(a<90 && a>=80){
        Console.WriteLine("A");
       }
       else if(a<=100 && a>=90){
        Console.WriteLine("A+");
       }
        else{
          Console.WriteLine("fail");

  }
      }
}
}
      
    

