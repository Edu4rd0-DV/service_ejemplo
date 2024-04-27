using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesLogic
{
      public static  class conexion
    {
        public static string conn = @"Data Source=LAPTOP-QFG60LF9\SQLEXPRESS;Initial Catalog = farmacia; Integrated Security = True";
        
        public static IDbConnection cnbd()
        {
            return new SqlConnection(conn);

        }

        public static IDbCommand comando (string cp ,IDbConnection cnp)
        {
            return new SqlCommand(cp, cnp as SqlConnection);
        }
    }
}
