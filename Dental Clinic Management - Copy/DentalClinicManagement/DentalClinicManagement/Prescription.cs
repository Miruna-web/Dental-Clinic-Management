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
    public partial class Prescription : Form
    {
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dell\Desktop\Dental Clinic Management - Copy\DentalClinicManagement\DentalClinicManagement\DentalDb.mdf;Integrated Security=True";

        public Prescription()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();
        private void fillPatient()
        {
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Patient from AppointmentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(rdr);
            PatId.ValueMember = "Patient";
            PatId.DataSource = dt;
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
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(rdr);
            PatId.ValueMember = "Patient";
            PatId.DataSource = dt;
            Con.Close();
        }
        private void GetTreatment()
        {
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from AppointmentTbl where Patient = '" + PatId.SelectedValue.ToString() + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                TreatmentTb.Text = dr["Treatment"].ToString();
            }
            Con.Close();
        }

        private void GetPrice()
        {
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from TreatmentTbl where TreatName = '" + TreatmentTb.Text + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CostTb.Text = dr["TreatCost"].ToString();
            }
            Con.Close();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            fillPatient();
            populate();
        }

        private void PatId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTreatment();

        }

        private void TreatmentTb_TextChanged(object sender, EventArgs e)
        {
            GetPrice();
        }
        void populate()
        {
            Prescriptions Pat = new Prescriptions();
            string query = "select * from PrescriptionTbl";

            DataSet ds = Pat.ShowPatient(query);
            PrescriptionDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into PrescriptionTbl values ('" + PatId.SelectedValue.ToString() + "','" + TreatmentTb.Text + "','" + Medicinetb.Text + "','"+ CostTb.Text+"','"+ QuantityTb.Text+"')";
            //MyPatient Pat = new MyPatient();
            Prescriptions Pat = new Prescriptions();
         
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Prescription Successfully Added");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.SelectedValue = PrescriptionDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatmentTb.Text = PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString();
            Medicinetb.Text = PrescriptionDGV.SelectedRows[0].Cells[3].Value.ToString();
            QuantityTb.Text = PrescriptionDGV.SelectedRows[0].Cells[5].Value.ToString();
            CostTb.Text = PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (TreatmentTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prescriptions Pat = new Prescriptions();
            if (key == 0)
            {
                MessageBox.Show("Select the Prescription");
            }
            else
            {
                try
                {
                    string query = "Delete from PrescriptionTbl where PrescId = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Prescription Successufully Deleted");
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
            User user = new User();
            user.Show();
           
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Treatment Treat = new Treatment();
            Treat.Show();
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
