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
    public partial class doctoreditprofileform : Form
    {
        public doctoreditprofileform()
        {
            InitializeComponent();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        public string IDF;
        private void doctoreditprofileform_Load(object sender, EventArgs e)
        {
            mtxtbDEPpidf.Text = IDF;

            SqlCommand com = new SqlCommand("select * from doctor_table where d_idfcard=@p1 order by d_id", mycon.connection());
            com.Parameters.AddWithValue("@p1", mtxtbDEPpidf.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtbDEPname.Text = dr[1].ToString();
                txtbDEPsname.Text = dr[2].ToString();
                cmbDEPbranch.Text = dr[3].ToString();
                mtxtbDEPpidf.Text = dr[4].ToString();
                mtxtbDEPphone.Text = dr[5].ToString();
                txtbDEPpassword.Text = dr[6].ToString();
            }
            mycon.connection().Close();
        }

        private void btnDEPupdate_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("update doctor_table set d_name=@p1,d_surname=@p2,d_branch=@p3,d_phone=@p4,d_password=@p5 where d_idfcard=@p6", mycon.connection());
            com.Parameters.AddWithValue("@p1", txtbDEPname.Text);
            com.Parameters.AddWithValue("@p2", txtbDEPsname.Text);
            com.Parameters.AddWithValue("@p3", cmbDEPbranch.Text);
            com.Parameters.AddWithValue("@p4", mtxtbDEPphone.Text);
            com.Parameters.AddWithValue("@p5", txtbDEPpassword.Text);
            com.Parameters.AddWithValue("@p6", mtxtbDEPpidf.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Profile updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
