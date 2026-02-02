using System;
/*
class Program1{
    public  void Data(){
        unsafe{
        int a=15;
        int *p=&a;
        Console.WriteLine(*p);
    }
    }
    
    public static void Main(){
        Program1 p1= new Program1();
        p1.Data();
    }
}
*/
/*
class Program2{
    unsafe void Modify(int *p){
        *p=50;
    }
    public static void Main(){
        Program2 p2=new Program2();
        unsafe{
            int num=30;
            p2.Modify(&num);
            Console.WriteLine($"Modified value:"+ num);
        }
    }
}
*/
/*
class UnsafeExample
{
    public unsafe void ModifyArray(int[] array)
    {
        fixed (int* ptr = array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                *(ptr + i) *= 2; // Double each element
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };
        UnsafeExample example = new UnsafeExample();
        example.ModifyArray(numbers);

        Console.WriteLine("Modified Array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
*/
class Program{
    public unsafe void getarr(int [] arr)
    {
        fixed(int *p=arr)
        {
          foreach(int a in arr){
            Console.WriteLine(a);
          }
        }

    }
    public static void Main()
    {
        Program3 p3= new Program3();
         int [] num= {2,3,5,6};
         p3.getarr(num);
         
    }
}