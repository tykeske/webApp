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
Assignment: 3
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
                    string emailQuery = "IF ((SELECT count(email_address) FROM dbo.user_account) > 1) BEGIN SELECT email_address = COALESCE(email_address + ',', '') FROM user_account WHERE role_id = 2 END ELSE SELECT email_address FROM user_account WHERE role_id = 2";

                    //command to execute query
                    using (SqlCommand command = new SqlCommand(emailQuery, conn))
                    {
                        //opens the connection
                        conn.Open();

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
    }
}
