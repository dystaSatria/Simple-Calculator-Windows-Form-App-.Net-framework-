using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        double x, y;
        string proces;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text == "0")
            {
                label1.Text = "1";
            }

            else
            {
                label1.Text += "1";
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }

            else
            {
                label1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }

            else
            {
                label1.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }

            else
            {
                label1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }

            else
            {
                label1.Text += "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }

            else
            {
                label1.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }

            else
            {
                label1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }

            else
            {
                label1.Text += "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }

            else
            {
                label1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }

            else
            {
                label1.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(label1.Text)>0)
            {
                label1.Text= label1.Text.Remove(label1.Text.Length -1,1) ;

                if (label1.Text.Length == 0)
                {
                    label1.Text = "0";
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(label1.Text);
            proces = "+" ;
            label2.Text = label1.Text + " +" ;
            label1.Text = "0" ;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(label1.Text);
            if (proces == "+")
            {
                label1.Text = Convert.ToString(x+y) ;
                label2.Text = "";
            }
            if (proces == "-")
            {
                label1.Text = Convert.ToString(x-y);
                label2.Text = "";
            }
            if (proces == "x")
            {
                label1.Text = Convert.ToString(x * y);
                label2.Text = "";
                
            }
            if (proces == "÷")
            {
                label1.Text = Convert.ToString(x / y);
                label2.Text = "";
            }
            if (proces == "%")
            {
                label1.Text = Convert.ToString(x % y);
                label2.Text = "";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(label1.Text);
            proces = "-";
            label2.Text = label1.Text + " -";
            label1.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(label1.Text);
            proces = "x";
            label2.Text = label1.Text + " x";
            label1.Text = "0";
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(label1.Text);
            proces = "÷";
            label2.Text = label1.Text + " ÷";
            label1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double quadrate = Convert.ToDouble(label1.Text);
            label2.Text = label1.Text + "²";
            quadrate = Math.Pow(quadrate,2);
            label1.Text = quadrate.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double squareRoot = Convert.ToDouble(label1.Text);
            label2.Text = " √ " + label1.Text;
            squareRoot = Math.Sqrt(squareRoot);
            label1.Text = squareRoot.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double divided = Convert.ToDouble(label1.Text);
            label2.Text = "1 / " + label1.Text;
            divided = 1/(divided);
            label1.Text = divided.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(label1.Text);
            proces = "%";
            label2.Text = label1.Text + " mod";
            label1.Text = "0";
        }

        

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }
    }
}
