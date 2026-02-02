using System;
namespace Arry{
    class ArryExample
    {
        static void Main(string[] args){
        string[] vehicle= new string[]{"RM","NS","BMW","Ninja"};
        Console.WriteLine("The name of vehicles are:");
        
            
        foreach(var a in vehicle)
        {
            Console.WriteLine(a);
        }
    }
}
}