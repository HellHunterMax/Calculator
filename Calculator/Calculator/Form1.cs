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

        public static string prevLquation = "", prevoperation = "", operation = "";

        private void AllBtn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch(btn.Name)
            {
                case "btnDel":
                    if(lblDisplay.Text.Length > 0)
                    {
                        lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
                    }
                    break;
                case "btnC":
                    operation = "";
                    lblDisplay.ResetText();
                    break;
                case "btnCE":
                    lblDisplay.ResetText();
                    break;
                case "btnDot":
                    if (!lblDisplay.Text.Contains('.'))
                    {
                        lblDisplay.Text += ".";
                    }
                    break;
                case "btnPlusMinus":
                    if (lblDisplay.Text.Length > 0)
                    {
                        if (!lblDisplay.Text.Contains('-'))
                        {
                            lblDisplay.Text = "-" + lblDisplay.Text;
                        }
                        else if (lblDisplay.Text.Contains('-'))
                        {
                            lblDisplay.Text = lblDisplay.Text.Substring(1, lblDisplay.Text.Length - 1);
                        }
                    }
                    break;
                default:
                    if (operation == "=")
                    {
                        operation = "";
                        lblDisplay.ResetText();
                    }

                    lblDisplay.Text += btn.Text;
                    break;
            }
        }
    }
}
