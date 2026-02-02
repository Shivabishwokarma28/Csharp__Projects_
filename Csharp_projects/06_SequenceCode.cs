using System;
namespace Sequence
{
class SequenceEX{
//0 1 1 2 3 5 8 13 21
    public static void Main()
    {
        int a=0;
        int b=1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for(int i=2;i<=8;i++){
            int c=a+b;
            Console.WriteLine(c);
            a=b;
            b=c;

        }

        }

    }
}