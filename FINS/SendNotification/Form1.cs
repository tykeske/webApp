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
Date: 4/29/20
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
                    // will be adding location functionality soon

                    //calls GetSubscribers method
                    // *doesn't work* need to figure out another way
                    //GetSubscribers(subCount);
                    int locationID = Int32.Parse(locationLabel.Text);
                    //DATABASE ENTRY
                    String insQuery = "INSERT INTO dbo.message_log (message_content, created_date, created_by, subscriber_count, location_id) VALUES (@messageContent, @createdDate, @createdBy, @subCount, @locationID)";
                    //reopens connection
                    conn.Open();
                    using (SqlCommand insCommand = new SqlCommand(insQuery, conn))
                    {
                        try
                        { //inserts values into the correct fields

                            //need to add template and location functionality as well as fix the subcount
                            insCommand.Parameters.Add("@messageContent", SqlDbType.NVarChar, 1000).Value = messageContent;
                            //still need to add template_id
                            insCommand.Parameters.Add("@createdDate", SqlDbType.SmallDateTime, 19).Value = createdDate;
                            insCommand.Parameters.Add("@createdBy", SqlDbType.Int).Value = createdBy;
                            insCommand.Parameters.Add("@subCount", SqlDbType.SmallInt).Value = subCount;
                            if (locationID > 0)
                            {
                                insCommand.Parameters.Add("@locationID", SqlDbType.Int).Value = locationID;
                            }
                            else
                            {
                                insCommand.Parameters.Add("@locationID", SqlDbType.Int).Value = null;
                            }
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
        {   // method doesnt work as I intended will be fixing
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

        private void Form1_Load(object sender, EventArgs e)
        {   
            //adds option to select none or all for the comboboxes if they have not template or location preference
            locationComboBox.Items.Add("All Locations");
            templateComboBox.Items.Add("No Template");
            try
            {   //adds templates to combo box
                String tempQuery = "SELECT template_name FROM message_template ORDER BY template_name ASC; ";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                using (SqlCommand tempComm = new SqlCommand(tempQuery, conn))
                {
                    SqlDataReader dataReader = tempComm.ExecuteReader();
                    while (dataReader.Read())
                    {
                        templateComboBox.Items.Add(dataReader.GetString(0));
                    }
                    conn.Close();
                }
                //searches database for locatins and adds them to the comboBox
                String locQuery = "SELECT location_name FROM pantry_location; ";
                using (SqlCommand locComm = new SqlCommand(locQuery, conn))
                {
                    conn.Open();
                    SqlDataReader dataReaderLoc = locComm.ExecuteReader();
                    while (dataReaderLoc.Read())
                    {
                        //adds locations to combobox
                        locationComboBox.Items.Add(dataReaderLoc.GetString(0));

                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void templateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {   //searches the database and adds templates to the combobox
                string item = templateComboBox.SelectedItem.ToString();
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                String msgQuery = "SELECT message_content FROM message_template WHERE template_name = '" + item + "'; ";
                using (SqlCommand command = new SqlCommand(msgQuery, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //adds the selected template text to the textbox
                        messageTextBox.Text = reader.GetString(0);
                    }
                }
                conn.Close();
                tempLabel.Text = templateComboBox.SelectedIndex.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {   
            //clears the textbox and combo boxes
            messageTextBox.Text = string.Empty;
            locationComboBox.SelectedIndex = 0;
            templateComboBox.SelectedIndex = 0;
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            //button brings us to Notification Log form
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //assigns id numbers to the combobox items
            string location = locationComboBox.SelectedItem.ToString();

            switch (location)
            {
                case "All Locations":
                    locationLabel.Text = "0";
                    break;
                case "Cascade":
                    locationLabel.Text = "1";
                    break;
                case "Rock Creek":
                    locationLabel.Text = "2";
                    break;
                case "Southeast":
                    locationLabel.Text = "3";
                    break;
                case "Sylvania":
                    locationLabel.Text = "4"; 
                    break;
            }
        }
    }
}
