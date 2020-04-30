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
            this.components = new System.ComponentModel.Container();
            this.tempNameLabel = new System.Windows.Forms.Label();
            this.tempNameTextBox = new System.Windows.Forms.TextBox();
            this.aTeamApexDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._234a_TeamApexDataSet = new TemplateCreation._234a_TeamApexDataSet();
            this.tagTextBox3 = new System.Windows.Forms.TextBox();
            this.tagTextBox1 = new System.Windows.Forms.TextBox();
            this.tagTextBox2 = new System.Windows.Forms.TextBox();
            this.msgBodyTextBox = new System.Windows.Forms.TextBox();
            this.tagGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteTagButton1 = new System.Windows.Forms.Button();
            this.insertTagButton2 = new System.Windows.Forms.Button();
            this.deleteTagButton2 = new System.Windows.Forms.Button();
            this.deleteTagButton3 = new System.Windows.Forms.Button();
            this.insertTagButton3 = new System.Windows.Forms.Button();
            this.insertTagButton1 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.templatesGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.tempID_TextBox = new System.Windows.Forms.TextBox();
            this.tempID_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.template_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.template_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templatenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagecontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_templateTableAdapter1 = new TemplateCreation._234a_TeamApexDataSetTableAdapters.message_templateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aTeamApexDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._234a_TeamApexDataSet)).BeginInit();
            this.tagGroupBox.SuspendLayout();
            this.templatesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tempNameLabel
            // 
            this.tempNameLabel.AutoSize = true;
            this.tempNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempNameLabel.Location = new System.Drawing.Point(6, 283);
            this.tempNameLabel.Name = "tempNameLabel";
            this.tempNameLabel.Size = new System.Drawing.Size(99, 15);
            this.tempNameLabel.TabIndex = 0;
            this.tempNameLabel.Text = "Template Name:";
            // 
            // tempNameTextBox
            // 
            this.tempNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTeamApexDataSetBindingSource, "template_name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tempNameTextBox.Location = new System.Drawing.Point(111, 278);
            this.tempNameTextBox.Name = "tempNameTextBox";
            this.tempNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.tempNameTextBox.TabIndex = 1;
            // 
            // aTeamApexDataSetBindingSource
            // 
            this.aTeamApexDataSetBindingSource.AllowNew = true;
            this.aTeamApexDataSetBindingSource.DataMember = "message_template";
            this.aTeamApexDataSetBindingSource.DataSource = this._234a_TeamApexDataSet;
            // 
            // _234a_TeamApexDataSet
            // 
            this._234a_TeamApexDataSet.DataSetName = "_234a_TeamApexDataSet";
            this._234a_TeamApexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagTextBox3
            // 
            this.tagTextBox3.Location = new System.Drawing.Point(19, 87);
            this.tagTextBox3.Name = "tagTextBox3";
            this.tagTextBox3.Size = new System.Drawing.Size(114, 20);
            this.tagTextBox3.TabIndex = 2;
            // 
            // tagTextBox1
            // 
            this.tagTextBox1.Enabled = false;
            this.tagTextBox1.Location = new System.Drawing.Point(19, 32);
            this.tagTextBox1.Name = "tagTextBox1";
            this.tagTextBox1.Size = new System.Drawing.Size(114, 20);
            this.tagTextBox1.TabIndex = 3;
            this.tagTextBox1.Text = "Location";
            // 
            // tagTextBox2
            // 
            this.tagTextBox2.Enabled = false;
            this.tagTextBox2.Location = new System.Drawing.Point(19, 61);
            this.tagTextBox2.Name = "tagTextBox2";
            this.tagTextBox2.Size = new System.Drawing.Size(114, 20);
            this.tagTextBox2.TabIndex = 4;
            this.tagTextBox2.Text = "FoodType";
            // 
            // msgBodyTextBox
            // 
            this.msgBodyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTeamApexDataSetBindingSource, "message_content", true));
            this.msgBodyTextBox.Location = new System.Drawing.Point(27, 441);
            this.msgBodyTextBox.Multiline = true;
            this.msgBodyTextBox.Name = "msgBodyTextBox";
            this.msgBodyTextBox.Size = new System.Drawing.Size(836, 292);
            this.msgBodyTextBox.TabIndex = 5;
            // 
            // tagGroupBox
            // 
            this.tagGroupBox.Controls.Add(this.deleteTagButton1);
            this.tagGroupBox.Controls.Add(this.insertTagButton2);
            this.tagGroupBox.Controls.Add(this.deleteTagButton2);
            this.tagGroupBox.Controls.Add(this.deleteTagButton3);
            this.tagGroupBox.Controls.Add(this.insertTagButton3);
            this.tagGroupBox.Controls.Add(this.insertTagButton1);
            this.tagGroupBox.Controls.Add(this.tagTextBox2);
            this.tagGroupBox.Controls.Add(this.tagTextBox1);
            this.tagGroupBox.Controls.Add(this.tagTextBox3);
            this.tagGroupBox.Location = new System.Drawing.Point(429, 217);
            this.tagGroupBox.Name = "tagGroupBox";
            this.tagGroupBox.Size = new System.Drawing.Size(362, 134);
            this.tagGroupBox.TabIndex = 6;
            this.tagGroupBox.TabStop = false;
            this.tagGroupBox.Text = "Tags";
            // 
            // deleteTagButton1
            // 
            this.deleteTagButton1.Location = new System.Drawing.Point(274, 29);
            this.deleteTagButton1.Name = "deleteTagButton1";
            this.deleteTagButton1.Size = new System.Drawing.Size(75, 23);
            this.deleteTagButton1.TabIndex = 10;
            this.deleteTagButton1.Text = "Delete Tag";
            this.deleteTagButton1.UseVisualStyleBackColor = true;
            this.deleteTagButton1.Click += new System.EventHandler(this.deleteTagButton1_Click);
            // 
            // insertTagButton2
            // 
            this.insertTagButton2.Location = new System.Drawing.Point(160, 58);
            this.insertTagButton2.Name = "insertTagButton2";
            this.insertTagButton2.Size = new System.Drawing.Size(75, 23);
            this.insertTagButton2.TabIndex = 9;
            this.insertTagButton2.Text = "Insert Tag";
            this.insertTagButton2.UseVisualStyleBackColor = true;
            this.insertTagButton2.Click += new System.EventHandler(this.insertTagButton2_Click);
            // 
            // deleteTagButton2
            // 
            this.deleteTagButton2.Location = new System.Drawing.Point(274, 58);
            this.deleteTagButton2.Name = "deleteTagButton2";
            this.deleteTagButton2.Size = new System.Drawing.Size(75, 23);
            this.deleteTagButton2.TabIndex = 8;
            this.deleteTagButton2.Text = "Delete Tag";
            this.deleteTagButton2.UseVisualStyleBackColor = true;
            // 
            // deleteTagButton3
            // 
            this.deleteTagButton3.Location = new System.Drawing.Point(274, 87);
            this.deleteTagButton3.Name = "deleteTagButton3";
            this.deleteTagButton3.Size = new System.Drawing.Size(75, 23);
            this.deleteTagButton3.TabIndex = 7;
            this.deleteTagButton3.Text = "Delete Tag";
            this.deleteTagButton3.UseVisualStyleBackColor = true;
            // 
            // insertTagButton3
            // 
            this.insertTagButton3.Location = new System.Drawing.Point(160, 87);
            this.insertTagButton3.Name = "insertTagButton3";
            this.insertTagButton3.Size = new System.Drawing.Size(75, 23);
            this.insertTagButton3.TabIndex = 6;
            this.insertTagButton3.Text = "Insert Tag";
            this.insertTagButton3.UseVisualStyleBackColor = true;
            this.insertTagButton3.Click += new System.EventHandler(this.insertTagButton3_Click);
            // 
            // insertTagButton1
            // 
            this.insertTagButton1.Location = new System.Drawing.Point(160, 29);
            this.insertTagButton1.Name = "insertTagButton1";
            this.insertTagButton1.Size = new System.Drawing.Size(75, 23);
            this.insertTagButton1.TabIndex = 5;
            this.insertTagButton1.Text = "Insert Tag";
            this.insertTagButton1.UseVisualStyleBackColor = true;
            this.insertTagButton1.Click += new System.EventHandler(this.insertTagButton1_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(24, 400);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(156, 15);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Please Type Your Message";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(177, 318);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // templatesGroupBox
            // 
            this.templatesGroupBox.Controls.Add(this.clearButton);
            this.templatesGroupBox.Controls.Add(this.tagGroupBox);
            this.templatesGroupBox.Controls.Add(this.tempID_TextBox);
            this.templatesGroupBox.Controls.Add(this.tempID_Label);
            this.templatesGroupBox.Controls.Add(this.dataGridView1);
            this.templatesGroupBox.Controls.Add(this.saveButton);
            this.templatesGroupBox.Controls.Add(this.tempNameTextBox);
            this.templatesGroupBox.Controls.Add(this.tempNameLabel);
            this.templatesGroupBox.Location = new System.Drawing.Point(27, 31);
            this.templatesGroupBox.Name = "templatesGroupBox";
            this.templatesGroupBox.Size = new System.Drawing.Size(836, 366);
            this.templatesGroupBox.TabIndex = 9;
            this.templatesGroupBox.TabStop = false;
            this.templatesGroupBox.Text = "Templates";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 318);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "New Template(&Clear)";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tempID_TextBox
            // 
            this.tempID_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTeamApexDataSetBindingSource, "template_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tempID_TextBox.Location = new System.Drawing.Point(111, 254);
            this.tempID_TextBox.Name = "tempID_TextBox";
            this.tempID_TextBox.ReadOnly = true;
            this.tempID_TextBox.Size = new System.Drawing.Size(54, 20);
            this.tempID_TextBox.TabIndex = 11;
            // 
            // tempID_Label
            // 
            this.tempID_Label.AutoSize = true;
            this.tempID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempID_Label.Location = new System.Drawing.Point(6, 254);
            this.tempID_Label.Name = "tempID_Label";
            this.tempID_Label.Size = new System.Drawing.Size(74, 15);
            this.tempID_Label.TabIndex = 10;
            this.tempID_Label.Text = "Template ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.template_id,
            this.template_name,
            this.message_content,
            this.created_date,
            this.updated_date,
            this.created_by,
            this.updated_by,
            this.templateidDataGridViewTextBoxColumn,
            this.templatenameDataGridViewTextBoxColumn,
            this.messagecontentDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.updateddateDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.updatedbyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aTeamApexDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 174);
            this.dataGridView1.TabIndex = 9;
            // 
            // template_id
            // 
            this.template_id.DataPropertyName = "template_id";
            this.template_id.HeaderText = "template_id";
            this.template_id.Name = "template_id";
            this.template_id.ReadOnly = true;
            this.template_id.Width = 86;
            // 
            // template_name
            // 
            this.template_name.DataPropertyName = "template_name";
            this.template_name.HeaderText = "template_name";
            this.template_name.Name = "template_name";
            this.template_name.ReadOnly = true;
            this.template_name.Width = 104;
            // 
            // message_content
            // 
            this.message_content.DataPropertyName = "message_content";
            this.message_content.HeaderText = "message_content";
            this.message_content.Name = "message_content";
            this.message_content.ReadOnly = true;
            this.message_content.Width = 116;
            // 
            // created_date
            // 
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "created_date";
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            this.created_date.Width = 95;
            // 
            // updated_date
            // 
            this.updated_date.DataPropertyName = "updated_date";
            this.updated_date.HeaderText = "updated_date";
            this.updated_date.Name = "updated_date";
            this.updated_date.ReadOnly = true;
            this.updated_date.Width = 98;
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.HeaderText = "created_by";
            this.created_by.Name = "created_by";
            this.created_by.ReadOnly = true;
            this.created_by.Width = 85;
            // 
            // updated_by
            // 
            this.updated_by.DataPropertyName = "updated_by";
            this.updated_by.HeaderText = "updated_by";
            this.updated_by.Name = "updated_by";
            this.updated_by.ReadOnly = true;
            this.updated_by.Width = 88;
            // 
            // templateidDataGridViewTextBoxColumn
            // 
            this.templateidDataGridViewTextBoxColumn.DataPropertyName = "template_id";
            this.templateidDataGridViewTextBoxColumn.HeaderText = "template_id";
            this.templateidDataGridViewTextBoxColumn.Name = "templateidDataGridViewTextBoxColumn";
            this.templateidDataGridViewTextBoxColumn.ReadOnly = true;
            this.templateidDataGridViewTextBoxColumn.Width = 86;
            // 
            // templatenameDataGridViewTextBoxColumn
            // 
            this.templatenameDataGridViewTextBoxColumn.DataPropertyName = "template_name";
            this.templatenameDataGridViewTextBoxColumn.HeaderText = "template_name";
            this.templatenameDataGridViewTextBoxColumn.Name = "templatenameDataGridViewTextBoxColumn";
            this.templatenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.templatenameDataGridViewTextBoxColumn.Width = 104;
            // 
            // messagecontentDataGridViewTextBoxColumn
            // 
            this.messagecontentDataGridViewTextBoxColumn.DataPropertyName = "message_content";
            this.messagecontentDataGridViewTextBoxColumn.HeaderText = "message_content";
            this.messagecontentDataGridViewTextBoxColumn.Name = "messagecontentDataGridViewTextBoxColumn";
            this.messagecontentDataGridViewTextBoxColumn.ReadOnly = true;
            this.messagecontentDataGridViewTextBoxColumn.Width = 116;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "created_date";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createddateDataGridViewTextBoxColumn.Width = 95;
            // 
            // updateddateDataGridViewTextBoxColumn
            // 
            this.updateddateDataGridViewTextBoxColumn.DataPropertyName = "updated_date";
            this.updateddateDataGridViewTextBoxColumn.HeaderText = "updated_date";
            this.updateddateDataGridViewTextBoxColumn.Name = "updateddateDataGridViewTextBoxColumn";
            this.updateddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateddateDataGridViewTextBoxColumn.Width = 98;
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "created_by";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdbyDataGridViewTextBoxColumn.Width = 85;
            // 
            // updatedbyDataGridViewTextBoxColumn
            // 
            this.updatedbyDataGridViewTextBoxColumn.DataPropertyName = "updated_by";
            this.updatedbyDataGridViewTextBoxColumn.HeaderText = "updated_by";
            this.updatedbyDataGridViewTextBoxColumn.Name = "updatedbyDataGridViewTextBoxColumn";
            this.updatedbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedbyDataGridViewTextBoxColumn.Width = 88;
            // 
            // message_templateTableAdapter1
            // 
            this.message_templateTableAdapter1.ClearBeforeFill = true;
            // 
            // templateCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 747);
            this.Controls.Add(this.templatesGroupBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.msgBodyTextBox);
            this.Name = "templateCreationForm";
            this.Text = "Template Creation";
            this.Load += new System.EventHandler(this.templateCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTeamApexDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._234a_TeamApexDataSet)).EndInit();
            this.tagGroupBox.ResumeLayout(false);
            this.tagGroupBox.PerformLayout();
            this.templatesGroupBox.ResumeLayout(false);
            this.templatesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

