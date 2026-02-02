using System;
using System.Data.SqlClient;
class MicroDB{
    static void Main(){
        //connect to the database
        string conn="Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=Microsoft;Integrated Security=True;";
        string Createe=@"CREATE TABLE EMPLOYEE
        (
             ID INT PRIMARY KEY IDENTITY(1,1),
             NAME NVARCHAR(30),
             EMAIL NVARCHAR(40),
             AGE INT
        )";
        string insquer="INSERT INTO EMPLOYEE(ID,NAME,EMAIL,AGE) VALUES(@ID,@NAME,@EMAIL,@AGE)";
        using(SqlConnection connection= new SqlConnection(conn)){
            try{
                connection.Open();
                Console.WriteLine("Connection Established");
                using(SqlCommand Com=new SqlCommand(Createe,connection)){
                    Com.ExecuteNonQuery();
                    Console.WriteLine("Table is created");
                
                using(SqlCommand quer=new SqlCommand(insquer)){
                    quer.Parameters.AddWithValue("ID","1");
                    quer.Parameters.AddWithValue("NAME","Eren");
                    quer.Parameters.AddWithValue("EMAIL","Eren_12@gmail.com");
                    quer.Parameters.AddWithValue("AGE","19");
                    int rowaff= quer.ExecuteNonQuery();
                    Console.WriteLine("Row inserted"+rowaff);
                }
                }}
            catch(Exception e)
            {
                Console.WriteLine("Error"+e.Message);

            }

        }
    }
}