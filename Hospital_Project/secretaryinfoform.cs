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
    public partial class secretaryinfoform : Form
    {
        public secretaryinfoform()
        {
            InitializeComponent();
        }

        public string IDF;

        sqlmyconnection mycon = new sqlmyconnection();
        private void secretaryinfoform_Load(object sender, EventArgs e)
        {
            lblSIidnum.Text = IDF;

            //Fullname
            SqlCommand com = new SqlCommand("select s_fullname from secretary_table where s_idfcard=@p1 order by s_id asc", mycon.connection());
            com.Parameters.AddWithValue("@p1", IDF);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblSIfname.Text = dr[0].ToString();
            }
            mycon.connection().Close();

            //Branchs datagrid
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select b_name from branch_table order by b_id asc", mycon.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doctors
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (d_name+' '+d_surname) as Fullname,d_branch,d_phone from doctor_table order by d_id asc", mycon.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branchs combobox

            SqlCommand com2 = new SqlCommand("select b_name from branch_table order by b_id asc", mycon.connection());
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                cmbSIbranch.Items.Add(dr2[0].ToString());
            }
            mycon.connection().Close();
        }

        private void btnSIsave_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into appointment_table(a_date,a_time,a_branch,a_doctor) values(@p1,@p2,@p3,@p4)", mycon.connection());
            com.Parameters.AddWithValue("@p1", mtxtbSIdate.Text);
            com.Parameters.AddWithValue("@p2", mtxtbSItime.Text);
            com.Parameters.AddWithValue("@p3", cmbSIbranch.Text);
            com.Parameters.AddWithValue("@p4", cmbSIdoctor.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Appointment is created");
        }

        private void cmbSIbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSIdoctor.Items.Clear();
            cmbSIdoctor.Text = "";

            SqlCommand com = new SqlCommand("select d_name,d_surname from doctor_table where d_branch=@p1 order by d_id asc", mycon.connection());
            com.Parameters.AddWithValue("@p1", cmbSIbranch.Text);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbSIdoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            mycon.connection().Close();
        }

        private void btnSIcreate_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into announcement_table(announce) values(@p1)", mycon.connection());
            com.Parameters.AddWithValue("@p1", rtxtbSIannounc.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Announce is created!");
            rtxtbSIannounc.Text = "";
        }

        private void btnSIdocpan_Click(object sender, EventArgs e)
        {
            secretarydocpanform sdp = new secretarydocpanform();
            sdp.Show();
        }

        private void btnSIbranchpan_Click(object sender, EventArgs e)
        {
            secretarybranchpanform sbp = new secretarybranchpanform();
            sbp.Show();
        }

        private void btnSIapppan_Click(object sender, EventArgs e)
        {
            secretaryapppanform sap = new secretaryapppanform();
            sap.Show();
        }

        private void btnSIshowall_Click(object sender, EventArgs e)
        {
            secretaryannouncementform sa = new secretaryannouncementform();
            sa.Show();
        }

        private void btnSImp_Click(object sender, EventArgs e)
        {
            medicalcenterform mc = new medicalcenterform();
            mc.Show();
            this.Hide();
        }
    }
}
