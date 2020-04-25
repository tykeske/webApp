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

/*
Author: Vince Amela
Date: 4/19/20
Class: CIS 234A
Assignment: 3
Bugs: 
      *  none at this time 
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
            if (tempNameTextBox.TextLength < 51 && tempNameTextBox.TextLength > 0 && msgBodyTextBox.TextLength < 1001)
            {
                createTemplate();
            }
            else
            {
                MessageBox.Show("You must enter a template name, 1-50 characters.  Msg body field has 1000 character limit.");
            }

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
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
