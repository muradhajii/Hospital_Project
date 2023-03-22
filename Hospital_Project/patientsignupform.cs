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
    public partial class patientsignupform : Form
    {
        public patientsignupform()
        {
            InitializeComponent();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        private void btnsignup_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into patient_table(p_name,p_surname,p_idfcard,p_phone,p_password,p_sex) values(@p1,@p2,@p3,@p4,@p5,@p6)", mycon.connection());
            com.Parameters.AddWithValue("@p1",txtbPSUname.Text);
            com.Parameters.AddWithValue("@p2",txtbPSUsname.Text);
            com.Parameters.AddWithValue("@p3", mtxtbPSUpidf.Text);
            com.Parameters.AddWithValue("@p4", mtxtbPSUphone.Text);
            com.Parameters.AddWithValue("@p5", txtbPSUpassword.Text);
            com.Parameters.AddWithValue("@p6", cmbPSUsex.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Save successful, your password: " + txtbPSUpassword.Text, "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
