using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Dbconnection
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        public DataTable getAllStudents()
        {

            SqlConnection conn = null;
            DataTable table = null;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            using (conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    String query = "SelectProcedure1";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand = com;
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.FillSchema(dataSet, SchemaType.Source, "Registration");
                    sqlDataAdapter.Fill(dataSet, "Registration");
                    table = dataSet.Tables["Registration"];
                    return table;
                }
                catch (SqlException ex)
                {
                  Console.WriteLine(ex.ToString(), "Sql Exception");
                    return null;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public void Registration(string name, string dob, string avg, string active)
        {
            SqlConnection conn = null;
            using (conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "RegistrationEntry";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Name", name);        //first Name
                    com.Parameters.AddWithValue("@DOB", dob);     //middle Name
                    com.Parameters.AddWithValue("@GradePointAvg", avg);
                    com.Parameters.AddWithValue("@Active", "true"); //Last Name
                    com.ExecuteNonQuery();                     //executing the sqlcommand

                   // MessageBox.Show("inserted sussfully");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString(), "Sql Exception");

                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }

        }
    }
}
