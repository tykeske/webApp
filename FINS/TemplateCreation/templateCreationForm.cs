﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


/*
Author: Vince Amela
Date: 4/19/20
Class: CIS 234A
Assignment: 3
Bugs: 
      *  none at this time 
      *  
command.Parameters.Add("@templateName", SqlDbType.NVarChar, 50).Value = templateName;
                        command.Parameters.Add("@msgContent", SqlDbType.NVarChar, 1000).Value = msgContent;
                        command.Parameters.Add("@created_date", SqlDbType.SmallDateTime, 19).Value = createDate;
                        command.Parameters.Add("@updated_date", SqlDbType.SmallDateTime, 19).Value = upDated;
                        command.Parameters.Add("@created_by", SqlDbType.Int, 50).Value = createdBy;
                        command.Parameters.Add("@updated_by", SqlDbType.Int, 50).Value = updatedBy;      * 
*/


namespace TemplateCreation
{
   

    public partial class templateCreationForm : Form
    {
        public templateCreationForm()
        {
            InitializeComponent();
        }


        //saveButton click event validates whether inputs from user conform to template name and message content fields
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (tempID_TextBox.TextLength > 0 && tempNameTextBox.TextLength < 51 && tempNameTextBox.TextLength > 0 && msgBodyTextBox.TextLength < 1001)
            {
                 saveCheck();
            }
            else if (tempNameTextBox.TextLength < 51 && tempNameTextBox.TextLength > 0 && msgBodyTextBox.TextLength < 1001)
            {
                createTemplate();
            }
            else
            {
                MessageBox.Show("You must enter a template name, 1-50 characters.  Msg body field has 1000 character limit.");
            }

        }


        /*

                         command.Parameters.Add("@templateName", SqlDbType.NVarChar, 50).Value = templateName;
                        command.Parameters.Add("@msgContent", SqlDbType.NVarChar, 1000).Value = msgContent;
                        command.Parameters.Add("@created_date", SqlDbType.SmallDateTime, 19).Value = createDate;
                        command.Parameters.Add("@updated_date", SqlDbType.SmallDateTime, 19).Value = upDated;
                        command.Parameters.Add("@created_by", SqlDbType.Int, 50).Value = createdBy;
                        command.Parameters.Add("@updated_by", SqlDbType.Int, 50).Value = updatedBy;      * 
*/

        private void linqTest()
        {


            
            /*
            try
            {
            
                string templateID = tempID_TextBox.Text;
                string templateName = tempNameTextBox.Text;
                string msgContent = msgBodyTextBox.Text;                
                string upDated = DateTime.Now.ToString();
                int upDatedBy = 1;

                
               

                SqlConnection connection = new SqlConnection("Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex");
               
                String query = "UPDATE dbo.message_template" + "(template_id, template_name, message_content, updated_date, updated_by) " + "SET template_id=@templateID,template_name=@templateName,message_content=@msgContent,updated_date=@upDated,updated_by=@upDatedBy)" + "(WHERE template_id = @templateID)";

                SqlCommand command = new SqlCommand(query, connection);
                 
                command.Parameters.Add("@templateID", SqlDbType.NVarChar, 50).Value = templateID;
                command.Parameters.Add("@templateName", SqlDbType.NVarChar, 50).Value = templateName;
                command.Parameters.Add("@msgContent", SqlDbType.NVarChar, 1000).Value = msgContent;
                command.Parameters.Add("@upDated", SqlDbType.SmallDateTime, 19).Value = upDated;
                command.Parameters.Add("@upDatedBy", SqlDbType.Int, 50).Value = upDatedBy;
                connection.Open();                      
                int result = command.ExecuteNonQuery();
                 */
            int templateID = int.Parse(tempID_TextBox.Text); 
            string templateName = tempNameTextBox.Text;
            string msgContent = msgBodyTextBox.Text;                
            string upDated = DateTime.Now.ToString();
            int upDatedBy = 1;

            string connectionString = "Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex";

            using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                { 
                command.CommandText = "UPDATE dbo.message_template SET template_name=@templateName, message_content=@msgContent, updated_date=@upDated, updated_by=@upDatedBy WHERE template_name = @templateName";
                //command.Parameters.IsReadOnly("@templateID");                                
                //command.Parameters.AddWithValue("@templateID", templateID);
                command.Parameters.AddWithValue("@templateName",  templateName);
                command.Parameters.AddWithValue("@msgContent", msgContent);
                command.Parameters.AddWithValue("@upDated", upDated);
                command.Parameters.AddWithValue("@upDatedBy", upDatedBy);
                
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                }
  


            /*
            try
            {
            
                string templateID = tempID_TextBox.Text;
                string templateName = tempNameTextBox.Text;
                string msgContent = msgBodyTextBox.Text;                
                string upDated = DateTime.Now.ToString();
                int upDatedBy = 1;

                
               

                SqlConnection connection = new SqlConnection("Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex");
               
                String query = "UPDATE dbo.message_template" + "(template_id, template_name, message_content, updated_date, updated_by) " + "SET template_id=@templateID,template_name=@templateName,message_content=@msgContent,updated_date=@upDated,updated_by=@upDatedBy)" + "(WHERE template_id = @templateID)";

                SqlCommand command = new SqlCommand(query, connection);
                 
                command.Parameters.Add("@templateID", SqlDbType.NVarChar, 50).Value = templateID;
                command.Parameters.Add("@templateName", SqlDbType.NVarChar, 50).Value = templateName;
                command.Parameters.Add("@msgContent", SqlDbType.NVarChar, 1000).Value = msgContent;
                command.Parameters.Add("@upDated", SqlDbType.SmallDateTime, 19).Value = upDated;
                command.Parameters.Add("@upDatedBy", SqlDbType.Int, 50).Value = upDatedBy;
                connection.Open();                      
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                Console.WriteLine("Error inserting data into Database!");
              
                
                MessageBox.Show("Template Created!");
                }
            
            catch
            {
            
                MessageBox.Show("something went wrong"); 
            
            }
           */
           
            /*
            tApex db = new tApex(@"Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex");

            // Query for a specific customer.
            var tID =
            (from Table in db.tApex
            where Table.template_id == tempID_TextBox.Text
            select Table);template_id();

            // Change the name of the contact.
            tID.template_id == tempID_TextBox.Text;          
            // Ask the DataContext to save all the changes.
            db.SubmitChanges();
            */
        }

