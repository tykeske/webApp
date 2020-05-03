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
Date: 4/30/20
Class: CIS 234A
Assignment: 5
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
        public int subCount = 0;
        public int location;
        public string eList = "";
        public int createdBy = 1;
        public int templateID;
        private void submitButton_Click(object sender, EventArgs e)
        {
            //checks if message box is empty before proceeding
            if (messageTextBox.Text != "" && locationComboBox.SelectedIndex >= 0)
            {

                try
                {
                    //tries to create a mail message object 
                    MailMessage msg = new MailMessage();

                    //address to be sent by
                    msg.From = new MailAddress("PortlandCCPantry@gmail.com");
                    eList = GetQuery(eList);
                    //creates the connection
                    SqlConnection conn = new SqlConnection(connString);

                    //creates a query string to search the database
                    string emailQuery = "DECLARE @listStr VARCHAR(MAX) SELECT @listStr = COALESCE(@listStr+', ' , '') + email_address FROM user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND table2.location_id = 1 SELECT @listStr;";

                    //opens the connection
                    conn.Open();
                    //command to execute query
                   
                    //closes the connection
                    conn.Close();
                    //assigning variables
                    string messageContent = messageTextBox.Text;
                    string createdDate = DateTime.Now.ToString();
                    msg.CC.Add(eList);
                    int count =  GetSubscribers(subCount);
                   
                    //DATABASE ENTRY
                    String insQuery = "INSERT INTO dbo.message_log (message_content, template_id, created_date, created_by, subscriber_count, location_id) VALUES (@messageContent, @templateID, @createdDate, @createdBy, @subCount, @locationID)";
                    //reopens connection
                    conn.Open();
                    using (SqlCommand insCommand = new SqlCommand(insQuery, conn))
                    {
                        try
                        { //inserts values into the correct fields

                            insCommand.Parameters.Add("@messageContent", SqlDbType.NVarChar, 1000).Value = messageContent;
                            //still need to add template_id
                            insCommand.Parameters.Add("@createdDate", SqlDbType.SmallDateTime, 19).Value = createdDate;
                            insCommand.Parameters.Add("@createdBy", SqlDbType.Int).Value = createdBy;
                            insCommand.Parameters.Add("@subCount", SqlDbType.SmallInt).Value = count;
                            insCommand.Parameters.Add("@locationID", SqlDbType.Int).Value = location;
                            if (templateID > 0)
                            {
                                insCommand.Parameters.Add("@templateID", SqlDbType.Int).Value = templateID;
                            }
                            else
                            {
                                insCommand.Parameters.AddWithValue("@templateID", DBNull.Value);
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
            else if (locationComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a location!");
            }
            else
            {
                //message showing the user they must send message with text
                MessageBox.Show("Cannot send blank email. Please enter Text.");
            }
        }
        public int GetSubscribers(int subCount)
        {   SqlConnection conn = new SqlConnection(connString);
            // method doesnt work as I intended will be fixing
            switch (locationComboBox.SelectedIndex) 
            {
                case 0:
                    String sub1Query = "SELECT COUNT(email_address) FROM dbo.user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND location_id = 1";
                    using (SqlCommand subCommand = new SqlCommand(sub1Query, conn))
                    {
                        conn.Open();
                        SqlDataReader subReader = subCommand.ExecuteReader();
                        if (subReader.Read())
                        {
                            int subscribers = subReader.GetInt32(0);
                            subCount = subscribers;
                            return subCount;
                        }
                    }
                    break;
                case 1:
                    String sub2Query = "SELECT COUNT(email_address) FROM dbo.user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND location_id = 2";
                    using (SqlCommand subCommand = new SqlCommand(sub2Query, conn))
                    {
                        conn.Open();
                        SqlDataReader subReader = subCommand.ExecuteReader();
                        if (subReader.Read())
                        {
                            int subscribers = subReader.GetInt32(0);
                            subCount = subscribers;
                            return subCount;
                        }
                    }
                    break;
                case 2:
                    String sub3Query = "SELECT COUNT(email_address) FROM dbo.user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND location_id = 3";
                    using (SqlCommand subCommand = new SqlCommand(sub3Query, conn))
                    {
                        conn.Open();
                        SqlDataReader subReader = subCommand.ExecuteReader();
                        if (subReader.Read())
                        {
                            int subscribers = subReader.GetInt32(0);
                            subCount = subscribers;
                            return subCount;
                        }
                    }
                    break;
                case 3:
                    String sub4Query = "SELECT COUNT(email_address) FROM dbo.user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND location_id = 4";
                    using (SqlCommand subCommand = new SqlCommand(sub4Query, conn))
                    {
                        conn.Open();
                        SqlDataReader subReader = subCommand.ExecuteReader();
                        if (subReader.Read())
                        {
                            int subscribers = subReader.GetInt32(0);
                            subCount = subscribers;
                            return subCount;
                        }
                    }
                    break;
            }
            return subCount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //adds option to select none or all for the comboboxes if they have not template or location preference
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
                conn.Open();
                String tempQuery = "SELECT template_id FROM message_template WHERE template_name = '" + item + "'; ";
                using (SqlCommand sqlCommand = new SqlCommand(tempQuery, conn))
                {
                    SqlDataReader readerTemp = sqlCommand.ExecuteReader();
                    while(readerTemp.Read())
                    {
                        templateID = readerTemp.GetInt32(0);
                    }

                }
                conn.Close();
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
            locationComboBox.SelectedIndex = -1;
            locationComboBox.Text = "Location";
            templateComboBox.SelectedIndex = 0;
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            NotificationLog.Form1 notf = new NotificationLog.Form1();
            notf.ShowDialog();
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection();
                SqlCommand myCommand = new SqlCommand();
                SqlDataReader myDataReader;
                myConnection.ConnectionString = "Data Source=cisdbss.pcc.edu;Initial Catalog=234a_TeamApex;Persist Security Info=True;User ID=234a_TeamApex;Password=^&%_2020_Spring_TeamApex";
                myConnection.Open();
                myCommand.Connection = myConnection; string selected = locationComboBox.SelectedItem.ToString();
                myCommand.CommandText = "SELECT location_id FROM pantry_location WHERE location_name = '" + selected + "'";
                myDataReader = myCommand.ExecuteReader();
                while (myDataReader.Read())
                {
                    location = myDataReader.GetInt32(0); ;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string GetQuery(string eList)
        {   //creates the connection
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //switch statement to differentiate  which users to select from database depending on location
            switch (locationComboBox.SelectedIndex) { 
                case 0:
                    //makes sure list string is empty
                    eList = "";
                    //queries the database
                    string emailQuery = "DECLARE @listStr VARCHAR(MAX) SELECT @listStr = COALESCE(@listStr+', ' , '') + email_address FROM user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND table2.location_id = 1 SELECT @listStr;";
                    using (SqlCommand command = new SqlCommand(emailQuery, conn))
                    {

                        //creates a data reader object
                        SqlDataReader reader = command.ExecuteReader();

                        // If there is data to read, set it to string
                        if (reader.Read())
                        {

                            string locList = reader.GetString(0);
                            //adds list of emails as single concantenated string to be sent with comma delimiters as per the CC format
                            eList = locList;
                        }
                        else
                        {
                            MessageBox.Show("There was an error reading data");
                        }
                    }
                    break;
                case 1:
                    //makes sure list string is empty
                    eList = "";
                    //queries the database
                    string email1Query = "DECLARE @listStr VARCHAR(MAX) SELECT @listStr = COALESCE(@listStr+', ' , '') + email_address FROM user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND table2.location_id = 2 SELECT @listStr;";
                    using (SqlCommand command = new SqlCommand(email1Query, conn))
                    {

                        //creates a data reader object
                        SqlDataReader reader = command.ExecuteReader();

                        // If there is data to read, set it to string
                        if (reader.Read())
                        {

                            string locList = reader.GetString(0);
                            //adds list of emails as single concantenated string to be sent with comma delimiters as per the CC format
                            eList = locList;
                        }
                        else
                        {
                            MessageBox.Show("There was an error reading data");
                        }
                    }
                    break;
                case 2:
                    //makes sure list string is empty
                    eList = "";
                    //queries the database
                    string email2Query = "DECLARE @listStr VARCHAR(MAX) SELECT @listStr = COALESCE(@listStr+', ' , '') + email_address FROM user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND table2.location_id = 3 SELECT @listStr;";
                    using (SqlCommand command = new SqlCommand(email2Query, conn))
                    {

                        //creates a data reader object
                        SqlDataReader reader = command.ExecuteReader();

                        // If there is data to read, set it to string
                        if (reader.Read())
                        {

                            string locList = reader.GetString(0);
                            //adds list of emails as single concantenated string to be sent with comma delimiters as per the CC format
                            eList = locList;
                        }
                        else
                        {
                            MessageBox.Show("There was an error reading data");
                        }
                    }
                    break;
                case 3:
                    //makes sure list string is empty
                    eList = "";
                    //queries the database
                    string email3Query = "DECLARE @listStr VARCHAR(MAX) SELECT @listStr = COALESCE(@listStr+', ' , '') + email_address FROM user_account AS table1 JOIN user_location AS table2 ON table1.user_id = table2.user_id WHERE role_id = 1 AND table2.location_id = 4 SELECT @listStr;";
                    using (SqlCommand command = new SqlCommand(email3Query, conn))
                    {

                        //creates a data reader object
                        SqlDataReader reader = command.ExecuteReader();

                        // If there is data to read, set it to string
                        if (reader.Read())
                        {

                            string locList = reader.GetString(0);
                            //adds list of emails as single concantenated string to be sent with comma delimiters as per the CC format
                            eList = locList;
                        }
                        else
                        {
                            MessageBox.Show("There was an error reading data");
                        }
                    }
                    break;
            }
            return eList; 
        }
    }
}

