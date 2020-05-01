namespace SendNotification
{
    partial class Form1
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.templateComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.viewLogButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.selectLocLabel = new System.Windows.Forms.Label();
            this.selectTempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(96, 134);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(269, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Please enter message to be sent, or choose a template:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(99, 150);
            this.messageTextBox.MaxLength = 1000;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(436, 234);
            this.messageTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(99, 404);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // locationComboBox
            // 
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(99, 40);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(147, 21);
            this.locationComboBox.TabIndex = 3;
            this.locationComboBox.Text = "Location";
            this.locationComboBox.SelectedIndexChanged += new System.EventHandler(this.locationComboBox_SelectedIndexChanged);
            // 
            // templateComboBox
            // 
            this.templateComboBox.FormattingEnabled = true;
            this.templateComboBox.Location = new System.Drawing.Point(99, 101);
            this.templateComboBox.Name = "templateComboBox";
            this.templateComboBox.Size = new System.Drawing.Size(147, 21);
            this.templateComboBox.TabIndex = 4;
            this.templateComboBox.Text = "Template";
            this.templateComboBox.SelectedIndexChanged += new System.EventHandler(this.templateComboBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(284, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // viewLogButton
            // 
            this.viewLogButton.Location = new System.Drawing.Point(460, 403);
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(75, 23);
            this.viewLogButton.TabIndex = 6;
            this.viewLogButton.Text = "View Sent";
            this.viewLogButton.UseVisualStyleBackColor = true;
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(281, 40);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 13);
            this.locationLabel.TabIndex = 7;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(281, 109);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(0, 13);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Visible = false;
            // 
            // selectLocLabel
            // 
            this.selectLocLabel.AutoSize = true;
            this.selectLocLabel.Location = new System.Drawing.Point(99, 13);
            this.selectLocLabel.Name = "selectLocLabel";
            this.selectLocLabel.Size = new System.Drawing.Size(131, 13);
            this.selectLocLabel.TabIndex = 11;
            this.selectLocLabel.Text = "Select one or all locations:";
            // 
            // selectTempLabel
            // 
            this.selectTempLabel.AutoSize = true;
            this.selectTempLabel.Location = new System.Drawing.Point(99, 73);
            this.selectTempLabel.Name = "selectTempLabel";
            this.selectTempLabel.Size = new System.Drawing.Size(96, 13);
            this.selectTempLabel.TabIndex = 12;
            this.selectTempLabel.Text = "Select a Template:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.selectTempLabel);
            this.Controls.Add(this.selectLocLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.viewLogButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.templateComboBox);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Name = "Form1";
            this.Text = "Send Notification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.ComboBox templateComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button viewLogButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label selectLocLabel;
        private System.Windows.Forms.Label selectTempLabel;
    }
}

