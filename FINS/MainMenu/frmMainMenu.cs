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
using NotificationLog;

namespace MainMenu
{
    public partial class frmMainMenu : Form
    {
        private readonly int userID = 1;  // TODO: hard-coded for testing

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            templateCreationForm ft = new templateCreationForm(userID);

            ft.ShowDialog();
            // should be ft.ShowDialog(userID);
            // to add parameter to the form: public templateCreationForm(int userID)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendNotification.Form1 fs = new SendNotification.Form1();

            fs.ShowDialog();
            // should be fs.ShowDialog(userID);
            // to add parameter to the form: public Form1(int userID)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotificationLog.Form1 fn = new NotificationLog.Form1();

            fn.ShowDialog();
            // should be fn.ShowDialog(userID);
            // to add parameter to the form: public Form1(int userID)
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
