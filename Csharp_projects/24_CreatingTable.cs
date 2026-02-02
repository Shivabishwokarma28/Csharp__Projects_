using System;
using System.Data;
using System.Data.SqlClient;
class Databaseprog{
    public static void Main(string [] args){
        string conndb="Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=Microsoft;Integrated Security=True";
        
        using(SqlConnection connection= new SqlConnection(conndb)){
            try{
                connection.Open();
                Console.WriteLine("connection established");
                string createe=@"
        CREATE TABLE Employee_info(
        ID INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(30),
        Age Int
        );
        ";
               using(SqlCommand comm= new SqlCommand(createe,connection)){
                
                    
                comm.ExecuteNonQuery();
               Console.WriteLine("Table is created");
               


               }
               
                
            }
            
catch(Exception e)
{ 
    
    Console.Write("connection interruption"+ e.Message);
        }
    }
}
}