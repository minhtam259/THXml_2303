using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THXml
{
    class connectDB
    {
        public static SqlConnection DataConnection()
        {
            string connectionString = null;
            connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=XML2303;User ID=sa;Password=123";
            SqlConnection cnn = new SqlConnection(connectionString);
            return cnn;
        }
    }
}
