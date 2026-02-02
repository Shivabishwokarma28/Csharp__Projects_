using System;
namespace Controlstatements{
  public class ConditionalsExample{
    public static void Main(){
      int a;
       string grade;
      Console.WriteLine("Enter Your mark:");
      a=Convert.ToInt32(Console.ReadLine());
       


      if(a<=40 && a>50){
        grade="c";
      }

       else if(a<60 && a>=50){
        grade="c+";
       }
        else if(a<70 && a>=60){
       grade="B";
       }else if(a<80 && a>=70){
          grade="B+";
       }else if(a<90 && a>=80){
        grade="A";
       }
      else if(a<=100 && a>=90)
       {
          grade="A+";
       }
       else{
        grade="fail";
       }
       switch(grade)
{
  case "A+": Console.WriteLine("A+");
  break;
   case "A": Console.WriteLine("A");
  break; case "B+": Console.WriteLine("B+");
  break; case "B": Console.WriteLine("B");
  break; case "C+": Console.WriteLine("C+");
  break;
   case "C": Console.WriteLine("C");
  break;
   case "fail": Console.WriteLine("fail");
  break;
  default:
  Console.WriteLine("Invalid grade");
  break;
}}
  }}
  