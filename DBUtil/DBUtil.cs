using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtil
{
    public class DBUtil
    {
        public SqlConnection GetConnection()
        {
            string datasource = @"localhost";

            string database = "QLSVien1";
            string username = "sa";
            string password = "123456";

            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
