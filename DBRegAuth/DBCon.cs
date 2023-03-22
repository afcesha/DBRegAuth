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
        public static SqlConnection connection = new SqlConnection(@"Data Source = DBSRV\gor2022; Database = Avtozvyk; Integrated Security=true;");

        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection GetCon()
        {
            return connection;
        }
    }
}
