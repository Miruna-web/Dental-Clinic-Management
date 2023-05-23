using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagement
{
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into TreatmentTbl values ('" + TreatNameTb.Text + "','" + Convert.ToInt32(TreatCostTb.Text) + "','" + TreatDescTb.Text + "')";
            Treatments treatment = new Treatments();
           
            try
            {
                treatment.AddPatient(query);
                MessageBox.Show("Treatment Successfully Added");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        void populate()
        {
            Treatments treatment = new Treatments();
            string query = "select * from TreatmentTbl";

            DataSet ds = treatment.ShowPatient(query);
            TreatmentDGV.DataSource = ds.Tables[0];
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            Treatments treatment = new Treatments();
            if (key == 0)
            {
                MessageBox.Show("Select the Treatment");
            }
            else
            {
                try
                {
                    string query = "Update TreatmentTbl set TreatName= '" + TreatNameTb.Text + "', TreatCost= '" + TreatCostTb.Text + "', TreatDesc ='" + TreatDescTb.Text +  "'where TreatId = " + key + ";";
                    treatment.UpdatePatient(query);
                    MessageBox.Show("Treatment Successufully Updated");
                    populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void TreatmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TreatNameTb.Text = TreatmentDGV.SelectedRows[0].Cells[1].Value.ToString();

            TreatCostTb.Text = TreatmentDGV.SelectedRows[0].Cells[2].Value.ToString();

            TreatDescTb.Text = TreatmentDGV.SelectedRows[0].Cells[3].Value.ToString();

            
            if (TreatNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TreatmentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Treatments treatment = new Treatments();
            if (key == 0)
            {
                MessageBox.Show("Select the Treatment");
            }
            else
            {
                try
                {
                    string query = "Delete from TreatmentTbl where TreatId = " + key + "";
                    treatment.DeletePatient(query);
                    MessageBox.Show("Treatment Successufully Deleted");
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

      

        private void label3_Click(object sender, EventArgs e)
        {
            Prescription Presc = new Prescription();
            Presc.Show();
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
