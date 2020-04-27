using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

/*
Author: Becca Menefee-Scheets
Date: 4/21/20
Class: CIS 234A
Assignment: 4
Bugs: none
*/
namespace SendNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //connection string
        private string connString = "Data Source=cisdbss.pcc.edu;Initial Catalog=234a_TeamApex;Persist Security Info=True;User ID=234a_TeamApex;Password=^&%_2020_Spring_TeamApex";

        private void submitButton_Click(object sender, EventArgs e)
        {
            //checks if message box is empty before proceeding
            if (messageTextBox.Text != "")
            {

                try
                {
                    //tries to create a mail message object 
                    MailMessage msg = new MailMessage();

                    //address to be sent by
                    msg.From = new MailAddress("PortlandCCPantry@gmail.com");

                    //creates the connection
                    SqlConnection conn = new SqlConnection(connString);

                    //creates a query string to search the database
                    string emailQuery = "DECLARE @listStr VARCHAR(MAX) SELECT @listStr = COALESCE(@listStr+', ' , '') + email_address FROM user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND table2.location_id = 1 SELECT @listStr;";
                    //opens the connection
                    conn.Open();
                    //command to execute query
                    using (SqlCommand command = new SqlCommand(emailQuery, conn))
                    {

                        //creates a data reader object
                        SqlDataReader reader = command.ExecuteReader();

                        // If there is data to read, set it to string
                        if (reader.Read())
                        {

                            string eList = reader.GetString(0);
                            //adds list of emails as single concantenated string to be sent with comma delimiters as per the CC format
                            msg.CC.Add(eList);
                        }
                        else
                        {
                            MessageBox.Show("There was an error reading data");
                        }
                    }
                    //closes the connection
                    conn.Close();
                    //assigning variables
                    string messageContent = messageTextBox.Text;
                    string createdDate = DateTime.Now.ToString();
                    int createdBy = 1;
                    int subCount = 0;
                    int locationID = 1;
                    //calls GetSubscribers method
                    GetSubscribers(subCount);

                    //DATABASE ENTRY
                    String insQuery = "INSERT INTO dbo.message_log (message_content, created_date, created_by, subscriber_count, location_id) VALUES (@messageContent, @createdDate, @createdBy, @subCount, @locationID)";
                    //reopens connection
                    conn.Open();
                    using (SqlCommand insCommand = new SqlCommand(insQuery, conn))
                    {
                        try
                        { //inserts values into the correct fields
                            insCommand.Parameters.Add("@messageContent", SqlDbType.NVarChar, 1000).Value = messageContent;
                            insCommand.Parameters.Add("@createdDate", SqlDbType.SmallDateTime, 19).Value = createdDate;
                            insCommand.Parameters.Add("@createdBy", SqlDbType.Int).Value = createdBy;
                            insCommand.Parameters.Add("@subCount", SqlDbType.SmallInt).Value = subCount;
                            insCommand.Parameters.Add("@locationID", SqlDbType.Int).Value = locationID;
                            int result = insCommand.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                            {
                                Console.WriteLine("Error inserting data into Database!");
                            }
                        }
                        catch (Exception ex)
                        { //show error in messagebox
                            MessageBox.Show(ex.Message);
                        }
                    }
                    conn.Close();
                    //message subject
                    msg.Subject = "Test";
                    //message body
                    msg.Body = messageTextBox.Text;

                    //creates a new smtpClient class
                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    NetworkCredential ntcd = new NetworkCredential();
                    //login information for email to be sent from and port information
                    ntcd.UserName = "PortlandCCPantry@gmail.com";
                    ntcd.Password = "Panther20!";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    //send the message
                    smt.Send(msg);
                    MessageBox.Show("Email was sent!");

                }
                catch (Exception ex)
                {
                    //displays error description
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //message showing the user they must send message with text
                MessageBox.Show("Cannot send blank email. Please enter Text.");
            }
        }
        private int GetSubscribers(int subCount)
        {
            String subQuery = "SELECT COUNT(email_address) FROM dbo.user_account WHERE role_id = 2";
            SqlConnection conn = new SqlConnection(connString);
            using (SqlCommand subCommand = new SqlCommand(subQuery, conn))
            {
                conn.Open();
                SqlDataReader subReader = subCommand.ExecuteReader();
                if (subReader.Read())
                {
                    subCount = subReader.GetInt32(0);

                    //message box for testing 
                    MessageBox.Show(subCount.ToString());
                    return subCount;
                }
                return subCount;
            }
        }
    }
}
