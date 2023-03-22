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
    public partial class doctorloginform : Form
    {
        public doctorloginform()
        {
            InitializeComponent();
        }

        private void lnklblDLmainpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medicalcenterform mc = new medicalcenterform();
            mc.Show();
            this.Hide();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        private void btnDlogin_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from doctor_table where d_idfcard=@p1 and d_password=@p2", mycon.connection());
            com.Parameters.AddWithValue("@p1", mtxtbDLidf.Text);
            com.Parameters.AddWithValue("@p2", txtbDLpassword.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                doctorinfoform di = new doctorinfoform();
                di.IDF = mtxtbDLidf.Text;
                di.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID num or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.connection().Close();
        }
    }
}
