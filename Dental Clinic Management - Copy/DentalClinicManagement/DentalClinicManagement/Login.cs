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
    public partial class Login : Form
    {
        SqlConnection myCon = new SqlConnection();
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dell\Desktop\Dental Clinic Management - Copy\DentalClinicManagement\DentalClinicManagement\DentalDb.mdf;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
            myCon = new SqlConnection(connectionString);
            myCon.Open();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }
        ConnectionString MyConnection = new ConnectionString();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // using (myCon = new SqlConnection(connectionString))
                //{
                //  myCon.Open();

                string query = "SELECT COUNT(*) FROM UserTbl WHERE Uname=@Uname AND Upass=@Upass";
                using (SqlCommand command = new SqlCommand(query, myCon))
                {
                    command.Parameters.AddWithValue("@Uname", UnameTb.Text);
                    command.Parameters.AddWithValue("@Upass", UpassTb.Text);

                    if ((int)command.ExecuteScalar() > 0)
                    {
                        //MessageBox.Show("Welcome " + UnameTb.Text);
                        Appointment App = new Appointment();
                        App.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("User not found");
                }
              
            }
            catch (Exception) { }
        
    
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
