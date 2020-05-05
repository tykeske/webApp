namespace notificationLogTylerKeske
{
    partial class NotificationLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationLog));
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reviewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.message_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriber_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.template_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(78, 46);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(39, 15);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(123, 46);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 4;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(409, 46);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(24, 15);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "To:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(439, 46);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 6;
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(665, 43);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(75, 23);
            this.reviewButton.TabIndex = 7;
            this.reviewButton.Text = "&Review";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.ReviewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a date range to filter the log:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.message_date,
            this.message_content,
            this.message_by,
            this.subscriber_count,
            this.template_used});
            this.dataGridView.Location = new System.Drawing.Point(29, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(731, 324);
            this.dataGridView.TabIndex = 9;
            // 
            // message_date
            // 
            this.message_date.DataPropertyName = "message_date";
            this.message_date.HeaderText = "Date/Time";
            this.message_date.Name = "message_date";
            this.message_date.Width = 170;
            // 
            // message_content
            // 
            this.message_content.DataPropertyName = "message_content";
            this.message_content.HeaderText = "Message";
            this.message_content.Name = "message_content";
            // 
            // message_by
            // 
            this.message_by.DataPropertyName = "message_by";
            this.message_by.HeaderText = "Staff";
            this.message_by.Name = "message_by";
            this.message_by.Width = 160;
            // 
            // subscriber_count
            // 
            this.subscriber_count.DataPropertyName = "subscriber_count";
            this.subscriber_count.HeaderText = "No.Subscribers";
            this.subscriber_count.Name = "subscriber_count";
            // 
            // template_used
            // 
            this.template_used.DataPropertyName = "template_used";
            this.template_used.HeaderText = "Template";
            this.template_used.Name = "template_used";
            this.template_used.Width = 160;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(677, 415);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(83, 23);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "Back to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // NotificationLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.fromLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotificationLog";
            this.Text = "Notification Log";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn message_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriber_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn template_used;
        private System.Windows.Forms.Button menuButton;
    }
}

