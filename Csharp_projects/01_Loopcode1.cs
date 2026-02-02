using System;
public class Angle{
    public static void Main(string[]args){
    /*int i, j, k;
    Console.WriteLine("enter a number of row");
    k=Convert.ToInt32(Console.ReadLine());
    for(i=1; i<=k; i++){
        for(j=1; j<=i; j++){
Console.Write("*");

        }
        Console.Write("\n");
    }*/
    int x;
    int i, sum=0;
    float avg=0;
    Console.WriteLine("enter 10 number");
    for(i=0; i<=10; i++){
        x=Convert.ToInt32(Console.ReadLine);
        sum=sum+x;
    }
    Console.WriteLine("The sum of 10 number is:"+sum);
}
}

