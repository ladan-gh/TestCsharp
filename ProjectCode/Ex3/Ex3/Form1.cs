using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {



            /*double num1 = double.Parse(textBox1.Text) * 1000;
            double num2 = double.Parse(textBox2.Text) * 2000;
            double num3 = double.Parse(textBox3.Text) * 5000;
            double num4 = double.Parse(textBox4.Text) * 10000;
            double num5 = double.Parse(textBox5.Text) * 50000;
            double num6 = double.Parse(textBox6.Text) * 100000;*/

            /*double num1 = Convert.ToDouble(textBox1.Text) * 1000;
            double num2 = Convert.ToDouble(textBox2.Text) * 2000;
            double num3 = Convert.ToDouble(textBox3.Text) * 5000;
            double num4 = Convert.ToDouble(textBox4.Text) * 10000;
            double num5 = Convert.ToDouble(textBox5.Text) * 50000;
            double num6 = Convert.ToDouble(textBox6.Text) * 100000;*/

            /*int amount1 = int.Parse(label1.Text);
            int amount2 = int.Parse(label2.Text);
            int amount3 = int.Parse(label3.Text);
            int amount4 = int.Parse(label4.Text);
            int amount5 = int.Parse(label5.Text);
            int amount6 = int.Parse(label6.Text);*/

            /*int a1 = num1 * amount1;
            int a2 = num2 * amount2;
            int a3 = num3 * amount3;
            int a4 = num4 * amount4;
            int a5 = num5 * amount5;
            int a6 = num6 * amount6;
            int x = a1 + a2 + a3 + a4 + a5 + a6;*/


            int num1 = int.Parse(textBox1.Text) * 1000;
            int num2 = int.Parse(textBox2.Text) * 2000;
            int num3 = int.Parse(textBox3.Text) * 5000;
            int num4 = int.Parse(textBox4.Text) * 10000;
            int num5 = int.Parse(textBox5.Text) * 50000;
            int num6 = int.Parse(textBox6.Text) * 100000;


            int num = num1 + num2 + num3 + num4 + num5 + num6;

            textBox7.Text = num.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
