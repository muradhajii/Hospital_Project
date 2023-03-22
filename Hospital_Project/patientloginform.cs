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

namespace Hospital_Project
{
    public partial class patientloginform : Form
    {
        public patientloginform()
        {
            InitializeComponent();
        }

        private void linkPlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            patientsignupform pSU = new patientsignupform();
            pSU.Show();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        private void btnPlogin_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from patient_table where p_idfcard=@p1 and p_password=@p2", mycon.connection());
            com.Parameters.AddWithValue("@p1",mtxtbPLidf.Text);
            com.Parameters.AddWithValue("@p2",txtbPLpassword.Text);
            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read())
            {
                patientinfoform pi = new patientinfoform();
                pi.IDF = mtxtbPLidf.Text;
                pi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password or ID num!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnklblPLmainpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medicalcenterform mc = new medicalcenterform();
            mc.Show();
            this.Hide();
        }
    }
}
