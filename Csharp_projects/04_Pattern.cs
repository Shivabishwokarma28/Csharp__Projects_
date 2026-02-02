using System;
using System.Globalization;
namespace Patterns
{

class Pattern2{
public static void Main(string [] args)
{
    int a=1;
    for(int r=1;r<=5;r++)
    {
      for(int s=5;s>=r;s--){
        Console.Write(" ");
      }
      for(int p=1;p<=a;p++){
        Console.Write("*");
      }
      a+=2;
      Console.WriteLine("");
    }
    //Console.ReadLine();
    int b=7;
    
    for(int r=1; r<=4;r++){
        for(int s=0;s<=r;s++){
            Console.Write(" ");
        }
        for(int p=1;p<=b;p++)
        
        {
            Console.Write("*");
        }
        b-=2;
        Console.WriteLine("");
    }
    Console.ReadLine();
    
}
}
}