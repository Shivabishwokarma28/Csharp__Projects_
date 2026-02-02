
using System;
using System.Runtime.CompilerServices;
namespace Project4
{
    class Student{
        int id;
        
        string name;
       

         void getdata()
         {
            Console.WriteLine("Enter the id");
            String num = Console.ReadLine();
            id = Convert.ToInt32(num);
            Console.WriteLine("Enter the name ");
            name = Console.ReadLine();
         }
         void print()
         {
            Console.WriteLine("The name of the student is"+name);
            Console.WriteLine("The id of the student is"+id);
         }
         
         static void Main(string[] args)

         {
          Student S1= new Student();
          Marks M1= new Marks();
          S1.getdata();
          S1.print();
          M1.printt();
          Calculation c1= new Calculation();
          c1.dataprint();
          c1.loop();
         }
    }
    public class Marks{
int a;
public void printt()
{
   Console.WriteLine("Enter the marks of student");
string b=Console.ReadLine();
int a= Convert.ToInt32(b);
Console.WriteLine("The marks of student is:"+a);
if(a>=40){
   Console.WriteLine("The student is pass");
}
else{
   Console.WriteLine("You are fail");
}
}
       
}
public class Calculation{
int x,y,c;
int n;
public void dataprint()
{
   Console.WriteLine("Enter the first number:");
   string z= Console.ReadLine();
   x = Convert.ToInt32(z);
   Console.WriteLine("Enter the second number:");
   string ze= Console.ReadLine();
   y=Convert.ToInt32(ze);

}
public void add(){
   c=x+y;
   Console.WriteLine(c);
}
public void sub()
{
   c=x-y;
   Console.WriteLine(c);
}
public void div(){
   c=x/y;
   Console.WriteLine(c);
}
public void mul(){
   c=x*y;
   Console.WriteLine(c);
}
public void loop()
{
Console.WriteLine("If you want to sum:Enter 1 \n If you want to Subctract:Enter 2 \n If you want to divide:Enter 3 \n If you want to Multiply:Enter 4 \n");
string zee= Console.ReadLine();
   n = Convert.ToInt32(zee);
if(n==1)
{
   add();
}
if(n==2)
{
   sub();
}
if(n==3)
{
   div();
}
if(n==4)
{
   mul();
}
}
}}
