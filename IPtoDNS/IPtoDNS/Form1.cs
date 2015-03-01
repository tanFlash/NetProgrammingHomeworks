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

namespace IPtoDNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            IPAddress address =  IPAddress.Parse(text);
            IPHostEntry entry = Dns.GetHostEntry(address);
            MessageBox.Show(entry.HostName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPHostEntry host = Dns.GetHostByName(textBox2.Text);

            foreach (IPAddress ads in host.AddressList)
            {
                MessageBox.Show(ads.ToString());
            }
            

        }
    }
}
