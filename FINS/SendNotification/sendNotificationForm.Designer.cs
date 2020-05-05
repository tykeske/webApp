namespace SendNotification
{
    partial class sendNotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendNotificationForm));
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.templateComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.selectLocLabel = new System.Windows.Forms.Label();
            this.selectTempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(26, 125);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(269, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Please enter message to be sent, or choose a template:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(26, 150);
            this.messageTextBox.MaxLength = 1000;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(669, 310);
            this.messageTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(29, 482);
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
            this.locationComboBox.Location = new System.Drawing.Point(29, 41);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(147, 21);
            this.locationComboBox.TabIndex = 3;
            this.locationComboBox.Text = "Location";
            this.locationComboBox.SelectedIndexChanged += new System.EventHandler(this.locationComboBox_SelectedIndexChanged);
            // 
            // templateComboBox
            // 
            this.templateComboBox.FormattingEnabled = true;
            this.templateComboBox.Location = new System.Drawing.Point(26, 91);
            this.templateComboBox.Name = "templateComboBox";
            this.templateComboBox.Size = new System.Drawing.Size(147, 21);
            this.templateComboBox.TabIndex = 4;
            this.templateComboBox.Text = "Template";
            this.templateComboBox.SelectedIndexChanged += new System.EventHandler(this.templateComboBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(314, 482);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(599, 482);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Go Back to Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // selectLocLabel
            // 
            this.selectLocLabel.AutoSize = true;
            this.selectLocLabel.Location = new System.Drawing.Point(26, 25);
            this.selectLocLabel.Name = "selectLocLabel";
            this.selectLocLabel.Size = new System.Drawing.Size(145, 13);
            this.selectLocLabel.TabIndex = 11;
            this.selectLocLabel.Text = "Select a Location (Required):";
            // 
            // selectTempLabel
            // 
            this.selectTempLabel.AutoSize = true;
            this.selectTempLabel.Location = new System.Drawing.Point(26, 75);
            this.selectTempLabel.Name = "selectTempLabel";
            this.selectTempLabel.Size = new System.Drawing.Size(96, 13);
            this.selectTempLabel.TabIndex = 12;
            this.selectTempLabel.Text = "Select a Template:";
            // 
            // sendNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 532);
            this.Controls.Add(this.selectTempLabel);
            this.Controls.Add(this.selectLocLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.templateComboBox);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sendNotificationForm";
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label selectLocLabel;
        private System.Windows.Forms.Label selectTempLabel;
    }
}

