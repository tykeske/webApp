using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibBecca
{
    //initiates connection string
    public static class DataConn
    { 
        const String connString = "Data Source=cisdbss.pcc.edu;Initial Catalog=234a_TeamApex;Persist Security Info=True;User ID=234a_TeamApex;Password=^&%_2020_Spring_TeamApex";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }
    }
}
