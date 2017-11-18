using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.Utils
{
    public static class DbUtil
    {
        public static IDbConnection GetConnection()
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString);
            return conn;
        }
    }
}
