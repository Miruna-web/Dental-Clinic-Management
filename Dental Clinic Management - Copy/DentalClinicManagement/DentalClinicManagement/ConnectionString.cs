using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DentalClinicManagement
{
    class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Diana\\Desktop\\Dental Clinic Management\\DentalClinicManagement\\DentalClinicManagement\\DentalDb.mdf\";Integrated Security=True";
            return Con;

        }
    }

}
