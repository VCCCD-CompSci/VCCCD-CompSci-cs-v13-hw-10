using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Calc : Form
    {
        float total = 0;
        float currentTotal = 0;        
        bool decimalUsed = false;
        Command command = 0;
        enum Command
        {
            Init,
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public Calc()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "0";
            this.total = 0;
            this.currentTotal = 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            else
            {

            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (currentTotal != 0)
            {
                command = Command.Subtract;
                total = float.Parse(lblOutput.Text, CultureInfo.InvariantCulture.NumberFormat);
                switch (command)
                {
                    case Command.Add:
                        currentTotal = currentTotal + total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Subtract:
                        currentTotal = currentTotal - total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Multiply:
                        currentTotal = currentTotal * total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Divide:
                        currentTotal = currentTotal / total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                command = Command.Subtract;
                currentTotal = float.Parse(lblOutput.Text, CultureInfo.InvariantCulture.NumberFormat);
                lblOutput.Text = "0";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (currentTotal != 0)
            {
                command = Command.Multiply;
                total = float.Parse(lblOutput.Text, CultureInfo.InvariantCulture.NumberFormat);
                switch (command)
                {
                    case Command.Add:
                        currentTotal = currentTotal + total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Subtract:
                        currentTotal = currentTotal - total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Multiply:
                        currentTotal = currentTotal * total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Divide:
                        currentTotal = currentTotal / total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                command = Command.Multiply;
                currentTotal = float.Parse(lblOutput.Text, CultureInfo.InvariantCulture.NumberFormat);
                lblOutput.Text = "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentTotal != 0 && command != Command.Init)
            {
                command = Command.Add;
                total = float.Parse(lblOutput.Text, CultureInfo.InvariantCulture.NumberFormat);
                switch (command)
                {
                    case Command.Add:
                        currentTotal = currentTotal + total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Subtract:
                        currentTotal = currentTotal - total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Multiply:
                        currentTotal = currentTotal * total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    case Command.Divide:
                        currentTotal = currentTotal / total;
                        lblOutput.Text = currentTotal.ToString();
                        break;
                    default:
                        break;
                }                
            }
            else
            {
                command = Command.Add;
                currentTotal = float.Parse(lblOutput.Text, CultureInfo.InvariantCulture.NumberFormat);
                lblOutput.Text = "0";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            total = float.Parse(lblOutput.Text, CultureInfo.InvariantCulture.NumberFormat);
            switch (command)
            {
                case Command.Add:
                    currentTotal = currentTotal + total;
                    lblOutput.Text = currentTotal.ToString();
                    break;
                case Command.Subtract:
                    currentTotal = currentTotal - total;
                    lblOutput.Text = currentTotal.ToString();
                    break;
                case Command.Multiply:
                    currentTotal = currentTotal * total;
                    lblOutput.Text = currentTotal.ToString();
                    break;
                case Command.Divide:
                    currentTotal = currentTotal / total;
                    lblOutput.Text = currentTotal.ToString();
                    break;
                default:
                    break;
            }
            command = Command.Init;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text != "0")
            {
                lblOutput.Text = lblOutput.Text + "0";
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "1";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "2";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "3";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "4";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "5";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "6";
            }
            else
	        {
                lblOutput.Text = lblOutput.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "7";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "8";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
            {
                lblOutput.Text = "9";
            }
            else
            {
                lblOutput.Text = lblOutput.Text + "9";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!decimalUsed)
            {
                lblOutput.Text = lblOutput.Text + ".";
                decimalUsed = true;
            }
        }        
    }
}
