using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


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

        //form load fills the datagrid
        private void templateCreationForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //loadData loads data from dbo.message_template into the datagrid 
        private void loadData()
        {
            string connectionString = "Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex";
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    var select = "SELECT template_id, template_name, message_content, created_date, updated_date, created_by, updated_by FROM dbo.message_template";
                    var c = new SqlConnection("Data Source=cisdbss.pcc.edu; Initial Catalog=234a_TeamApex; User id=234a_TeamApex; Password=^&%_2020_Spring_TeamApex"); // Your Connection String here
                    c.Open();
                    var dataAdapter = new SqlDataAdapter(select, c);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    c.Close();
                }

                //sets datagrid column max and min width
                int maxWidth = 170;
                int minWidth = 70;
                foreach(DataGridViewColumn c in dataGridView1.Columns)                 
                if (c.Width > maxWidth)
                    {
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        c.Width = maxWidth;
                    }
                else if (c.Width < minWidth)
                    {
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        c.Width = minWidth;
                    }

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        //loadDataGrid refreshes that datagrid after a save
        private void loadDataGrid()
        {
            loadData();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        //saveButton click event calls saveCheck, a method for determining whether save is new or an edit, also confirms with user
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


        //modifyTemplate uses the update command to edit only rows where template_id matches the text value in tempID_TextBox
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
                    command.Parameters.AddWithValue("@templateName", templateName);
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
        //once created loadDataGrid method is called to refresh that datagrid
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
                        connection.Close();

                        // Check Error                        
                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                        connection.Close();
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


        //clearMethod removes text values from all textboxes including tempID_TextBox
        //this allows user to create a new template
        private void clearButton_Click(object sender, EventArgs e)
        {
            tempID_TextBox.Text = string.Empty;
            tempNameTextBox.Text = string.Empty;
            msgBodyTextBox.Text = string.Empty;
        }

        private void deleteTagButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must discuss with team what the functionality of this should be.");
        }

        //navigates back to the main menu
        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //keychar check for tagTextBox3, where user enters custom tags
        //only allows alphabetical inputs
        private void tagTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        //binds textbox for template_id, template_name and message_content to the datagrid
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //tempID for template_id
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string tempID = Convert.ToString(selectedRow.Cells["template_id"].Value);
                tempID_TextBox.Text = tempID;
                
                //tempName for template_name
                int selectedrowindex2 = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow2 = dataGridView1.Rows[selectedrowindex2];
                string tempName = Convert.ToString(selectedRow2.Cells["template_name"].Value);
                tempNameTextBox.Text = tempName;

                //msgContent for message_content
                int selectedrowindex3 = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow3 = dataGridView1.Rows[selectedrowindex3];
                string msgContent = Convert.ToString(selectedRow3.Cells["message_content"].Value);
                msgBodyTextBox.Text = msgContent;
            }
            
        }
    }
}
