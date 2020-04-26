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
                   "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\registration.mdf;Integrated Security=SSPI";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

