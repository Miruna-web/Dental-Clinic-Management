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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into UserTbl values ('" + usernametb.Text + "','" + passtb.Text + "','" + userphonetb.Text + "')";
            MyPatient Pat = new MyPatient();
            //Pat.AddPatient(query);
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("User Successfully Added");
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
            string query = "select * from UserTbl";

            DataSet ds = Pat.ShowPatient(query);
            userDGV.DataSource = ds.Tables[0];
        }

        private void User_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void userDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usernametb.Text = userDGV.SelectedRows[0].Cells[1].Value.ToString();

            userphonetb.Text = userDGV.SelectedRows[0].Cells[2].Value.ToString();

            passtb.Text = userDGV.SelectedRows[0].Cells[1].Value.ToString();

            

            if (usernametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(userDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select the User");
            }
            else
            {
                try
                {
                    string query = "Delete from UserTbl where Uid = " + key + "";
                    Pat.DeletePatient(query);
                    MessageBox.Show("User Successufully Deleted");
                    populate();


                }
                catch (Exception Ex)
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
                MessageBox.Show("Select the User");
            }
            else
            {
                try
                {
                    string query = "Update UserTbl set Uname= '" + usernametb.Text + "', Upass= '" + passtb.Text + "', Phone ='" + userphonetb.Text + "'where Uid = " + key + ";";
                    Pat.DeletePatient(query);
                    MessageBox.Show("User Successufully Updated");
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

    

        private void label1_Click_1(object sender, EventArgs e)
        {
            Treatment Treat = new Treatment();
            Treat.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.Show();
            this.Hide();
        }

      
        
    }
}
