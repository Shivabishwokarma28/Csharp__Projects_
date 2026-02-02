using System;
using System.Data.SqlClient;
class Progra{
    public static void Main()
    { 
        //connection with database
        string con="Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=Meta;Integrated Security=true";
        using(SqlConnection connection = new SqlConnection(con))
        {
           try{
            connection.Open();
            Console.WriteLine("Connection opened");
                //Creating Query
                /* string Createe=@"CREATE TABLE Employee
                      (
                      ID INT PRIMARY KEY IDENTITY(1,1),
                      NAME NVARCHAR(40),
                      EMAIL NVARCHAR(30)
                      )";
                      using(SqlCommand Ctable=new SqlCommand(Createe,connection))
                      {
                         Ctable.ExecuteNonQuery();
                         Console.WriteLine("Table Created!!");
                      }
                      // Inserting Data
                      */
                /*string insqur="INSERT INTO EMPLOYEE(NAME,EMAIL) VALUES(@NAME,@EMAIL)";
                using(SqlCommand qur=new SqlCommand(insqur,connection)){
                    qur.Parameters.AddWithValue("NAME","Eren");
                    qur.Parameters.AddWithValue("EMAIL","Eren");
                    qur.ExecuteNonQuery();
                    Console.WriteLine("Data Inserted!!");
                }*/
                //retrieving data
                /* string selectt="SELECT NAME FROM EMPLOYEE";
                 using(SqlCommand redd=new SqlCommand(selectt,connection)){
                     using(SqlDataReader re=redd.ExecuteReader())
                     {
                         while(re.Read()){
                             string NAME=re.GetString(0);
                             Console.WriteLine($"NAME:{NAME}");
                         }
                     }
                 }
                 //update data
                 */
                string updateQuery = "UPDATE EMPLOYEE SET Email = @Email ";
using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
{
    cmd.Parameters.AddWithValue("@Email", "John@example.com");
   
    cmd.ExecuteNonQuery();
}
           }
           catch(Exception e)
           {
            Console.WriteLine("Error"+e.Message);

           }
        }
    }
}