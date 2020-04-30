namespace TemplateCreation
{
    partial class templateCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // templateCreationForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "templateCreationForm";
            this.Load += new System.EventHandler(this.templateCreationForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tempNameLabel;
        private System.Windows.Forms.TextBox tempNameTextBox;
        private System.Windows.Forms.TextBox tagTextBox3;
        private System.Windows.Forms.TextBox tagTextBox1;
        private System.Windows.Forms.TextBox tagTextBox2;
        private System.Windows.Forms.TextBox msgBodyTextBox;
        private System.Windows.Forms.GroupBox tagGroupBox;
        private System.Windows.Forms.Button deleteTagButton1;
        private System.Windows.Forms.Button insertTagButton2;
        private System.Windows.Forms.Button deleteTagButton2;
        private System.Windows.Forms.Button deleteTagButton3;
        private System.Windows.Forms.Button insertTagButton3;
        private System.Windows.Forms.Button insertTagButton1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox templatesGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _234a_TeamApexDataSet _234a_TeamApexDataSet;
        private System.Windows.Forms.BindingSource aTeamApexDataSetBindingSource;
        private _234a_TeamApexDataSetTableAdapters.message_templateTableAdapter message_templateTableAdapter1;
        private System.Windows.Forms.TextBox tempID_TextBox;
        private System.Windows.Forms.Label tempID_Label;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn template_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn template_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templatenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagecontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button loadListButton;
        private System.Windows.Forms.ListView templateListView;

    }
}

