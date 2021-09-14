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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        LinkedList<string> entry = new LinkedList<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if(input.Text == "0" && input.Text != null)
            {
                input.Text = "1";
            }
            else
            {
                input.Text = input.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "2";
            }
            else
            {
                input.Text = input.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "3";
            }
            else
            {
                input.Text = input.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "4";
            }
            else
            {
                input.Text = input.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "5";
            }
            else
            {
                input.Text = input.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "6";
            }
            else
            {
                input.Text = input.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "7";
            }
            else
            {
                input.Text = input.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "8";
            }
            else
            {
                input.Text = input.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text == "0" && input.Text != null)
            {
                input.Text = "9";
            }
            else
            {
                input.Text = input.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text != "0")
            {
                input.Text = input.Text + "0";
            }
  
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (!input.Text.Contains(".")) 
            input.Text = input.Text + ".";         
        }

        private void inputOutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text.Length == 1)
            {
                input.Text = "0";
            }
            if (input.Text != "0")
            {
                input.Text = input.Text.Substring(0, input.Text.Length - 1);
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            entry.AddLast(input.Text);
            output.Text = output.Text + input.Text + " + ";
            entry.AddLast("+");
            input.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            entry.AddLast(input.Text);
            output.Text = output.Text + input.Text + " - ";
            entry.AddLast("-");
            input.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            entry.AddLast(input.Text);
            output.Text = output.Text + input.Text + " x ";
            entry.AddLast("x");
            input.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            entry.AddLast(input.Text);
            output.Text = output.Text + input.Text + " / ";
            entry.AddLast("/");
            input.Text = "0";
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            input.Text = "0";
        }

        private void buttonSqrRoot_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            entry.AddLast("√");

            if (input.Text != "0")
                output.Text = output.Text + input.Text;

            output.Text = output.Text + "√";
            input.Text = "0";
        }

        string[] history = new string[8];

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text != "0")
            {
                entry.AddLast(input.Text);
                entry.AddLast("^");
                entry.AddLast("2");
                output.Text = output.Text + input.Text + "^2";
            }else if(input.Text == "0" && history[0] != "0" && history[0] != null)
            {
                output.Text = output.Text + history[0] + "^2";
                entry.AddLast("^");
                entry.AddLast("2");
            }else if(input.Text == "0" && (history[0] == "0" || history[0] == null))
            {

            }
            input.Text = "0";
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            if (input.Text != "0")
            {
                entry.AddLast(input.Text);
                output.Text = output.Text + input.Text + "^";
                entry.AddLast("^");
                input.Text = "0";
            }else if(input.Text == "0" && (history[0] != "0" || history[0] != null))
            {
                output.Text = output.Text + history[0] + "^";
                entry.AddLast("^");
            }else if(input.Text == "0" && (history[0] == "0" || history[0] == null))
            {

            }
        }

        private void buttonFraction_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            entry.AddLast("1");
            entry.AddLast("/");
            output.Text = output.Text + "1/";
            input.Text = "0";
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            entry.Clear();
            input.Text = "0";
            output.Text = null;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("\r\n"))
            {
                output.Text = null;
            }
            output.Text = output.Text + "(-)";
            entry.AddLast("~");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if(input.Text != "0")
            {
                entry.AddLast(input.Text);
                output.Text = output.Text + input.Text;
            }

            input.Text = "0";

            LinkedListNode<string> tmp = entry.First;
            double num1 = 0;
            double num2 = 0;

            tmp = entry.First;
            while (tmp != null)
            {
                if (tmp.Value == "~")
                {
                    num1 = Double.Parse(tmp.Next.Value);
                    num1 = num1 * -1;
                    tmp.Next.Value = num1.ToString();
                    tmp = tmp.Next;
                    entry.Remove(tmp.Previous);
                }
                else
                {
                    tmp = tmp.Next;
                }              
            }

            tmp = entry.First;
            while (tmp != null)
            {
                if (tmp.Value == "^")
                {
                    num1 = Double.Parse(tmp.Previous.Value);
                    num2 = Double.Parse(tmp.Next.Value);
                    tmp.Value = (Math.Pow(num1, num2)).ToString();
                    entry.Remove(tmp.Previous);
                    entry.Remove(tmp.Next);
                }
                tmp = tmp.Next;
            }

            tmp = entry.First;
            while (tmp != null)
            {
                if (tmp.Value == "√")
                {
                    num1 = Double.Parse(tmp.Next.Value);
                    tmp.Value = (Math.Sqrt(num1)).ToString();
                    entry.Remove(tmp.Next);
                }
                tmp = tmp.Next;
            }

            tmp = entry.First;
            while (tmp != null)
            {
                if (tmp.Value == "x")
                {
                    num1 = Double.Parse(tmp.Previous.Value);
                    num2 = Double.Parse(tmp.Next.Value);
                    tmp.Value = (num1 * num2).ToString();
                    entry.Remove(tmp.Next);
                    entry.Remove(tmp.Previous);
                }
                tmp = tmp.Next;
            }

            tmp = entry.First;
            while (tmp != null)
            {
                if (tmp.Value == "/")
                {
                    num1 = Double.Parse(tmp.Previous.Value);
                    num2 = Double.Parse(tmp.Next.Value);
                    tmp.Value = (num1 / num2).ToString();
                    entry.Remove(tmp.Next);
                    entry.Remove(tmp.Previous);
                }
                tmp = tmp.Next;
            }

            tmp = entry.First;
                
                while(tmp != null)
                {
                    if(tmp.Value == "+")
                    {
                        num1 = Double.Parse(tmp.Previous.Value);
                        num2 = Double.Parse(tmp.Next.Value);
                        tmp.Value = (num1 + num2).ToString();
                        entry.Remove(tmp.Next);
                        entry.Remove(tmp.Previous);
                    }
                    tmp = tmp.Next;
                }



            tmp = entry.First;
            while (tmp != null)
            {
                if (tmp.Value == "-")
                {
                    tmp = entry.Find("-");
                    num1 = Double.Parse(tmp.Previous.Value);
                    num2 = Double.Parse(tmp.Next.Value);
                    tmp.Value = (num1 - num2).ToString();
                    entry.Remove(tmp.Next);
                    entry.Remove(tmp.Previous);
                }
                tmp = tmp.Next;
            }

            output.Text = output.Text + "\r\n" + entry.First.Value;

            entry.Clear();
        }
    }
}
