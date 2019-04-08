using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string prevEquation = "", prevOperation = "", operation = "";

        public static double answer = 0;

        private void Allbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            switch(button.Name)
            {
                case "buttonDelete":
                    if(textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length-1);
                     //   textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    }
                    break;

                case "buttonClear":
                    operation = "";
                    textBox.ResetText();
                    textBox2.ResetText();
                    break;

                case "buttonDecimal":
                    if (!textBox.Text.Contains("."))
                    {
                        textBox.Text += ".";
                    }
                    break;

                default:
                    if (operation == "=")
                    {
                        operation = "";
                        textBox.ResetText();
                    }

                    textBox.Text += button.Text;

                    break;
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button opr = sender as Button;

            switch (opr.Text)
            {
                case "+":
                    if (textBox.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "+";
                            prevOperation = operation;
                            prevEquation = textBox.Text;
                            textBox2.Text = prevEquation + operation;
                            textBox.ResetText();
                        }
                    }
                    else
                    {
                        operation = "+";
                        multi_equations();
                    }
                    break;
                case "-":
                    if (textBox.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "-";
                            prevOperation = operation;
                            prevEquation = textBox.Text;
                            textBox2.Text = prevEquation + operation;
                            textBox.ResetText();
                        }
                    }
                    else
                    {
                        operation = "-";
                        multi_equations();
                    }
                    break;
                case "/":
                    if (textBox.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "/";
                            prevOperation = operation;
                            prevEquation = textBox.Text;
                            textBox2.Text = prevEquation + operation;
                            textBox.ResetText();
                        }
                    }
                    else
                    {
                        operation = "/";
                        multi_equations();
                    }
                    break;
                case "*":
                    if (textBox.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "*";
                            prevOperation = operation;
                            prevEquation = textBox.Text;
                            textBox2.Text = prevEquation + operation;
                            textBox.ResetText();
                        }
                    }
                    else
                    {
                        operation = "*";
                        multi_equations();
                    }
                    break;
                case "=":
                    if (textBox.Text.Length > 0)
                    {
                        operation = "=";
                        multi_equations();
                        textBox2.ResetText();
                        textBox.Text = answer.ToString();
                    }
                    break;
            }
    }

        private void multi_equations()
        {
            if (prevOperation == "+")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) + Convert.ToDouble(textBox.Text);

                prevEquation = answer.ToString();
                textBox2.Text = prevEquation + operation;
                textBox.ResetText();
            }
            else if (prevOperation == "-")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) - Convert.ToDouble(textBox.Text);

                prevEquation = answer.ToString();
                textBox2.Text = prevEquation + operation;
                textBox.ResetText();
            }
            else if (prevOperation == "/")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) / Convert.ToDouble(textBox.Text);

                prevEquation = answer.ToString();
                textBox2.Text = prevEquation + operation;
                textBox.ResetText();
            }
            else if (prevOperation == "*")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) * Convert.ToDouble(textBox.Text);

                prevEquation = answer.ToString();
                textBox2.Text = prevEquation + operation;
                textBox.ResetText();
            }
            else if (prevOperation == "%")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) % Convert.ToDouble(textBox.Text);

                prevEquation = answer.ToString();
                textBox2.Text = prevEquation + operation;
                textBox.ResetText();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
