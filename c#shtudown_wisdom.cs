using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int init_value = Convert.ToInt32(textBox1.Text);
            int shtudown = Convert.ToInt32(textBox2.Text);
            int wisdom = Convert.ToInt32(textBox3.Text);
            int result = init_value;
            for (int i = 0; i < shtudown; i++) 
            {
                result += wisdom;
            }
            MessageBox.Show(Convert.ToString(result));
        }
    }
}
