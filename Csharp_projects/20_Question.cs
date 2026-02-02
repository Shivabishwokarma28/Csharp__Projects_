/* A fuel tank has a maximum capacity of 50 liters. Fuel is added in increments of 5 liter per seconds
WAP using a while loop to fill the tank
Print the fuel level after each addition
Stop when the tank is full*/
using System;
namespace FuelTank{
    /*
    class Tank{
        int []arr=new int[50];
        int i=0;
        int s=0;
        void getdata(){
            while(i<arr.Length){
Console.WriteLine("The fuel Level after:"+(i+1)+ " second is: "+ (s=s+5));
i++;
if(s==50){
    Console.WriteLine("The tank is full of its capacity");
    break;

}

            }


        }
        public static void Main(string[] args){
            Tank F1= new Tank();
            F1.getdata();

        }
    }*/
    /** Digital banking pin validation(do-while loop) WAP that asks a user to enter 4-digit ATM PIN
    Allow 3 attemps for the users to enter PIN
    if they enter it wrong 3 times, print"Account Locked" otherwise print "Access granted"
    use a do-while loop
    */ /*
    class UserPin{
//int [] ar1= new int[9999];
int i=1;
int pass=2354;
int s;
void getdata(){
    do{
        Console.WriteLine("Enter the 4-digit pin");
int s= Convert.ToInt32(Console.ReadLine());
if(s==pass){
    Console.WriteLine("Access granted");
}
else {
Console.WriteLine("You are allow to attemp for 3 times");
for(int k=1;k<50;k++)
{
    Console.WriteLine("Your"+k+"attempt"); 
    s=Convert.ToInt32(Console.ReadLine());
    if(k==3){
        Console.WriteLine("Account Lock");
break;
    }
}
}
break;
    }while(i<100);
}
        public static void Main(String[] args){
UserPin UP=new UserPin();

UP.getdata();
        }
    }*/
//Chess Board colour Design pattern
    class ChessBoard{
char temp;
char a='B';
char b='W';
void getdata(){
    for(int i =1;i<=8; i++){
        for(int j=1;j<=8;j++)
        {
            
            Console.Write(a+""+b);
        }
        temp=a;
            a=b;
            b=temp;
        Console.WriteLine("\n");
    }


}
        public static void Main(string[] args){
            ChessBoard C1= new ChessBoard();
            C1.getdata();
        }
    }
}

