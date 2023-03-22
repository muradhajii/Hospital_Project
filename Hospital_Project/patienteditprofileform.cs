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
    public partial class patienteditprofileform : Form
    {
        public patienteditprofileform()
        {
            InitializeComponent();
        }

        public string IDF;

        sqlmyconnection mycon = new sqlmyconnection();
        private void patienteditprofileform_Load(object sender, EventArgs e)
        {
            mtxtbPEPpidf.Enabled = false;

            mtxtbPEPpidf.Text = IDF;
            SqlCommand com = new SqlCommand("select * from patient_table where p_idfcard=@p1", mycon.connection());
            com.Parameters.AddWithValue("@p1", mtxtbPEPpidf.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtbPEPname.Text = dr[1].ToString();
                txtbPEPsname.Text = dr[2].ToString();
                mtxtbPEPphone.Text = dr[4].ToString();
                txtbPEPpassword.Text = dr[5].ToString();
            }
            mycon.connection().Close();
        }

        private void btnPEPupdate_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("update patient_table set p_name=@p1,p_surname=@p2,p_phone=@p3,p_password=@p4 where p_idfcard=@p5", mycon.connection());
            com.Parameters.AddWithValue("@p1", txtbPEPname.Text);
            com.Parameters.AddWithValue("@p2", txtbPEPsname.Text);
            com.Parameters.AddWithValue("@p3", mtxtbPEPphone.Text);
            com.Parameters.AddWithValue("@p4", txtbPEPpassword.Text);
            com.Parameters.AddWithValue("@p5", mtxtbPEPpidf.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Your info updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
