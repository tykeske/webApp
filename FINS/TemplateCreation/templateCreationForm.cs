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
Date: 4/26/20
Class: CIS 234A
Assignment: 4
Bugs: 


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
            saveCheck();

        }

        private void saveCheck()
        {
            if (tempID_TextBox.TextLength > 0 && tempNameTextBox.TextLength < 51 && tempNameTextBox.TextLength > 0 && msgBodyTextBox.TextLength < 1001)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save changes?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("New Template created, scroll down the list to find your new entry");
                    modifyTemplate();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Okay then, you can save a new row or select another to edit");
                }
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



        private void modifyTemplate()
        {
            try
            {   
                int templateID = int.Parse(tempID_TextBox.Text); 
                string templateName = tempNameTextBox.Text;
                string msgContent = msgBodyTextBox.Text;                
                string upDated = DateTime.Now.ToString();
                int upDatedBy = 1;

                string connectionString = "Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                { 
                command.CommandText = "UPDATE dbo.message_template SET template_name=@templateName, message_content=@msgContent, updated_date=@upDated, updated_by=@upDatedBy WHERE template_id = @template_ID";                
                command.Parameters.Add("@template_ID", SqlDbType.Int).Value = templateID; //adds templateID variable as a parameter for the WHERE clause
                command.Parameters.AddWithValue("@templateName",  templateName);
                command.Parameters.AddWithValue("@msgContent", msgContent);
                command.Parameters.AddWithValue("@upDated", upDated);
                command.Parameters.AddWithValue("@upDatedBy", upDatedBy); 
                
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
                }
             loadDataGrid();
            }
            catch
            {
            MessageBox.Show("Something went wrong");
            }
            
        }

    
        private void templateReader()
        {      
            
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
                loadDataGrid();
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

        private void loadDataGrid()
        {
            this.message_templateTableAdapter1.Fill(this._234a_TeamApexDataSet.message_template);            
            dataGridView1.ClearSelection();           
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {
           //remove this
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("saveAsButton disabled");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearMethod();
        }

        private void clearMethod()
        {            
            tempID_TextBox.Text = string.Empty;
            tempNameTextBox.Text = string.Empty;
            msgBodyTextBox.Text = string.Empty;           
        }
    }
}
