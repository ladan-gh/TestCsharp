using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textAmount.Text);
            int rate = int.Parse(textRate.Text);
            int month = int.Parse(textMonth.Text);

            int rate2 = 1 + (rate / 1200); 
            int pow = (int)Math.Pow(rate2, month);

            int Qest = ( (amount * (rate/1200)) * pow ) / ( pow - 1 );
            int Sod = (month * Qest) - amount;

            textQest.Text = Qest.ToString("#,#");
            textSod.Text = Sod.ToString("#,#");



        }
    }
}
