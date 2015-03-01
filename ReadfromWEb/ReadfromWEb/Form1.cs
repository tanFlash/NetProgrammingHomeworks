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
using System.IO;

namespace ReadfromWEb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebRequest req = WebRequest.Create("http://google.com");
            req.Proxy = null;
            WebResponse res = req.GetResponse();
            Stream rs = res.GetResponseStream();
            //string newLine;
            // StreamReader reader = new StreamReader(rs);
            textBox1.Text = res.Headers.ToString();
            rs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://google.com");
            StreamReader sr = new StreamReader(stream);
            string newLine;
            while ((newLine = sr.ReadLine()) != null)
                textBox1.Text += newLine;
            stream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebRequest req = WebRequest.Create("http://www.albahari.com/nutshell/code.html");
            req.Proxy = null;
            WebResponse res = req.GetResponse();
            Stream rs = res.GetResponseStream();
            StreamReader reader = new StreamReader(rs);
            textBox1.Text = reader.ReadToEnd();
            rs.Close();
        }

        async private void button3_Click(object sender, EventArgs e)
        {
            WebRequest req = WebRequest.Create("http://www.albahari.com/nutshell/code.html");
            req.Proxy = null;
            WebResponse res = await req.GetResponseAsync();
            Stream rs = res.GetResponseStream();
            StreamReader reader = new StreamReader(rs);
            textBox1.Text = reader.ReadToEnd();
            rs.Close();
        }
        
    }
}
