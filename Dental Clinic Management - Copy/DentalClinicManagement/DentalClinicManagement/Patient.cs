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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into PatientTbl (PatName,PatPhone,PatDOB,PatGender,PatAllergies, PatAddress) values ('" + PatNameTb.Text + "','" + PatPhoneTb.Text + "','" + DOBDate.Value.Date + "','" + GenderTb.SelectedItem.ToString() + "','" + AllergiesTb.Text + "','"+PatAddressTb.Text+"')";
            MyPatient Pat = new MyPatient();
            
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Patient Successfully Added");
                populate();
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from PatientTbl  ";
            

            DataSet ds = Pat.ShowPatient(query);
            PatientDGV.DataSource = ds.Tables[0];
        }

        
        private void Patient_Load(object sender, EventArgs e)
        {
            populate();
        }

        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatAddressTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenderTb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            AllergiesTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if(PatNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select the Patient");
            }else
            {
                try
                {
                    string query = "Delete from PatientTbl where PatId = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Patient Successufully Deleted");
                    populate();
                        

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    string query = "Update PatientTbl set PatName= '"+PatNameTb.Text+"', PatPhone= '"+PatPhoneTb.Text+"', PatAddress ='"+PatAddressTb.Text+"',PatDOB = '"+DOBDate.Value.Date+"',PatGender='"+GenderTb.SelectedItem.ToString()+"',PatAllergies = '"+AllergiesTb.Text+"'where PatId = "+key+";";
                    Pat.DeletePatient(query);
                    MessageBox.Show("Patient Successufully Updated");
                    populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            dash.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Appointment App = new Appointment();
            App.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
