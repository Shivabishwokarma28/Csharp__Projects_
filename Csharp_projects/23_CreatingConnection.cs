using System;
using System.Data;
using System.Data.SqlClient;
class Databaseprog{
    public static void Main(string [] args){
        string conndb="Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=Student;Integrated Security=True";
        
        using(SqlConnection connection= new SqlConnection(conndb)){
            try{
                connection.Open();
                Console.WriteLine("connection established");
        
               }
               
                
            
            
catch(Exception e)
{ 
    
    Console.Write("connection interruption"+ e.Message);
        }
    }
}
}