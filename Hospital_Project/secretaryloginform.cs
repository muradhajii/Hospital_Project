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
    public partial class secretaryloginform : Form
    {
        public secretaryloginform()
        {
            InitializeComponent();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        private void btnSlogin_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from secretary_table where s_idfcard=@p1 and s_password=@p2", mycon.connection());
            com.Parameters.AddWithValue("@p1", mtxtbSLidf.Text);
            com.Parameters.AddWithValue("@p2", txtbSLpassword.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                secretaryinfoform si = new secretaryinfoform();
                si.IDF=mtxtbSLidf.Text;
                si.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.connection().Close();
        }

        private void lnklblSLmainpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medicalcenterform mc = new medicalcenterform();
            mc.Show();
            this.Hide();
        }
    }
}
