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
            this.tempNameLabel = new System.Windows.Forms.Label();
            this.tempNameTextBox = new System.Windows.Forms.TextBox();
            this.tagTextBox3 = new System.Windows.Forms.TextBox();
            this.tagTextBox1 = new System.Windows.Forms.TextBox();
            this.tagTextBox2 = new System.Windows.Forms.TextBox();
            this.msgBodyTextBox = new System.Windows.Forms.TextBox();
            this.tagGroupBox = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.insertTagButton1 = new System.Windows.Forms.Button();
            this.insertTagButton3 = new System.Windows.Forms.Button();
            this.deleteTagButton3 = new System.Windows.Forms.Button();
            this.deleteTagButton2 = new System.Windows.Forms.Button();
            this.insertTagButton2 = new System.Windows.Forms.Button();
            this.deleteTagButton1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tagGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempNameLabel
            // 
            this.tempNameLabel.AutoSize = true;
            this.tempNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempNameLabel.Location = new System.Drawing.Point(31, 41);
            this.tempNameLabel.Name = "tempNameLabel";
            this.tempNameLabel.Size = new System.Drawing.Size(99, 15);
            this.tempNameLabel.TabIndex = 0;
            this.tempNameLabel.Text = "Template Name:";
            // 
            // tempNameTextBox
            // 
            this.tempNameTextBox.Location = new System.Drawing.Point(145, 41);
            this.tempNameTextBox.Name = "tempNameTextBox";
            this.tempNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.tempNameTextBox.TabIndex = 1;
            // 
            // tagTextBox3
            // 
            this.tagTextBox3.Location = new System.Drawing.Point(111, 115);
            this.tagTextBox3.Name = "tagTextBox3";
            this.tagTextBox3.Size = new System.Drawing.Size(114, 20);
            this.tagTextBox3.TabIndex = 2;
            // 
            // tagTextBox1
            // 
            this.tagTextBox1.Enabled = false;
            this.tagTextBox1.Location = new System.Drawing.Point(111, 35);
            this.tagTextBox1.Name = "tagTextBox1";
            this.tagTextBox1.Size = new System.Drawing.Size(114, 20);
            this.tagTextBox1.TabIndex = 3;
            this.tagTextBox1.Text = "Location";
            // 
            // tagTextBox2
            // 
            this.tagTextBox2.Enabled = false;
            this.tagTextBox2.Location = new System.Drawing.Point(111, 79);
            this.tagTextBox2.Name = "tagTextBox2";
            this.tagTextBox2.Size = new System.Drawing.Size(114, 20);
            this.tagTextBox2.TabIndex = 4;
            this.tagTextBox2.Text = "FoodType";
            // 
            // msgBodyTextBox
            // 
            this.msgBodyTextBox.Location = new System.Drawing.Point(34, 336);
            this.msgBodyTextBox.Multiline = true;
            this.msgBodyTextBox.Name = "msgBodyTextBox";
            this.msgBodyTextBox.Size = new System.Drawing.Size(571, 292);
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
            this.tagGroupBox.Location = new System.Drawing.Point(34, 92);
            this.tagGroupBox.Name = "tagGroupBox";
            this.tagGroupBox.Size = new System.Drawing.Size(571, 167);
            this.tagGroupBox.TabIndex = 6;
            this.tagGroupBox.TabStop = false;
            this.tagGroupBox.Text = "Tags";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(31, 301);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(156, 15);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Please Type Your Message";
            // 
            // insertTagButton1
            // 
            this.insertTagButton1.Location = new System.Drawing.Point(284, 32);
            this.insertTagButton1.Name = "insertTagButton1";
            this.insertTagButton1.Size = new System.Drawing.Size(75, 23);
            this.insertTagButton1.TabIndex = 5;
            this.insertTagButton1.Text = "Insert Tag";
            this.insertTagButton1.UseVisualStyleBackColor = true;
            this.insertTagButton1.Click += new System.EventHandler(this.insertTagButton1_Click);
            // 
            // insertTagButton3
            // 
            this.insertTagButton3.Location = new System.Drawing.Point(284, 112);
            this.insertTagButton3.Name = "insertTagButton3";
            this.insertTagButton3.Size = new System.Drawing.Size(75, 23);
            this.insertTagButton3.TabIndex = 6;
            this.insertTagButton3.Text = "Insert Tag";
            this.insertTagButton3.UseVisualStyleBackColor = true;
            this.insertTagButton3.Click += new System.EventHandler(this.insertTagButton3_Click);
            // 
            // deleteTagButton3
            // 
            this.deleteTagButton3.Location = new System.Drawing.Point(406, 112);
            this.deleteTagButton3.Name = "deleteTagButton3";
            this.deleteTagButton3.Size = new System.Drawing.Size(75, 23);
            this.deleteTagButton3.TabIndex = 7;
            this.deleteTagButton3.Text = "Delete Tag";
            this.deleteTagButton3.UseVisualStyleBackColor = true;
            // 
            // deleteTagButton2
            // 
            this.deleteTagButton2.Location = new System.Drawing.Point(406, 76);
            this.deleteTagButton2.Name = "deleteTagButton2";
            this.deleteTagButton2.Size = new System.Drawing.Size(75, 23);
            this.deleteTagButton2.TabIndex = 8;
            this.deleteTagButton2.Text = "Delete Tag";
            this.deleteTagButton2.UseVisualStyleBackColor = true;
            // 
            // insertTagButton2
            // 
            this.insertTagButton2.Location = new System.Drawing.Point(284, 76);
            this.insertTagButton2.Name = "insertTagButton2";
            this.insertTagButton2.Size = new System.Drawing.Size(75, 23);
            this.insertTagButton2.TabIndex = 9;
            this.insertTagButton2.Text = "Insert Tag";
            this.insertTagButton2.UseVisualStyleBackColor = true;
            this.insertTagButton2.Click += new System.EventHandler(this.insertTagButton2_Click);
            // 
            // deleteTagButton1
            // 
            this.deleteTagButton1.Location = new System.Drawing.Point(406, 32);
            this.deleteTagButton1.Name = "deleteTagButton1";
            this.deleteTagButton1.Size = new System.Drawing.Size(75, 23);
            this.deleteTagButton1.TabIndex = 10;
            this.deleteTagButton1.Text = "Delete Tag";
            this.deleteTagButton1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(247, 655);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // templateCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 703);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tagGroupBox);
            this.Controls.Add(this.msgBodyTextBox);
            this.Controls.Add(this.tempNameTextBox);
            this.Controls.Add(this.tempNameLabel);
            this.Name = "templateCreationForm";
            this.Text = "Template Creation";
            this.tagGroupBox.ResumeLayout(false);
            this.tagGroupBox.PerformLayout();
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
    }
}

