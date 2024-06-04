using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalcu
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        float result;
        string opt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            la_show2.Text = la_show1.Text + " + ";
            la_show1.Text = string.Empty;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            la_show1.Text += "4";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            la_show1.Text += "1";
        }

        private void b0_Click(object sender, EventArgs e)
        {
           if (!la_show1.Text.Equals(""))
            {
                la_show1.Text += "0";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            la_show1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            la_show1.Text += "3";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            la_show1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            la_show1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            la_show1.Text += "7";

        }

        private void b8_Click(object sender, EventArgs e)
        {
            la_show1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            la_show1.Text += "9";
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            la_show1.Text = string.Empty;
            la_show2.Text = string.Empty;

        }

        private void la_show1_Click(object sender, EventArgs e)
        {
            la_show1 = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_del_Click(object sender, EventArgs e)
        {
            string word = la_show1.Text;
            la_show1.Text = word.Remove(word.Length - 1);
        }

        private void la_show2_Click(object sender, EventArgs e)
        {

        }

        private void b_neg_Click(object sender, EventArgs e)
        {
            la_show2.Text = la_show1.Text + " - ";
            la_show1.Text = string.Empty;
        }

        private void b_multiply_Click(object sender, EventArgs e)
        {
            la_show2.Text = la_show1.Text + " * ";
            la_show1.Text = string.Empty;
        }

        private void b_divide_Click(object sender, EventArgs e)
        {
            la_show2.Text = la_show1.Text + " / ";
            la_show1.Text = string.Empty;
        }
        private void b_duble_Click(object sender, EventArgs e)
        {
            la_show2.Text = la_show1.Text + " ^ ";
            la_show1.Text = string.Empty;
        }

        private void b_equal_Click(object sender, EventArgs e)
        {
            la_show2.Text += la_show1.Text + " = ";
            string[] word = la_show2.Text.Split(' ');
            num1 = Convert.ToInt32(word[0]);
            num2 = Convert.ToInt32(word[2]);
            opt = word[1];
            switch (opt)
            {
                case "+": result = (float) num1+ (float)num2; break;
                case "-": result = (float) num1 - (float)num2; break;
                case "*": result = (float) num1 * (float)num2; break;
                case "/": result = (float) num1 / (float)num2; break;
                case "^": result = (float) Math.Pow(num1,num2); break;
                case "√": result = (float)Math.Sqrt(num1); break;

            }

            la_show1.Text = result.ToString();
        }

        private void la_show2_Click_1(object sender, EventArgs e)
        {

        }

        private void b_root_Click(object sender, EventArgs e)
        {
            la_show2.Text = la_show1.Text + " √ ";
            la_show1.Text = string.Empty;
        }
    }
}
