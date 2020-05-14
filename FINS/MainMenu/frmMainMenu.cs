using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateCreation;
using SendNotification;
using notificationLogTylerKeske;

namespace MainMenu
{
    public partial class frmMainMenu : Form
    {
        private readonly int userID = 1;  // TODO: To get actual userID from the to-be-created Login form

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            // Create new instance of Template Creation form
            templateCreationForm ft = new templateCreationForm(userID);

            // Launch the Template Creation form as a modal
            ft.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Create new instance of Send Notification form
            SendNotification.sendNotificationForm fs = new sendNotificationForm(userID);

            // Launch the Send Notification form as a modal
            fs.ShowDialog();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            // Create new instance of Review Notification form
            notificationLogTylerKeske.NotificationLog fn = new notificationLogTylerKeske.NotificationLog(userID);

            // Launch the Review Notification form as a modal
            fn.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            // Logout and exit the application
            Application.Exit();
        }
    }
}
