using BLL.BOs;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentServices
    {
        public static List<StudentModel> Gets()
        {
            var students = new List<StudentModel>();

            foreach(var student in StudentRepo.Gets())
            {
                students.Add(new StudentModel
                {
                    Id = student.Id,
                    Name = student.Name,
                    Dob = student.Dob,
                });
            }

            return students;
        }
    }
}
