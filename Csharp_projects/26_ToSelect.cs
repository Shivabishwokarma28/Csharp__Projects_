using System;
using System.Data.SqlClient;
class MicroDB{
    static void Main(){
        //connect to the database
        string conn="Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=Microsoft;Integrated Security=True;";
        
        
        using(SqlConnection connection= new SqlConnection(conn)){
            try{
                connection.Open();
                Console.WriteLine("Connction established");
                string insquer="INSERT INTO EMPLOYEE(NAME,EMAIL,AGE) VALUES(@NAME,@EMAIL,@AGE)";
                string Selectqe="SELECT NAME,EMAIL FROM EMPLOYEE";
                using(SqlCommand readd=new SqlCommand(Selectqe,connection)){
                using(SqlDataReader re=readd.ExecuteReader())
                {
                    while(re.Read())
                    {
                        string NAME=re.GetString(1);
                        string EMAIL=re.GetString(1);
                        Console.WriteLine($"Name :{NAME}, Email: {EMAIL}");
                    }
                }
              
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error"+e.Message);

            }

        }
    }
}