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
    public partial class secretarydocpanform : Form
    {
        public secretarydocpanform()
        {
            InitializeComponent();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        private void secretarydocpanform_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from doctor_table order by d_id asc", mycon.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branch combobox
            SqlCommand com = new SqlCommand("select b_name from branch_table order b_id asc", mycon.connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbSDPbranch.Items.Add(dr[0].ToString());
            }
            mycon.connection().Close();
        }

        private void btnSDPadd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into doctor_table(d_name,d_surname,d_branch,d_idfcard,d_phone,d_password,d_sex) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", mycon.connection());
            com.Parameters.AddWithValue("@p1",txtbSDPname.Text);
            com.Parameters.AddWithValue("@p2", txtbSDPsname.Text);
            com.Parameters.AddWithValue("@p3", cmbSDPbranch.Text);
            com.Parameters.AddWithValue("@p4", mtxtbSDPidfnum.Text);
            com.Parameters.AddWithValue("@p5", mtxtbSDPphone.Text);
            com.Parameters.AddWithValue("@p6", txtbSDPpassword.Text);
            com.Parameters.AddWithValue("@p7", cmbSDPsex.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Doctor added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtbSDPname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtbSDPsname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbSDPbranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            mtxtbSDPidfnum.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            mtxtbSDPphone.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            txtbSDPpassword.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            cmbSDPsex.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }

        private void btnSDPremove_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("delete from doctor_table where d_idfcard=@p1", mycon.connection());
            com.Parameters.AddWithValue("@p1", mtxtbSDPidfnum.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Record removed!", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSDPupdate_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("update doctor_table set d_name=@p1,d_surname=@p2,d_branch=@p3,d_phone=@p4,d_password=@p5,d_sex=@p6 where d_idfcard=@p7", mycon.connection());
            com.Parameters.AddWithValue("@p1", txtbSDPname.Text);
            com.Parameters.AddWithValue("@p2", txtbSDPsname.Text);
            com.Parameters.AddWithValue("@p3", cmbSDPbranch.Text);
            com.Parameters.AddWithValue("@p4", mtxtbSDPphone.Text);
            com.Parameters.AddWithValue("@p5", txtbSDPpassword.Text);
            com.Parameters.AddWithValue("@p6", cmbSDPsex.Text);
            com.Parameters.AddWithValue("@p7", mtxtbSDPidfnum.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Record updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from doctor_table", mycon.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSDPclear_Click(object sender, EventArgs e)
        {
            txtbSDPname.Text = "";
            txtbSDPsname.Text = "";
            txtbSDPpassword.Text = "";
            mtxtbSDPidfnum.Text = "";
            mtxtbSDPphone.Text = "";
            cmbSDPbranch.Text = "";
            cmbSDPsex.Text = "";

            txtbSDPname.Focus();
        }
    }
}
