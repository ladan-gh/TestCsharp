using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public string OP;
        public float Result1, Result2, Sum, Mul, Min, Div;
        //public float Result3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

          

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "+";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "-";
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "*";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "%";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "Tan";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + '1';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = button2.Text;
            textBox1.Text = textBox1.Text + '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "/";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "Sin";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "Cos";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "Cot";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "Pow";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "Log";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result1 = float.Parse(textBox1.Text);
                textBox1.Text = "";
                OP = "SQRT";
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result2 = float.Parse(textBox1.Text);
                switch (OP)
                {
                    case "+":
                        textBox1.Text = (Result1 + Result2).ToString();
                        break;

                    case "-":
                        textBox1.Text = (Result1 - Result2).ToString();
                        break;

                    case "*":
                        textBox1.Text = (Result1 * Result2).ToString();
                        break;

                    case "/":
                        textBox1.Text = (Result1 / Result2).ToString();
                        break;

                    case "%":
                        textBox1.Text = (Result1 % Result2).ToString();
                        break;

                    case "Sin":
                        textBox1.Text = (Math.Sin(Result1)).ToString();
                        break;

                    case "Cos":
                        textBox1.Text = (Math.Cos(Result1)).ToString();
                        break;

                    case "Tan":
                        textBox1.Text = (Math.Tan(Result1)).ToString();
                        break;

                    case "Pow":
                        textBox1.Text = (Math.Pow(Result1,Result2)).ToString();
                        break;

                    case "Log":
                        textBox1.Text = (Math.Log(Result1)).ToString();
                        break;

                    case "SQRT":
                        textBox1.Text = (Math.Sqrt(Result1)).ToString();
                        break;
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
