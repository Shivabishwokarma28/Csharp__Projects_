using System;
using System.Security.Cryptography;
/*
struct Point{
    public int X;
    public int Y;
    public Point(int a,int b){
        X=a;
        Y=b;

    }
    public void Display(){
        Console.WriteLine($"X:{X} and Y :{Y}");
    }
}
class Program1{
   
    public static void Main(){
         Point p1=new Point(5,6);
    p1.Display();
    }
}*/
using System;
namespace ConsoleApplication {

// Defining structure
public struct Person
{
	// Declaring different data types
	public string Name;
	public int Age;
	public int Weight;

}

class StructureExample {
	
	// Main Method
	static void Main(string[] args)
	{

		// Declare P1 of type Person
		Person P1;

		// P1's data
		P1.Name = "Keshav Gupta";
		P1.Age = 21;
		P1.Weight = 80;

		// Displaying the values 
		Console.WriteLine("Data Stored in P1 is " + 
						P1.Name + ", age is " + 
						P1.Age + " and weight is " + 
						P1.Weight);

	}
}
}
