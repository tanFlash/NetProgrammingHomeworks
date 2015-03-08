using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace FTPClass
{
    public partial class Form1 : Form
    {
        SmtpClient client = new SmtpClient("mail.rambler.ru",587);
        
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Credentials = new NetworkCredential("tan_flash@rambler.ru", "060187schlock");
            MailMessage post = new MailMessage("tan_flash@rambler.ru", "mazurok.tania@gmail.com");
            post.Subject = "Hello";
            post.Body = "Good morning";
            
            client.EnableSsl = true;
            client.Timeout = 30000;
            client.Send(post);
          

        }
    }
}
