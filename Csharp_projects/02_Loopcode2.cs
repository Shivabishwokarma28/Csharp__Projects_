using System;
namespace Project3{
public class Exampleloop{
        int a;
        string na;
        void printdata()
        {
          for(int x=1; x<3;x++)
          {
Console.WriteLine("Enter the id of employee \n");
string z=Console.ReadLine();
a=Convert.ToInt32(z);
Console.WriteLine("Enter the name of employee \n");

na=Console.ReadLine();

          }
        }
          void outt(){
            for(int x=1; x<3;x++)
          {
Console.WriteLine("The id of employee \n"+a);
Console.WriteLine("The name of employee \n"+na);


          }
        }
    static void Main(string[] args)
       {
        Exampleloop p=new Exampleloop();
        p.printdata();
        p.outt();

       } 


}}
