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
        private static  IConfiguration _configuration;
        private static SqlConnection con= new SqlConnection(_configuration.GetConnectionString("myConn"));
        private static SqlCommand scmd;

         public  DBUtil(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public static int SaveDetails(string query)
        {
            scmd = new SqlCommand(query, con);
            if(con==null)
                con = new SqlConnection(_configuration.GetConnectionString("myConn"));
            con.Open();
            int i = scmd.ExecuteNonQuery();
            con.Close();
            return i;
        }


    }
}
