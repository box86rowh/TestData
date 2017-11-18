using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
