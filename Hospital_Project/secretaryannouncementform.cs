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
    public partial class secretaryannouncementform : Form
    {
        public secretaryannouncementform()
        {
            InitializeComponent();
        }

        sqlmyconnection mycon = new sqlmyconnection();
        private void secretaryannouncementform_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from announcement_table order by a_id asc", mycon.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
