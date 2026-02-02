using System;

namespace Array{ 
/*public class ArrayExample  
{  
    public static void Main(string[] args)  
    {  
        int[] arr = new int[5];//creating array  
        arr[0] = 10;//initializing array  
        arr[2] = 20;  
        arr[4] = 30;  
  
        //traversing array  
        for (int i = 0; i < arr.Length; i++)  
        {  
            Console.WriteLine(arr[i]);  
        }  
    } */ 
    /*class Arrayex2{
        public static void Main(string[] args){
            int[] a=new int[7];
            
            Console.WriteLine("For the element of array");
            Console.WriteLine("Input seven elements of array:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("For the output");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);

            }
        }*/

       /* class Arrayex3{

            public static void DisplayArray(String[] arr)=> Console.WriteLine(string.Join(" ",arr));
              
        public static void Main(){
            string[] week={"Sun","Mon","Tue","Wed","Thu","fri","Saturday"};
            DisplayArray(week);
            Console.WriteLine();*/
    /*class Array4{
        public static void Main(string[] args){
            int [,] arr= new int[2,2];
            int[,] arr2= new int[2,2];
            int[,] arr3= new int[2,2];
            int[,] arr4= new int[2,2];
            
            int i,j,k;
            Console.WriteLine("Second dimentional array");
            Console.WriteLine("First Matrix:");
            for(i=0;i<arr.GetLength(0);i++)
            {
                for(j=0;j<arr.GetLength(1);j++){
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());
            
                }
                Console.Write("");
         
           }

           Console.WriteLine("Print:");
           for(i=0;i<arr.GetLength(0);i++)
            {
                for(j=0;j<arr.GetLength(1);j++)
                {
                   Console.Write("\t"+arr[i,j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("second matrix");
            for(i=0;i<arr2.GetLength(0);i++)
            {
                for(j=0;j<arr2.GetLength(1);j++)
                {
                    arr2[i,j]=Convert.ToInt32(Console.ReadLine());
            
                }
                Console.Write("");
           }

           Console.WriteLine("Print:");
           for(i=0;i<arr2.GetLength(0);i++)
            {
                for(j=0;j<arr2.GetLength(1);j++){
                   Console.Write("\t"+arr2[i,j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("For array addition");
            for(i=0;i<2;i++)
            {
                for(j=0;j<2;j++)
            {
                arr3[i,j]=arr[i,j]+arr2[i,j];
                

            }
            Console.Write("");
            }

            for(i=0;i<2;i++)
            {
                Console.Write("\n");
                for(j=0;j<2;j++)
                {
                    Console.Write("\t"+arr3[i,j]);
                }
                Console.WriteLine("");

            }
            Console.WriteLine("For matrix multiplication");
            for(i=0;i<2;i++){
                for(j=0;j<2;j++){
                    int sum=0;
                    for(k=0;k<2;k++){
                        
                        sum=sum + arr[i,k] * arr2[k,j];
                        
                    }
                    arr4[i,j]=sum;
                }
                Console.WriteLine("");
            }
            for(i=0;i<2;i++){
                for(j=0;j<2;j++){
                    
            Console.Write("\t"+arr4[i,j]);
                    
                }
                Console.WriteLine("");
            }
            
       }}*/
       //WAP to take input from user for a jagged array with 3 row of varying length and print the elements.
class Arrayex4{
    public static void Main(string[] args){
        //For 3 Array
        int [][] arr5= new int[3][];
    //Getting input 
    for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter the number of elements for row " + (i+1) + ": ");
            int num = int.Parse(Console.ReadLine()); // Length of current row
 
            arr5[i] = new int[num];

            Console.WriteLine("Enter " + num + " elements for row " + (i+1) + ":");
            for (int j = 0; j < num; j++)
            {
          arr5[i][j] = int.Parse(Console.ReadLine());
            }
    }
    for(int i=0; i<3;i++)
    {
         Console.Write("\t For"+(i+1)+"\t"+"Row:");
        for(int j=0;j<arr5[i].Length;j++)
        {
           
            Console.Write("\t"+arr5[i][j]);
        }
        Console.WriteLine("");
    }

}
}}