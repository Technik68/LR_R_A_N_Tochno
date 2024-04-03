using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_R_A_N_Tochno
{
    public partial class Form1 : Form
    {
        int b, z;
        int b1, w1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text3 = textBox3.Text;
            b = int.Parse(text1);
            z = int.Parse(text3);

            textBox6.Text = z.ToString();
            TrafficLight trafficLight = new TrafficLight();

            int j;
            for (int i=1; i<=4; i++)
            {
                for (j=1; j<=7; j++)
                {                   
                    trafficLight.Change(i, j);
                    b1 = trafficLight.B1;
                    w1 = trafficLight.W1;
                    textBox1.Text = b1.ToString();
                    //textBox1.Enabled = false; //если захочу можно назначать b новым
                    textBox4.Text = b1.ToString();
                    textBox5.Text = w1.ToString();

                    if (i == b && j == z)
                        break;
                }
                if (i == b && j == z)
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
