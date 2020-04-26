using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TemplateCreation
{
    /// <summary>
    /// contains static information about the Registartion database
    /// </summary>
    public static class templateDataBase
    {
        /// <summary>
        /// Gets a connection object to reference the registration
        /// Can easily change where all data is coming from by changing this one statement
        /// </summary>
        /// <returns>Connection to the Registration data base</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                   "Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

