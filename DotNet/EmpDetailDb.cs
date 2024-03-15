﻿using Microsoft.Data.SqlClient;

namespace DotNet
{
    public class EmpDetailDb
    {
        public List <Employees> GetEmployeeDetails(int id) 
        {
            List<Employees> empDetails = new List<Employees>();
            // sql authentication --> user and password
            // windows authentication --> no user/password
            SqlConnection sqlConnection = new SqlConnection("Server=TL578\\SQLEXPRESS;Database=EmpDetails;Trusted_Connection=True;TrustServerCertificate=True;");
            sqlConnection.Open();

            //using inline queries
            //SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM E_Details", sqlConnection);
            //SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM E_Details where EmpId = {id}", sqlConnection);


            //using stored procedures
            SqlCommand sqlCommand = new SqlCommand("SP_GetEmpDetails", sqlConnection);

            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 30;


            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employees emp = new Employees();
                    emp.EmpId = Convert.ToInt32(reader["EmpId"].ToString());
                    emp.EmpName = reader["EmpName"].ToString();
                    emp.Experience = Convert.ToDouble(reader["Experience"].ToString());
                    empDetails.Add(emp);

                }
                sqlConnection.Close();
            }
            return empDetails;

        }

        public bool addEmployeeDetails(Employees details)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=TL578\\SQLEXPRESS;Database=EmpDetails;Trusted_Connection=True;TrustServerCertificate=True;");
            sqlConnection.Open();
            // sql command

            //inline queries
            //SqlCommand sqlCommand = new SqlCommand($"INSERT INTO E_Details VALUES (@EmpId, @EmpName, @Experience);", sqlConnection);

            //stored procedure
            SqlCommand sqlCommand = new SqlCommand("SP_InsertEmpDetails", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@EmpId", details.EmpId);
            sqlCommand.Parameters.AddWithValue("@EmpName", details.EmpName);
            sqlCommand.Parameters.AddWithValue("@Experience", details.Experience);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 30;
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (result >= 1)
            {
                Console.WriteLine("Insert Successful");
                return true;
            }
            else
            {
                Console.WriteLine("Insert failure");
                return false;
            }        
        }

        public bool deleteEmployeeDetails(int id)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=TL578\\SQLEXPRESS;Database=EmpDetails;Trusted_Connection=True;TrustServerCertificate=True;");
            sqlConnection.Open();
            // sql command

            //inline queries
            //SqlCommand sqlCommand = new SqlCommand($"DELETE FROM E_Details WHERE EmpId= {id};", sqlConnection);


            //stored procedure
            SqlCommand sqlCommand = new SqlCommand("SP_DeleteEmpDetails", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@EmpId", id);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 30;
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (result >= 1)
            {
                Console.WriteLine("Delete Successful");
                return true;
            }
            else
            {
                Console.WriteLine("Delete failure");
                return false;
            }
        }

        public bool updateEmployeeDetails(int id)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=TL578\\SQLEXPRESS;Database=EmpDetails;Trusted_Connection=True;TrustServerCertificate=True;");
            sqlConnection.Open();

            //inline queries
            //SqlCommand sqlCommand = new SqlCommand($"UPDATE E_Details SET Experience = 10 where EmpId={id};", sqlConnection);

            //stored procedure
            SqlCommand sqlCommand = new SqlCommand("SP_UpdateEmpDetails", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@EmpId", id);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 30;
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (result >= 1)
            {
                Console.WriteLine("Update Successful");
                return true;
            }
            else
            {
                Console.WriteLine("Update failure");
                return false;
            }

        }

    }
}
