using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DentalClinicManagement
{
    class Treatments
    {
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dell\Desktop\Dental Clinic Management - Copy\DentalClinicManagement\DentalClinicManagement\DentalDb.mdf;Integrated Security=True";

        public void AddPatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public void DeletePatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public void UpdatePatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public DataSet ShowPatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }
    }
}


