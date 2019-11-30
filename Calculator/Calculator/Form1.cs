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

        string operation = "";
        double firstNum, secondNum;

        private void btnCClick(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void btnCEClick(object sender, EventArgs e)
        {
            lblDisplay.Text = "";

            string f, s;

            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);

            f = "";
            s = "";

        }

        private void OperationClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNum = Double.Parse(lblDisplay.Text);
            operation = b.Text;
            lblDisplay.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Length > 0)
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1, 1);
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Contains('-'))
            {
                lblDisplay.Text = lblDisplay.Text.Remove(0, 1);
            }
            else
            {
                lblDisplay.Text = "-" + lblDisplay.Text;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNum = Double.Parse(lblDisplay.Text);
            switch (operation)
            {
                case "+":
                    lblDisplay.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    lblDisplay.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "*":
                    lblDisplay.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "/":
                    lblDisplay.Text = Convert.ToString(firstNum / secondNum);
                    break;
                default:
                    break;

            }
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            
            if(b.Text== ".")
            {
                if(!lblDisplay.Text.Contains('.'))
                {
                    lblDisplay.Text = lblDisplay.Text + b.Text;
                }
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text + b.Text;
            }
        }
        
        /*private void AllBtn_click(object sender, EventArgs e)
        {

        }*/
    }
}
