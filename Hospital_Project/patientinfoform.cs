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
    public partial class patientinfoform : Form
    {
        public patientinfoform()
        {
            InitializeComponent();
        }

        public string IDF;
        sqlmyconnection mycon = new sqlmyconnection();
        private void patientinfoform_Load(object sender, EventArgs e)
        {
            lblPIidnum.Text = IDF;

            //Fullname
            SqlCommand com = new SqlCommand("select p_name,p_surname from patient_table where p_idfcard=@p1", mycon.connection());
            com.Parameters.AddWithValue("@p1", IDF);
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                lblPIfname.Text = dr[0] + " " + dr[1];
            }
            mycon.connection().Close();

            //Appointment history
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from appointment_table where a_patientID =" + IDF, mycon.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branchs
            SqlCommand com2 = new SqlCommand("select b_name from branch_table", mycon.connection());
            SqlDataReader dr2 = com2.ExecuteReader();
            while(dr2.Read())
            {
                cmbPIbranch.Items.Add(dr2[0]);
            }
            mycon.connection().Close();
        }

        private void cmbPIbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPIdoctor.Items.Clear();
            cmbPIdoctor.Text = "";

            SqlCommand com = new SqlCommand("select d_name,d_surname from doctor_table where d_branch=@p1", mycon.connection());
            com.Parameters.AddWithValue("@p1", cmbPIbranch.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbPIdoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            mycon.connection().Close();
        }

        private void cmbPIdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from appointment_table where a_branch='" + cmbPIbranch.Text + "'" + "and a_doctor='"+cmbPIdoctor.Text+"'and a_status=0 order by a_id asc", mycon.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linklblPIeditp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            patienteditprofileform pep = new patienteditprofileform();
            pep.IDF = lblPIidnum.Text;
            pep.Show();
        }

        private void btnPIappointment_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("update appointment_table set a_status=1,a_patientID=@p1,a_patientDisease=@p2 where a_id=@p3", mycon.connection());
            com.Parameters.AddWithValue("@p1", lblPIidnum.Text);
            com.Parameters.AddWithValue("@p2", rtxtbPIdisease.Text);
            com.Parameters.AddWithValue("@p3", txtbPIid.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Appointment taken", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medicalcenterform mc = new medicalcenterform();
            mc.Show();
            this.Hide();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            txtbPIid.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }
    }
}