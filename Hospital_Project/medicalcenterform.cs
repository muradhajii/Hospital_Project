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
    public partial class medicalcenterform : Form
    {
        public medicalcenterform()
        {
            InitializeComponent();
        }

        private void btnMCpatientlogin_Click(object sender, EventArgs e)
        {
            patientloginform pl = new patientloginform();
            pl.Show();
            this.Hide();
        }

        private void btnMCsecrlogin_Click(object sender, EventArgs e)
        {
            secretaryloginform sl = new secretaryloginform();
            sl.Show();
            this.Hide();
        }

        private void btnMCdoclogin_Click(object sender, EventArgs e)
        {
            doctorloginform dl = new doctorloginform();
            dl.Show();
            this.Hide();
        }
    }
}
