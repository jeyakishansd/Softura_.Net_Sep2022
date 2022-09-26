using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KonsoleApp
{
    internal class TaskDataa
    {
        public void getDataa()
        {
            SqlConnection con = new SqlConnection("data source=jeyakishan\\sqlexpress;database=AdventureWorks2019;user id=sa;password=p@ssword");
            con.Open();
            SqlCommand cmd = new SqlCommand("select name from Humanresources.department", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
            }
            con.Close();
        }
        public void inseData(string firstName, string lastName, DateTime date, string department)
        {
            SqlConnection con = new SqlConnection("data source=jeyakishan\\sqlexpress;database=adventureworks2019;initial catalog=adventureworks2019;integrated security=true");
            SqlCommand cmd = new SqlCommand("sp_insStudentails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = firstName;
            cmd.Parameters.AddWithValue("@lastname",SqlDbType.NVarChar).Value = lastName;
            cmd.Parameters.AddWithValue("@sdate",SqlDbType.Date).Value=date;
            cmd.Parameters.AddWithValue("@department",SqlDbType.NVarChar).Value=department;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Insertedd");
    }
        public static void Main()
        {
            TaskDataa dat = new TaskDataa();
            dat.getDataa();
            dat.inseData("Rajesh", "Kumar", DateTime.Now, "IT");
        }
    }
}
