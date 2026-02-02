using System;
namespace Swapping{
    class Swap{
    public static void Main(string[] args)
    {
        int a,b,temp;
        Console.WriteLine("Input the first number:");
        a= int.Parse(Console.ReadLine());
        Console.WriteLine("Input the second number:");
        b=int.Parse(Console.ReadLine());
        
        temp=a;
        a=b;
        b=temp;
        Console.WriteLine("After Swapping");
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);
        Console.ReadLine();

    }

    }

}