        private void saveCheck()
        {

            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                templateOverwrite();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Nope");
            }

        }

        private void templateOverwrite()
        {
            
        }





        private void templateReader()
        {

          
            /*
            try
            {
               SqlConnection templateConnection = new SqlConnection();
                SqlCommand templateCommand = new SqlCommand();
                SqlDataReader templateDataReader;
               templateConnection.ConnectionString = "Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex";
                templateConnection.Open();
                templateCommand.Connection = templateConnection;
               templateCommand.CommandText = "Select template_name, message_content from dbo.message_template";
                templateDataReader = templateCommand.ExecuteReader();
                while (templateDataReader.Read())
                    templateListBox.Items.Add(templateDataReader["template_name"]);
                templateDataReader.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            */
        }

        //create template grabs values for required dbo.message_template fields
        //values are passed into rows with proper sql formating
        //try-catch statement to handle any exceptions
        private void createTemplate()
        {
            try
            {
                string templateName = tempNameTextBox.Text;
                string msgContent = msgBodyTextBox.Text;
                string createDate = DateTime.Now.ToString();
                string upDated = DateTime.Now.ToString();
                int createdBy = 1;
                int updatedBy = 1;

                using (SqlConnection connection = new SqlConnection("Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex"))
                {
                    String query = "INSERT INTO dbo.message_template (template_name, message_content, created_date, updated_date, created_by, updated_by) VALUES (@templateName,@msgContent,@created_date, @updated_date, @created_by, @updated_by)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@templateName", SqlDbType.NVarChar, 50).Value = templateName;
                        command.Parameters.Add("@msgContent", SqlDbType.NVarChar, 1000).Value = msgContent;
                        command.Parameters.Add("@created_date", SqlDbType.SmallDateTime, 19).Value = createDate;
                        command.Parameters.Add("@updated_date", SqlDbType.SmallDateTime, 19).Value = upDated;
                        command.Parameters.Add("@created_by", SqlDbType.Int, 50).Value = createdBy;
                        command.Parameters.Add("@updated_by", SqlDbType.Int, 50).Value = updatedBy;
                        connection.Open();                      
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                        
                    }
                }
                MessageBox.Show("Template Created!");

            }
            catch
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        //insert tag buttons append standard and user created tags into form
        private void insertTagButton1_Click(object sender, EventArgs e)
        {
            string tagValue = "<" + tagTextBox1.Text + ">";
            msgBodyTextBox.AppendText(tagValue);
        }

        private void insertTagButton2_Click(object sender, EventArgs e)
        {
            string tagValue = "<" + tagTextBox2.Text + ">";
            msgBodyTextBox.AppendText(tagValue);
        }

        private void insertTagButton3_Click(object sender, EventArgs e)
        {
            string tagValue = "<" + tagTextBox3.Text + ">";
            msgBodyTextBox.AppendText(tagValue);
        }

        private void templateCreationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_234a_TeamApexDataSet.message_template' table. You can move, or remove it, as needed.
            // adding a line
            this.message_templateTableAdapter1.Fill(this._234a_TeamApexDataSet.message_template);
            dataGridView1.ClearSelection();

        }

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            linqTest();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearMethod();
        }

        private void clearMethod()
        {
            dataGridView1.ClearSelection();
            //tempID_TextBox.Text = string.Empty;
            //tempNameTextBox.Text = string.Empty;
            //msgBodyTextBox.Text = string.Empty;           
        }
    }
}
