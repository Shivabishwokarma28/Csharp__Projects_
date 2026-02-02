using System;
class PointVal{
    unsafe static void Get(int *p)
    {
int a=*p;
Console.WriteLine("The value is:"+a);
    }
    public static void Main(){
        PointVal p1= new PointVal();
        unsafe{
            int a=50;
            PointVal.Get(&a);
        }
    }

}