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
Date: 4/29/20
Class: CIS 234A
Assignment: 4
Bugs: 
        * None that I'm aware of however I have experienced so many IDE issues on this assignment it's really hard to be sure. 
        * I wanted to use classes but I haven't had time to address the VS2019 Caret bug, yet. 
      
*/

namespace TemplateCreation
{
   

    public partial class templateCreationForm : Form
    {
        public templateCreationForm()
        {
            InitializeComponent();
        }


        //saveButton click event calls saveCheck, a method for determining whethere save is new or an edit, also confirms with user
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveCheck();
        }

        //saveCheck evalutes whether the user is trying to save a new template or edit an existing template based on the text length of tempID_TextBox.Text
        //if there is a value present in tempID_TextBox, the user is asked to confirm that they want to save changes
        //if there is no value present in tempID_TextBox then the program simply creates a new template/row
        private void saveCheck()
        {
            if (tempID_TextBox.TextLength > 0 && tempNameTextBox.TextLength < 51 && tempNameTextBox.TextLength > 0 && msgBodyTextBox.TextLength < 1001)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save changes?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Changes saved.");
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


        //modifyTemplate is very similar to createTemplate however it uses the update command to edit rows based on template_id value
        //the template_id  valueis stored in a read-only textbox and that is pulled in as a parameter in the WHERE clause
        //this method only adds content to template_name, message_content, updated_date and updated_by
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


        //create template creates a brand new row in dbo.message_template
        //try-catch statement for exceptions
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

        //form load fills the datagrid
        private void templateCreationForm_Load(object sender, EventArgs e)
        {
            this.message_templateTableAdapter1.Fill(this._234a_TeamApexDataSet.message_template);
            dataGridView1.ClearSelection();
        }
        
        //loadDataGrid is called by template creation/modification methods after successful execution of sql commands, thus displaying new row or edits to user
        private void loadDataGrid()
        {
            this.message_templateTableAdapter1.Fill(this._234a_TeamApexDataSet.message_template);            
            dataGridView1.ClearSelection();           
        }

        //clearButton calls the clear method, the primary mechanism for creating a brand new form
        //the user sees a button called "New Template(clear)"
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearMethod();
        }

        //clearMethod removes text values from all textboxes including tempID_TextBox
        //once called, tempID_TextBox is set to string.Empty
        private void clearMethod()
        {            
            tempID_TextBox.Text = string.Empty;
            tempNameTextBox.Text = string.Empty;
            msgBodyTextBox.Text = string.Empty;           
        }

        private void deleteTagButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must discuss with team what the functionality of this should be.");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
