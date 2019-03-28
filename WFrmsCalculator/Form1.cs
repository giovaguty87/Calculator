
using System;
using System.Windows.Forms;

namespace WFrmsCalculator
{
    public partial class Form1 : Form
    {
        public string operation;
        public string NumberOne;
        public string NumberTwo;
        public Decimal Result;

        public Form1()
        {
            InitializeComponent();
            Result = 0;
            this.btnPoint.Enabled = true;
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtBoxNumbers.Text = string.Empty;
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 1;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBoxNumbers.Text = string.Empty;
            this.btnPoint.Enabled = true;
            Result = 0;
        }

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 2;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 3;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 4;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 5;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 6;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 7;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 8;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 9;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            if (Result == 0)
                this.txtBoxNumbers.Text += 0;
            else
                MessageBox.Show("Error, please clear before begin a new operation...!");
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBoxNumbers.Text))
                MessageBox.Show("Error, is mandatory type first a number...!");
            else
            {
                this.txtBoxNumbers.Text = this.txtBoxNumbers.Text + ".";
                this.txtBoxNumbers.Text.Replace(".", ",");
                this.btnPoint.Enabled = false;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBoxNumbers.Text))
                MessageBox.Show("Error, is mandatory type first a number...!");
            else
            {
                operation = "+";
                NumberOne = this.txtBoxNumbers.Text;
                this.txtBoxNumbers.Text = string.Empty;
                this.btnPoint.Enabled = true;
            }
                
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBoxNumbers.Text))
                MessageBox.Show("Error, is mandatory type first a number...!");
            else
            {
                operation = "-";
                NumberOne = this.txtBoxNumbers.Text;
                this.txtBoxNumbers.Text = string.Empty;
                this.btnPoint.Enabled = true;
            }     
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBoxNumbers.Text))
                MessageBox.Show("Error, is mandatory type first a number...!");
            else
            {
                operation = "*";
                NumberOne = this.txtBoxNumbers.Text;
                this.txtBoxNumbers.Text = string.Empty;
                this.btnPoint.Enabled = true;
            }     
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBoxNumbers.Text))
                MessageBox.Show("Error, is mandatory type first a number...!");
            else
            {
                operation = "/";
                NumberOne = this.txtBoxNumbers.Text;
                this.txtBoxNumbers.Text = string.Empty;
                this.btnPoint.Enabled = true;
            }   
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            NumberTwo = this.txtBoxNumbers.Text;

            if (!string.IsNullOrEmpty(NumberTwo))
            {
                switch (operation)
                {

                    case "+":
                        Result = Convert.ToDecimal(NumberOne.Replace(".", ",")) + Convert.ToDecimal(NumberTwo.Replace(".", ","));
                        this.txtBoxNumbers.Text = Convert.ToString(Result);
                        break;
                    case "-":
                        Result = Convert.ToDecimal(NumberOne.Replace(".", ",")) - Convert.ToDecimal(NumberTwo.Replace(".", ","));
                        this.txtBoxNumbers.Text = Convert.ToString(Result);
                        break;
                    case "*":
                        Result = Convert.ToDecimal(NumberOne.Replace(".", ",")) * Convert.ToDecimal(NumberTwo.Replace(".", ","));
                        this.txtBoxNumbers.Text = Convert.ToString(Result);
                        break;
                    case "/":
                        if (NumberTwo == "0")
                        {
                            MessageBox.Show("Error, The second number can't be zero (0)...!");
                        }
                        else
                        {
                            Result = Convert.ToDecimal(NumberOne.Replace(".", ",")) / Convert.ToDecimal(NumberTwo.Replace(".", ","));
                            this.txtBoxNumbers.Text = Convert.ToString(Result);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error, Please type the second number...!");
            }
        }
    }
}