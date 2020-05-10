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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(templateCreationForm));
            this.tempNameLabel = new System.Windows.Forms.Label();
            this.tempNameTextBox = new System.Windows.Forms.TextBox();
            this.tagTextBox3 = new System.Windows.Forms.TextBox();
            this.tagTextBox1 = new System.Windows.Forms.TextBox();
            this.tagTextBox2 = new System.Windows.Forms.TextBox();
            this.msgBodyTextBox = new System.Windows.Forms.TextBox();
            this.tagGroupBox = new System.Windows.Forms.GroupBox();
            this.insertTagButton2 = new System.Windows.Forms.Button();
            this.insertTagButton3 = new System.Windows.Forms.Button();
            this.insertTagButton1 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.templatesGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.tempID_TextBox = new System.Windows.Forms.TextBox();
            this.tempID_Label = new System.Windows.Forms.Label();
            this.templateGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.tagGroupBox.SuspendLayout();
            this.templatesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tempNameLabel
            // 
            this.tempNameLabel.AutoSize = true;
            this.tempNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempNameLabel.Location = new System.Drawing.Point(6, 93);
            this.tempNameLabel.Name = "tempNameLabel";
            this.tempNameLabel.Size = new System.Drawing.Size(99, 15);
            this.tempNameLabel.TabIndex = 0;
            this.tempNameLabel.Text = "Template Name:";
            // 
            // tempNameTextBox
            // 
            this.tempNameTextBox.Location = new System.Drawing.Point(121, 93);
            this.tempNameTextBox.Name = "tempNameTextBox";
            this.tempNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.tempNameTextBox.TabIndex = 1;
            // 
            // tagTextBox3
            // 
            this.tagTextBox3.Location = new System.Drawing.Point(565, 36);
            this.tagTextBox3.Name = "tagTextBox3";
            this.tagTextBox3.Size = new System.Drawing.Size(100, 20);
            this.tagTextBox3.TabIndex = 2;
            this.tagTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tagTextBox3_KeyPress);
            // 
            // tagTextBox1
            // 
            this.tagTextBox1.Enabled = false;
            this.tagTextBox1.Location = new System.Drawing.Point(103, 36);
            this.tagTextBox1.Name = "tagTextBox1";
            this.tagTextBox1.Size = new System.Drawing.Size(100, 20);
            this.tagTextBox1.TabIndex = 3;
            this.tagTextBox1.Text = "Location";
            // 
            // tagTextBox2
            // 
            this.tagTextBox2.Enabled = false;
            this.tagTextBox2.Location = new System.Drawing.Point(334, 36);
            this.tagTextBox2.Name = "tagTextBox2";
            this.tagTextBox2.Size = new System.Drawing.Size(100, 20);
            this.tagTextBox2.TabIndex = 4;
            this.tagTextBox2.Text = "FoodType";
            // 
            // msgBodyTextBox
            // 
            this.msgBodyTextBox.Location = new System.Drawing.Point(27, 396);
            this.msgBodyTextBox.Multiline = true;
            this.msgBodyTextBox.Name = "msgBodyTextBox";
            this.msgBodyTextBox.Size = new System.Drawing.Size(695, 278);
            this.msgBodyTextBox.TabIndex = 5;
            // 
            // tagGroupBox
            // 
            this.tagGroupBox.Controls.Add(this.insertTagButton2);
            this.tagGroupBox.Controls.Add(this.insertTagButton3);
            this.tagGroupBox.Controls.Add(this.insertTagButton1);
            this.tagGroupBox.Controls.Add(this.tagTextBox2);
            this.tagGroupBox.Controls.Add(this.tagTextBox1);
            this.tagGroupBox.Controls.Add(this.tagTextBox3);
            this.tagGroupBox.Location = new System.Drawing.Point(27, 246);
            this.tagGroupBox.Name = "tagGroupBox";
            this.tagGroupBox.Size = new System.Drawing.Size(695, 88);
            this.tagGroupBox.TabIndex = 6;
            this.tagGroupBox.TabStop = false;
            this.tagGroupBox.Text = "Tags";
            // 
            // insertTagButton2
            // 
            this.insertTagButton2.Location = new System.Drawing.Point(471, 36);
            this.insertTagButton2.Name = "insertTagButton2";
            this.insertTagButton2.Size = new System.Drawing.Size(75, 20);
            this.insertTagButton2.TabIndex = 9;
            this.insertTagButton2.Text = "Insert Tag";
            this.insertTagButton2.UseVisualStyleBackColor = true;
            this.insertTagButton2.Click += new System.EventHandler(this.insertTagButton2_Click);
            // 
            // insertTagButton3
            // 
            this.insertTagButton3.Location = new System.Drawing.Point(240, 36);
            this.insertTagButton3.Name = "insertTagButton3";
            this.insertTagButton3.Size = new System.Drawing.Size(75, 20);
            this.insertTagButton3.TabIndex = 6;
            this.insertTagButton3.Text = "Insert Tag";
            this.insertTagButton3.UseVisualStyleBackColor = true;
            this.insertTagButton3.Click += new System.EventHandler(this.insertTagButton3_Click);
            // 
            // insertTagButton1
            // 
            this.insertTagButton1.Location = new System.Drawing.Point(9, 36);
            this.insertTagButton1.Name = "insertTagButton1";
            this.insertTagButton1.Size = new System.Drawing.Size(75, 20);
            this.insertTagButton1.TabIndex = 5;
            this.insertTagButton1.Text = "Insert Tag";
            this.insertTagButton1.UseVisualStyleBackColor = true;
            this.insertTagButton1.Click += new System.EventHandler(this.insertTagButton1_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(24, 356);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(156, 15);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Please Type Your Message";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(223, 159);
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
            this.templatesGroupBox.Controls.Add(this.tempID_TextBox);
            this.templatesGroupBox.Controls.Add(this.tempID_Label);
            this.templatesGroupBox.Controls.Add(this.templateGridView);
            this.templatesGroupBox.Controls.Add(this.saveButton);
            this.templatesGroupBox.Controls.Add(this.tempNameTextBox);
            this.templatesGroupBox.Controls.Add(this.tempNameLabel);
            this.templatesGroupBox.Location = new System.Drawing.Point(27, 27);
            this.templatesGroupBox.Name = "templatesGroupBox";
            this.templatesGroupBox.Size = new System.Drawing.Size(695, 200);
            this.templatesGroupBox.TabIndex = 9;
            this.templatesGroupBox.TabStop = false;
            this.templatesGroupBox.Text = "Templates";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(9, 159);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "New Template(&Clear)";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tempID_TextBox
            // 
            this.tempID_TextBox.Location = new System.Drawing.Point(121, 34);
            this.tempID_TextBox.Name = "tempID_TextBox";
            this.tempID_TextBox.ReadOnly = true;
            this.tempID_TextBox.Size = new System.Drawing.Size(54, 20);
            this.tempID_TextBox.TabIndex = 11;
            // 
            // tempID_Label
            // 
            this.tempID_Label.AutoSize = true;
            this.tempID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempID_Label.Location = new System.Drawing.Point(6, 34);
            this.tempID_Label.Name = "tempID_Label";
            this.tempID_Label.Size = new System.Drawing.Size(74, 15);
            this.tempID_Label.TabIndex = 10;
            this.tempID_Label.Text = "Template ID";
            // 
            // templateGridView
            // 
            this.templateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.templateGridView.Location = new System.Drawing.Point(347, 34);
            this.templateGridView.Name = "templateGridView";
            this.templateGridView.RowHeadersVisible = false;
            this.templateGridView.ShowCellErrors = false;
            this.templateGridView.Size = new System.Drawing.Size(318, 150);
            this.templateGridView.TabIndex = 9;
            this.templateGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(587, 721);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Go Back to Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // templateCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 809);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tagGroupBox);
            this.Controls.Add(this.templatesGroupBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.msgBodyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "templateCreationForm";
            this.Text = "Template Creation";
            this.Load += new System.EventHandler(this.templateCreationForm_Load);
            this.tagGroupBox.ResumeLayout(false);
            this.tagGroupBox.PerformLayout();
            this.templatesGroupBox.ResumeLayout(false);
            this.templatesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateGridView)).EndInit();
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
        private System.Windows.Forms.Button insertTagButton2;
        private System.Windows.Forms.Button insertTagButton3;
        private System.Windows.Forms.Button insertTagButton1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox templatesGroupBox;
        private System.Windows.Forms.DataGridView templateGridView;
        private System.Windows.Forms.TextBox tempID_TextBox;
        private System.Windows.Forms.Label tempID_Label;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backButton;
    }
}

