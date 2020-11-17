using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace PSCAT.Services
{
    public class DBUtil
    {
        private static readonly IConfiguration _configuration;
        private static SqlConnection con;
        private static SqlCommand scmd;

        static DBUtil()
        {
            con = new SqlConnection(_configuration.GetConnectionString("myConn"));
        }

        public static int SaveDetails(string query)
        {
            scmd = new SqlCommand(query, con);
            con.Open();
            int i = scmd.ExecuteNonQuery();
            con.Close();
            return i;
        }


    }
}
