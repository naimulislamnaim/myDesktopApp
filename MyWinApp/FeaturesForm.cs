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
    public partial class FeaturesForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();

        public FeaturesForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                string name = nameTextBox.Text;
                int age;

                userLabel.Text="";
                if (!String.IsNullOrEmpty(userTextBox.Text))
                {
                    bool isTrue = false;
                    user = userTextBox.Text;

                    isTrue = IsExist(user);
                    if (isTrue)
                    {
                        MessageBox.Show("User: " + user + " already exists!!");
                        return;
                    }
                }
                else
                {
                    userLabel.Text="User can not be Empty!";
                    return;
                }

                
                if (!String.IsNullOrEmpty(ageTextBox.Text))
                {
                    age = Convert.ToInt32(ageTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Age can not be Empty!");
                    return;
                }

                
                users.Add(user);
                names.Add(name);
                ages.Add(age);



                displayRichTextBox.Text = Display();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private string Display()
        {
            string message = "";

            message = "Sl\tUser\tName\tAge\n";

            int index = 0;
            foreach (string user in users)
            {
                message = message + (index+1)+"\t"+ user+"\t"+names[index]+"\t"+ages[index]+"\n";
                index++;

            }

            return message;
        }

        private bool IsExist(string user)
        {
            bool isExist = false;
            foreach (string userChk in users)
            {
                if (user == userChk)
                    isExist = true;
            }
            return isExist;
        }
    }
}
