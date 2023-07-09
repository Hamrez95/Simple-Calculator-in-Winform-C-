using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double currentNumber = 0;
        private string operation = "";
        private bool isNewNumber = true;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;

            if (isNewNumber)
            {
                tbDisplayR.Text = number;
                isNewNumber = false;
            }
            else
            {
                tbDisplayR.Text += number;
            }
        }

        private void OperationButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            currentNumber = double.Parse(tbDisplayR.Text);
            isNewNumber = true;
        }

        private void EqualsButtonClick(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(tbDisplayR.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = currentNumber + secondNumber;
                    break;
                case "-":
                    result = currentNumber - secondNumber;
                    break;
                case "x":
                    result = currentNumber * secondNumber;
                    break;
                case "/":
                    result = currentNumber / secondNumber;
                    break;
            }

            tbDisplayR.Text = result.ToString();
            isNewNumber = true;
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            tbDisplayR.Text = "0";
            currentNumber = 0;
            operation = "";
            isNewNumber = true;
        }
    }
}
    

