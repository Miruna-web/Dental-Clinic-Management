using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagement
{
    public partial class DashBoard : Form
    {
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dell\Desktop\Dental Clinic Management - Copy\DentalClinicManagement\DentalClinicManagement\DentalDb.mdf;Integrated Security=True";

        public DashBoard()
        {
            InitializeComponent();
        }
        ConnectionString MyConnection = new ConnectionString();
        private void DashBoard_Load(object sender, EventArgs e)
        {
            PendingAppProgres.Value = 100;
            UsersProgress.Value = 100;
            Patients.Value = 100;
            NextApp.Value = 100;
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from AppointmentTbl ",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Pendinglbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from PatientTbl ", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Patientlbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from UserTbl ", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Userlbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("Select min(ApDate) from AppointmentTbl ", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            NextAppLbl.Text = dt.Rows[0][0].ToString();

            Con.Close();

            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Appointment App = new Appointment();
            App.Show();
            this.Hide();
        }

       
        
    }
}
