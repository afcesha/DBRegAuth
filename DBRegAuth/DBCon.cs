using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBRegAuth
{
    class DBCon
    {
        SqlConnection con1 = new SqlConnection(@"Data Source = DBSRV\gor2022; Database = 007v2Nayashov; Integrated Security=true;");

        public void OpenCon()
        {
            if (con1.State == System.Data.ConnectionState.Closed)
            {
                con1.Open();
            }
        }
        public void CloseCon()
        {
            if (con1.State == System.Data.ConnectionState.Open)
            {
                con1.Close();
            }
        }
        public SqlConnection GetCon()
        {
            return con1;
        }
    }
}
