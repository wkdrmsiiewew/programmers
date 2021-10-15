using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Threading;

namespace _897_wisdom_gh
{
    public partial class Form1 : Form
    {
        private TcpClient client = new TcpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        void getDataThread() {
            while (true) {

                NetworkStream buffer = client.GetStream();
                byte[] on = new byte[] { 0x02 };
                byte[] ibuf = new byte[100];


                buffer.Write(on);
                int num = buffer.Read(ibuf, 0, ibuf.Length);
                string date = Encoding.UTF8.GetString(ibuf, 0, num);
                this.Invoke(new Action(
                    delegate ()
                    {
                        label1.Text = date;
                    }
                    ));
            }
            
        }
        void sendDataThread() {
            string bate = textBox3.Text;
            NetworkStream buffer = client.GetStream();
            byte[] on =System.Text.Encoding.UTF8.GetBytes(bate);
            buffer.Write(on);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new TcpClient(textBox1.Text, Int32.Parse(textBox2.Text));
            Thread thr = new Thread(getDataThread);
            thr.IsBackground = true;
            thr.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thr2 = new Thread(sendDataThread);
            thr2.IsBackground = true;
            thr2.Start();
        }
    }
}


//192.168.2.109
