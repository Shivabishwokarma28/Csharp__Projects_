using System; 
/*
class Programst
{
string str="Monkey D Luffy";
void getdata(){
    Console.WriteLine("The Length of the str:\t"+ str.Length);
    Console.WriteLine("For the upper case\t"+str.ToUpper());
    
    Console.WriteLine("For Lower Case\t"+str.ToLower());
    str.ToLower();

    Console.WriteLine("Substring form 1 to 5\t"+  str.Substring(1,5));
  
   
    Console.WriteLine("The indext of D is\t"+ str.IndexOf("D"));
   
     
    Console.WriteLine("For replace \t"+ str.Replace("Monkey D Luffy","Eren"));
   

    Console.WriteLine("To trim the str \t"+ "Monkey D Luffy".Trim());
   

}
public static void Main(string [] args)
{
    Programst pr= new Programst();
    pr.getdata();
}
}*/
/*
class Concatt{
    string FName="Joseph";
    string LName="Hanada";
    void data1(){
        Console.WriteLine("Using + operator");
         Console.WriteLine(FName +""+LName);
          Console.WriteLine("Using String.Concat");
          string a= String.Concat(FName,"",LName);
           Console.WriteLine(a);
            Console.WriteLine("Using StringInterpolation");
             Console.WriteLine($"{FName}{LName}");
    }
    void data2(){
        string str1="HELLO";
        string str2="Hello";
         Console.WriteLine("For comparison");
          Console.WriteLine("Using == operator");
          bool C=str1==str2;
           Console.WriteLine(C);
            Console.WriteLine("Using Equals() method");
            bool d= str1.Equals(str2);
             Console.WriteLine(d);
             Console.WriteLine("Using StringComparison.OrdinalIgnoreCase");
             bool e= str1.Equals(str2,StringComparison.OrdinalIgnoreCase);
              Console.WriteLine(e);
              Console.WriteLine("Using Compare() method");
              int res=String.Compare(str1,str2,StringComparison.OrdinalIgnoreCase);
               Console.WriteLine(res);
    }
    public static void Main(){
        Concatt C1=new Concatt();
        C1.data1();
        C1.data2();
    }
}
*/
/*
class Program3{
    string st="Hello World";
    void indexx(){
        Console.WriteLine("for the index of string st");
        int a= st.IndexOf("o");
        
        int b=st.IndexOf("World");
        int c=st.LastIndexOf("o");
Console.WriteLine("The index of o is"+ a+"\n Indexof world is"+ b+ "\nindex of last word O "+ c);
    }
    void Cont(){
        bool e= st.Contains("World");
        Console.WriteLine("The World contains or not:"+e);

    }
    void subst(){
        Console.WriteLine("The substring of 6 is:"+st.Substring(6));
    }
    void Copyy(){
        string st2=String.Copy(st);
        Console.WriteLine("The copy of st is:"+ st2);
    }
    void check(){
        bool j=String.IsNullOrEmpty("");
        Console.WriteLine(j);
        Console.WriteLine("null or whitespace");
        bool co=String.IsNullOrWhiteSpace(" ");
        Console.WriteLine(co);
    }
    public static void Main(){
        Program3 p3= new Program3();
        p3.indexx();
        p3.Cont();
        p3.subst();
        p3.Copyy();
        p3.check();
    }
}
*/
using System;

class Program3
{
    static void Main()
    {
        // Original comma-separated string
        string original = "dog,cat,bird,fish";

        // Split the string into an array based on commas
        string[] stringArr = original.Split(',');

        // Display the array elements
        Console.WriteLine("Array after split:");
        foreach (var i in stringArr)
        {
            Console.WriteLine(i);
        }

        // Join the array back into a comma-separated string
        string joinedStr = string.Join(",", stringArr);

        // Display the joined string
        Console.WriteLine("\nJoined string:"+joinedStr);
      
    }
}
