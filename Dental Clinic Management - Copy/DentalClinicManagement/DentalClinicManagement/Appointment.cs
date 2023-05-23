using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DentalClinicManagement
{
    public partial class Appointment : Form
    {
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dell\Desktop\Dental Clinic Management - Copy\DentalClinicManagement\DentalClinicManagement\DentalDb.mdf;Integrated Security=True";
        public Appointment()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();
        private void fillPatient()
        {
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PatName from PatientTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatName", typeof(string));
            dt.Load(rdr);
            PatientCb.ValueMember = "PatName";
            PatientCb.DataSource = dt;
            Con.Close();
        }

        private void fillTreatment()
        {
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TreatName from TreatmentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TreatName", typeof(string));
            dt.Load(rdr);
            TreatmentCb.ValueMember = "TreatName";
            TreatmentCb.DataSource = dt;
            Con.Close();
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
            fillPatient();
            fillTreatment();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into AppointmentTbl values ('" + PatientCb.SelectedValue.ToString() + "','" + TreatmentCb.SelectedValue.ToString() + "','" + DateApp.Value.Date + "','" + TimeApp.Value.TimeOfDay + "')";
            MyPatient Pat = new MyPatient();
            Pat.AddPatient(query);
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Appointment Successfully Recordered");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from AppointmentTbl";

            DataSet ds = Pat.ShowPatient(query);
            AppDGV.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select the Appointment to Cancel");
            }
            else
            {
                try
                {
                    string query = "Delete from AppointmentTbl where ApId = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Appointment Successufully Canceled");
                    populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void AppDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientCb.SelectedValue = AppDGV.SelectedRows[0].Cells[1].Value.ToString();

            TreatmentCb.SelectedValue = AppDGV.SelectedRows[0].Cells[2].Value.ToString();

            string pat = AppDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (pat == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AppDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select the Appointment");
            }
            else
            {
                try
                {
                    string query = "Update AppointmentTbl set Patient= '" + PatientCb.SelectedValue.ToString() + "', Treatment= '" + TreatmentCb.SelectedValue.ToString() + "', AppDate ='" + DateApp.Value.Date + "' AppTime ='"+TimeApp.Value.TimeOfDay+"'where ApId = " + key + ";";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Appointment Successufully Updated");
                    populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Treatment Treat = new Treatment();
            Treat.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Prescription Presc = new Prescription();
            Presc.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
