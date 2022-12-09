using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }
        private bool flagDot = false;
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (flagDot == false)
            {
                textBox1.Text += ".";
                flagDot = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            flagDot = false;



        }
       private string MathOperator;
        private string FirstNumber;


        private void btn_Operations(object sender, EventArgs e)
        {
            FirstNumber = textBox1.Text;
            textBox2.Text += FirstNumber;
            Button btn = sender as Button;
            textBox2.Text += btn.Text;
            MathOperator = btn.Text;
            textBox1.Text = ""
;


        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            switch (MathOperator)
            {
                case "+":
                    textBox2.Text += textBox1.Text;
                    textBox1.Text =(decimal.Parse( FirstNumber)+decimal.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (decimal.Parse(FirstNumber) - decimal.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (decimal.Parse(FirstNumber) * decimal.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (decimal.Parse(FirstNumber) / decimal.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
