using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator._1
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }
        int v;
        char Sposob;
        private void button15_Click(object sender, EventArgs e)
        {
            v = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch ()
            {
                case "+":
                    
                    break;
                case "-":
                    
                    break;
                case "*":
                    
                    break;
                case "/":
                    
                    break;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Sposob = '/';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sposob = '*';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Sposob = '-';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Sposob = '+';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            v = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            v = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            v = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            v = 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            v = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            v = 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            v = 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            v = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v = 7;
        }
        private void Sposob(int g)
        {
            v += g;
            button14.Text = v;
        }
    }
}
