using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.code;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Server myServer;
        OurClient client;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            client.SendMessage(textBox1.Text);
        }

        private void Set_btn_Click(object sender, EventArgs e)
        {
            string text = IPAdd_txb1.Text;
            IPAddress address =  IPAddress.Parse(text);
            
            IPEndPoint ipEndPoint = new IPEndPoint(address,Convert.ToInt32(port1_txb.Text));
            myServer = new Server(ipEndPoint);
            myServer.MessageReceived += OnMessageReceives;
            myServer.Listen();
            string text2 = IPAdd_txb2.Text;
            IPAddress address2 =  IPAddress.Parse(text);
            IPEndPoint ipEndPoint2 = new IPEndPoint (address2, Convert.ToInt32(port2_txt.Text));
            client = new OurClient(ipEndPoint2);
               
        }
        void OnMessageReceives(string message)
        {
            textBox1.Text = message;
        }
    }
}
