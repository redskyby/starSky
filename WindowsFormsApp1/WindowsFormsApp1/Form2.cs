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
    public partial class Form2 : Form
    {
        public class Star
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        private Star[] stars = new Star[15000];

        private Random random = new Random();

        private Graphics graphics;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private float Map(float n, float start1 , float stop1 , float start2, float stop2)
        {
            return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            graphics = Graphics.FromImage(pictureBox1.Image);

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new Star()
                {
                    X = random.Next(-pictureBox1.Width, pictureBox1.Width),
                    Y = random.Next(-pictureBox1.Height, pictureBox1.Height),
                    Z = random.Next(1, pictureBox1.Width),
                };
            }

            timer1.Start();
        }
    }
}
