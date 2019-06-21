using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class ArrayForm : Form
    {
        int index = 0;
        const int size = 10;
        int[] firstNumber = new int[size];
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] firstNumber = new int[size];

            //int[] secondNumber = new [] {3,2,6};

            firstNumber[0] = 1;
            firstNumber[3] = 3;
            firstNumber[9] = 8;

            string message = "";

            for (int index = 0; index < firstNumber.Length; index++)
            {
                if (firstNumber[index] != 0)
                    message = message + "Value at Index " + index + " is: " + firstNumber[index].ToString() + "\n";
            }

            //message = message + "Value at Index 0 is: "+ number[0].ToString()+"\n";
            //message = message + "Value at Index 3 is: " + number[3].ToString() + "\n";
            //message = message + "Value at Index 9 is: " + number[9].ToString() + "\n";

            showRichTextBox.Text = message;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {   

            firstNumber[index] = Convert.ToInt32(numberTextBox.Text);
            index++;

            string  message ="";

            message = Show("Add");

            showRichTextBox.Text = message;
            
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "Input Values\n";

            message = message + Show("Reverse");

            message = message+ "Reverse Value: \n";
            for (int index = (firstNumber.Length-1); index >=0 ; index--)
            {
                if (firstNumber[index] != 0)
                    message = message + "Value at Index " + index + " is: " + firstNumber[index].ToString() + "\n";
            }

            showRichTextBox.Text =  message;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int index = 0; index < size; index++)
            {
                sum = sum + firstNumber[index];
            }

            showRichTextBox.Text = "Sum: " + sum;
        }

        string Show(string name)
        {
            string message = "";

            for (int i = 0; i < firstNumber.Length; i++)
            {
                if (firstNumber[i] != 0)
                    message = message + "Value at Index " + i + " is: " + firstNumber[i].ToString() + "\n";
            }

            return name + ":" + message;
        }
    }
}
