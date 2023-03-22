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
    public partial class secretarybranchpanform : Form
    {
        public secretarybranchpanform()
        {
            InitializeComponent();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        private void secretarybranchpanform_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from branch_table order by b_id asc", mycon.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSBPclear_Click(object sender, EventArgs e)
        {
            txtbSBPid.Text = "";
            txtbSBPname.Text = "";
            txtbSBPid.Focus();
        }

        private void btnSBPadd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into branch_table(b_name) values(@p1)", mycon.connection());
            com.Parameters.AddWithValue("@p1", txtbSBPname.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Branch added!", "Branch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSBPremove_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("delete from branch_table where b_id=@p1", mycon.connection());
            com.Parameters.AddWithValue("@p1", txtbSBPid.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Branch deleted!", "Branch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtbSBPid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtbSBPname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void btnSBPupdate_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("update branch_table set b_name=@p1 where b_id=@p2", mycon.connection());
            com.Parameters.AddWithValue("@p1", txtbSBPname.Text);
            com.Parameters.AddWithValue("@p2", txtbSBPid.Text);
            com.ExecuteNonQuery();
            mycon.connection().Close();
            MessageBox.Show("Branch updated!", "Branch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
