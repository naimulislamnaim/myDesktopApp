using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinApp.Models;
using MyWinApp.BLL;

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        StudentManager _studentManager = new StudentManager();
        ////Connection
        //private string connectionString;
        //private SqlConnection sqlConnection;

        ////Command
        //private string commandString;
        //private SqlCommand sqlCommand;

        private Student student;
        public StudentUi()
        {
            InitializeComponent();
            ////Initialize Connection
            //connectionString = @"Server = DESKTOP-OKE8LIF\SQLEXPRESS; Database=StudentDB; Integrated Security= true";
            //sqlConnection  = new SqlConnection(connectionString);
            student = new Student();

        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            //load District 
            //LoadDistrict();
            districtComboBox.DataSource = _studentManager.LoadDistrict();
        }

        //private void LoadDistrict()
        //{
        //    //
        //    sqlConnection.Open();

        //    //
        //    commandString = @"SELECT * FROM Districts";
        //    sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);
            
        //    if (dataTable.Rows.Count > 0)
        //        districtComboBox.DataSource = dataTable;
        //    //
        //    sqlConnection.Close();
        //}

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StudentManager _studentManager = new StudentManager();

            student.RollNo = rollNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID = Convert.ToInt32(districtComboBox.SelectedValue);

            int isExecuted;

            isExecuted = _studentManager.Insert(student);

            if (isExecuted > 0)
            {
                MessageBox.Show("Saved!!");
            }
            else
            {
                MessageBox.Show("Not Saved!!");
            }

            //Insert(student);

        }

        //private void Insert(Student student)
        //{
        //    //
        //    sqlConnection.Open();

        //    commandString = @"INSERT INTO Students (RollNo, Name, Age, Address, DistrictID) VALUES ('"+ student.RollNo+ "', '"+ student .Name+ "', "+ student.Age+ ", '"+ student.Address+ "',"+ student.DistrictID+ ")";
        //    sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    int isExecuted;
        //    isExecuted=sqlCommand.ExecuteNonQuery();

        //    if (isExecuted > 0)
        //    {
        //        MessageBox.Show("Saved!!");
        //    }else
        //    {
        //        MessageBox.Show("Not Saved!!");
        //    }

        //    //
        //    sqlConnection.Close();
        //}

        private void ShowButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource= _studentManager.ShowStudent();
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.displayDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        //private void ShowStudent()
        //{
        //    //
        //    sqlConnection.Open();

        //    //
        //    commandString = @"SELECT * FROM StudentsView";
        //    sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);

        //    if (dataTable.Rows.Count > 0)
        //        displayDataGridView.DataSource = dataTable;
        //    //
        //    sqlConnection.Close();
        //}
    }
}
