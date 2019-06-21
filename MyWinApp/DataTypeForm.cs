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
    public partial class DataTypeForm : Form
    {
        public DataTypeForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int number;
            number = 10;
            double salary = 10000.50;
            string name = "Ali";

            bool isValied= true;

            MessageBox.Show("Number: " + number + " Salary: " + salary + " Name: " + name + " Is Valied: " + isValied);


        }

        private void ConversionButton_Click(object sender, EventArgs e)
        {
            int firstNumber = 10;
            int scendNumber = firstNumber;
            double thirdNumber = 10.10;
            int fourthNumber = Convert.ToInt32(  thirdNumber);

            string number = thirdNumber.ToString();

            MessageBox.Show("firstNumbe " + firstNumber + "scendNumber " + scendNumber + "thirdNumber" + thirdNumber);
        }

        private void ShowNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello : " + nameTextBox.Text+ " "+ itemComboBox.SelectedItem);
        }
    }
}
