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
    public partial class doctorinfoform : Form
    {
        public doctorinfoform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medicalcenterform mc = new medicalcenterform();
            mc.Show();
            this.Close();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        public string IDF;
        private void doctorinfoform_Load(object sender, EventArgs e)
        {
            lblDIidnum.Text = IDF;

            //Doctor fullname
            SqlCommand com = new SqlCommand("select d_name,d_surname from doctor_table where d_idfcard=@p1 order by d_id", mycon.connection());
            com.Parameters.AddWithValue("@p1", IDF);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblDIfname.Text = dr[0] + " " + dr[1];
            }
            mycon.connection().Close();

            //Appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from appointment_table where a_doctor='" + lblDIfname.Text + "' order by a_id", mycon.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDIedit_Click(object sender, EventArgs e)
        {
            doctoreditprofileform dep = new doctoreditprofileform();
            dep.IDF = lblDIidnum.Text;
            dep.Show();
        }

        private void btnDIannounce_Click(object sender, EventArgs e)
        {
            announcmentsform a = new announcmentsform();
            a.Show();
        }

        private void btnDIexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            rtxtbDIappdetail.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
