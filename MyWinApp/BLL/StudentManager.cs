using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Repository;
using MyWinApp.Models;

namespace MyWinApp.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        public DataTable LoadDistrict()
        {
            return _studentRepository.LoadDistrict();
        }

        public DataTable ShowStudent()
        {
            return _studentRepository.ShowStudent();
        }

        public int Insert(Student student)
        {
            return _studentRepository.Insert(student);
        }
    }
}
