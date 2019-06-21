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
    public partial class ValidationForm : Form
    {
        List<string>  names = new List<string>();
        List<int> ages = new List<int>(); 
        public ValidationForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);

                names.Add(name);
                ages.Add(age);
                string message = "";

                int index = 0;
                message = "Name\tAge\n";
                foreach (string nm in names)
                {
                    message = message + nm + "\t" + ages[index].ToString() + "\n";
                    index++;
                }
                message = message+ names[0]+"\t"+ages[0]+"\n";

                dispalyRichTextBox.Text = message;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

        }
    }
}
