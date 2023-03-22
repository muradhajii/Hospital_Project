using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Project
{
    internal class sqlmyconnection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=WIN-K94OOO3DLN6\\SQL2019;Initial Catalog=HospitalProject;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
