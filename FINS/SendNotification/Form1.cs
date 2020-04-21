using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

/*
Author: Becca Menefee-Scheets
Date: 4/21/20
Class: CIS 234A
Assignment: 3
Bugs: none
*/
namespace SendNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //tries to create a mail message object 
                MailMessage msg = new MailMessage();
                //address to be sent by
                msg.From = new MailAddress("PortlandCCPantry@gmail.com");
                //addresses to be sent to -- will be updating to connect and pull addresses from database
                msg.CC.Add("becca.menefeescheets@pcc.edu, beccamenefee@gmail.com");
                //message subject
                msg.Subject = "Test";
                //message body
                msg.Body = messageTextBox.Text;

                //creates a new smtpClient class
                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                //login information for email to be sent from and port information
                ntcd.UserName = "PortlandCCPantry@gmail.com";
                ntcd.Password = "Panther20!";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                //send the message
                smt.Send(msg);
                MessageBox.Show("Email was sent!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
