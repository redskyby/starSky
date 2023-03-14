using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int StarСount = 0;
        int StarSpeed = 0;
        int StarSize = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarСount = int.Parse(textBox1.Text);
            StarSpeed = int.Parse(textBox2.Text);
            StarSize = int.Parse(textBox3.Text);

            Form2 a = new Form2(StarСount, StarSpeed , StarSize);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
