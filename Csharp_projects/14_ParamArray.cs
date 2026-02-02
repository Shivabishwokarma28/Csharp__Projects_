using System;
class Program{
    static void Main(string[] args)
    { int[] arr={20,21,22,6,2};
   
    
        DisplayEvensum(arr);
    }
    static void DisplayEvensum(params int[] numb){
        if(numb.Length==0){
            Console.WriteLine("No nimbers provided");
            return;

        }
        int sum=0;
        foreach(int a in numb)
        {
            if(a%2==0){
                sum+=a;
            }
            

        }
        Console.WriteLine("The sum of even number is"+sum);

    }
}