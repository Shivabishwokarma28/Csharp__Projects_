using System;
using System.Data.SqlClient;
class MicroDB{
    static void Main(){
        //connect to the database
        string conn="Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=Microsoft;Integrated Security=True;";
        
        string insquer="INSERT INTO  Employee_info(NAME,AGE) VALUES(@NAME,@AGE)";
        using(SqlConnection connection= new SqlConnection(conn)){
            try{
                connection.Open();
                
                using(SqlCommand quer=new SqlCommand(insquer,connection)){
                  
                    quer.Parameters.AddWithValue("NAME","Eren");
                 
                    quer.Parameters.AddWithValue("AGE","19");

                    int rowaff= quer.ExecuteNonQuery();
                    Console.WriteLine("Row inserted"+rowaff);
                }
                }
            catch(Exception e)
            {
                Console.WriteLine("Error"+e.Message);

            }

        }
    }
}