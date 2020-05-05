using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Created by Tyler Keske
//CIS-234A
//v.1 Sprint1
//4-18-2020
//This application will retrieve data from the TeamApex SQL database and display it's contents to the user.

namespace notificationLogTylerKeske
{
    public partial class NotificationLog : Form
    {
        public NotificationLog(int userID)
        {
            InitializeComponent();
        }

        //declaring the variable "connectionString" that connects the application to the TeamApex SQL Server Managment Studio database.
        public string connectionString = "Data Source=cisdbss.pcc.edu;Initial Catalog=234a_TeamApex;Persist Security Info=True;User ID=234a_TeamApex;Password=^&%_2020_Spring_TeamApex";

        private void Form1_Load(object sender, EventArgs e)
        {
            //establishes a working connection with the database
            //load data into data grid view prior to date search.
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "SELECT message_date, message_content, message_by, template_used, subscriber_count FROM notification_log ORDER BY message_date DESC";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable datTa = new DataTable();
                sqlDa.Fill(datTa);
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = datTa;
            }
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            //establishes a working connection with the database
            //creation of an SQL query that establishes what contents will be present in the dataGridView
            //date and time picker values are taken declared by user which is then implemented into the SQL query
            //dataGridView is then populated
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "SELECT message_date, message_content, message_by, template_used, subscriber_count FROM notification_log WHERE message_date BETWEEN @date1 and @date2 ORDER BY message_date DESC";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable datTa = new DataTable();
                sqlDa.SelectCommand.Parameters.AddWithValue("@date1", fromDateTimePicker.Value);
                sqlDa.SelectCommand.Parameters.AddWithValue("@date2", toDateTimePicker.Value);
                sqlDa.Fill(datTa);
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = datTa;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
