using FitnessProgramManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem.Repositary
{
    internal class FitnessProgramRepository
    {

        static string ConnectionString = "server=(localdb)\\MSSQLLocalDB;Initial Catalog= FitnessProgramManagement";

        public void CreateFitnessProgram(FitnessProgram fitnessProgram)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString)) {
            
                conn.Open();
                string query = "INSERT INTO FitnessPrograms (Title,Duration,Price) VALUES (@Title,@Duration,@Price)";
                using (SqlCommand cmd = new SqlCommand(query, conn)) {

                    cmd.Parameters.AddWithValue("@Title", fitnessProgram.Title);
                    cmd.Parameters.AddWithValue("@Duration", fitnessProgram.Duration);
                    cmd.Parameters.AddWithValue("@Price", fitnessProgram.Price);



                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Program Added Successfully");



                }

            }



        }


        public string GetProgramsByID(int id) { 
        
        using (SqlConnection conn = new SqlConnection(ConnectionString))

        {
          conn.Open();
                string query = "Select * from FitnessPrograms where FitnessProgramId=@FitnessProgramId ";
                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@FitnessProgramId", id);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                       return ($"FitnessProgramId{reader["FitnessProgramId"]},Title{reader["Title"]},Duration{reader["Duration"]},Price{reader["Price"]}");



                    }

                    return null;

                }

            }


        }


        public string GetAll(FitnessProgram fitnessProgram)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();
                string query = "SELECT * FROM FitnessPrograms ";

                using (SqlCommand comm = new SqlCommand(query, connection))
                {

                   SqlDataReader reader = comm.ExecuteReader();
                    string returnstr = "";
                    while (reader.Read()) {

                        returnstr += ($"FitnessProgramId{reader["FitnessProgramId"]},Title{reader["Title"]},Duration{reader["Duration"]},Price{reader["Price"]}");



                    }
                
                return returnstr;
                
                
                
                }

            }
        }

        public void DeleteProgram(int id) {

            using (SqlConnection con = new SqlConnection(ConnectionString)) {
            
            
            con.Open();
                string str = "Delete from FitnessPrograms where FitnessProgramId=@FitnessProgramId";
              using (SqlCommand cmd = new SqlCommand(str, con))
                {
                  
                    cmd.Parameters.AddWithValue("@FitnessProgramId",id);
                    int row=cmd.ExecuteNonQuery();
                   if( row > 0)
                    {
                        Console.WriteLine("Program Delete Success Fully");
                    }
                    else
                    {
                        Console.WriteLine("Error Deleting Program");
                    }



                }






            }
        
        
        
        }


        public  void UpdateProgram(FitnessProgram fitnessProgram)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString)) { 
            
            conn.Open();
                string str = "Update FitnessPrograms set Title=@Title,Duration=@Duration,Price=@Price where FitnessProgramId=@FitnessProgramId";

                using (SqlCommand command = new SqlCommand(str, conn))
                {

                    command.Parameters.AddWithValue("FitnessProgramId", fitnessProgram.FitnessProgramId);
                    command.Parameters.AddWithValue("Title", fitnessProgram.Title);
                    command.Parameters.AddWithValue("Duration", fitnessProgram.Duration);
    command.Parameters.AddWithValue("Price", fitnessProgram.Price);

                    int row=command.ExecuteNonQuery();
                    if (row > 0)
                    {



                        Console.WriteLine("Update successfully");


                    }

                    else {

                        Console.WriteLine("Program not found");


                    }








                    
                }




            }


        }

































































    }
}
