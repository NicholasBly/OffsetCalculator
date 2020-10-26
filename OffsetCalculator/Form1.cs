using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ModderCalculator
{
    public partial class Form1 : Form
    {
        int plus = 0;
        int minus = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MinusButton.BackColor == System.Drawing.Color.Green)
            {
                MinusButton.BackColor = System.Drawing.Color.Transparent;
                minus = 0;
            }
                plus = 1;
                PlusButton.BackColor = System.Drawing.Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PlusButton.BackColor == System.Drawing.Color.Green)
            {
                PlusButton.BackColor = System.Drawing.Color.Transparent;
                plus = 0;
            }
                minus = 1;
                MinusButton.BackColor = System.Drawing.Color.Green;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            uint a = Convert.ToUInt32(textBox1.Text);
            uint b = Convert.ToUInt32(textBox2.Text);
            uint c = Convert.ToUInt32(textBox3.Text);
                if (textBox1.Text != null && textBox2.Text != null)
                {
                    if (minus != 1 || plus != 1)
                    {
                        MessageBox.Show("Select Either Plus Or Minus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                if (plus == 1)
                {
                    c = a + b;
                }
                if (minus == 1)
                {
                    c = a - b;
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("0x"))
            {
                string a = textBox1.Text;
                a.Trim('0', 'x');
            }
        }
    }
}
