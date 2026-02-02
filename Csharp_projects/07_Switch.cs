using System;
    namespace Project2
    {
        class SwitchExample{

        int a,b;
        int d;
        
        void getdata()
        {
            Console.WriteLine("enter the first number");
          string f =Console.ReadLine();
          a=Convert.ToInt32(f);
           Console.WriteLine("enter the second number");
          string g =Console.ReadLine();
          a=Convert.ToInt32(g);

        }
        void add(){
            d=a+b;
            Console.WriteLine("The addition to two number is:"+d);

        }
        void sub(){
            d=a-b;
            Console.WriteLine("The substraction to two number is:"+d);

        }
        void div(){
            d= a/b;
            Console.WriteLine("The division to two number is:"+d);

        }
        void mul(){
            d= a*b;
            Console.WriteLine("The multiplication to two number is:"+d);

        }

        static void Main(string[] args)
        {
int c=4;
SwitchExample s1= new SwitchExample();
s1.getdata();
          Console.WriteLine("Enter 1 for sum:\n Enter 2 for substraction: \n Enter 3 for divid: \n Enter 4 for multiplication");
        
        {
         
        switch(c){
            case 1:   s1.add();
            break;
            case 2: s1.sub();
            break;
            case 3: s1.div();
            break;
            case 4: s1.mul();
            break;
            
        }
        }

        }
    }
}
