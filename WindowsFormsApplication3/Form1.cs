using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private Double Var1, Var2;
        private Boolean dot, Status;
        private String Operator = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Calculator()
        {
            Var2 = Double.Parse(textBox1.Text);
            if (Operator == "Add")
                Var1 = Var1 + Var2;
            else if (Operator == "Subt")
                Var1 = Var1 - Var2;
            else if (Operator == "Multi")
                Var1 = Var1 * Var2;
            else if (Operator == "Div")
                Var1 = Var1 / Var2;
            
            textBox1.Text = Var1.ToString();
            Status = true;
        }



        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "9";
            else
                textBox1.Text = "9";
            Status = false;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "8";
            else
                textBox1.Text = "8";
            Status = false;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "7";
            else
                textBox1.Text = "7";
            Status = false;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "6";
            else
                textBox1.Text = "6";
            Status = false;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "5";
            else
                textBox1.Text = "5";
            Status = false;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "4";
            else
                textBox1.Text = "4";
            Status = false;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "3";
            else
                textBox1.Text = "3";
            Status = false;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "2";
            else
                textBox1.Text = "2";
            Status = false;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "1";
            else
                textBox1.Text = "1";
            Status = false;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "0";
            else
                textBox1.Text = "0";
            Status = false;
        }

        private void btnNum00_Click(object sender, EventArgs e)
        {
            if (Status == false)
                textBox1.Text = textBox1.Text + "00";
            else
                textBox1.Text = "00";
            Status = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (dot == false)
            {
                if (textBox1.Text.Length > 0)
                    textBox1.Text = textBox1.Text + ".";
                else
                    textBox1.Text = "0.";
                dot = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Var1 = 0;
            Var1 = 0;
            Operator = "";
            dot = false;
        }

        private void btnOperatorAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (Operator == "")
                {
                    Var1 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                else
                {
                    Calculator();
                }
                Operator = "Add";
                dot = false;
            }
        }

        private void btnOperatorSubt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (Operator == "")
                {
                    Var1 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                else
                {
                    Calculator();
                }
                Operator = "Subt";
                dot = false;
            }
        }

        private void btnOperatorMulti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (Operator == "")
                {
                    Var1 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                else
                {
                    Calculator();
                }
                Operator = "Multi";
                dot = false;
            }
        }

        private void btnOperatorDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (Operator == "")
                {
                    Var1 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                else
                {
                    Calculator();
                }
                Operator = "Div";
                dot = false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && Var1 != 0)
            {
                Calculator();
                Operator = "";
                dot = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
