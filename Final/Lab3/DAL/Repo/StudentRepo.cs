using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo
    {
        private static Lab3Task1Context dbContext = new Lab3Task1Context();

        public static int Create(Student student)
        {
            StudentRepo.dbContext.Students.Add(student);

            return StudentRepo.dbContext.SaveChanges();
        }

        public static List<Student> Gets()
        {
            return StudentRepo.dbContext.Students.ToList();
        }

        public static Student Get(int StudentId)
        {
            return StudentRepo.dbContext.Students.Find(StudentId);
        }

        public static int Update(Student student)
        {
            var _student = StudentRepo.Get(student.Id);

            _student.Name = student.Name;
            _student.Dob = student.Dob;
            _student.DepartmentId = student.DepartmentId;

            return StudentRepo.dbContext.SaveChanges();
        }

        public static int Delete(int StudentId)
        {
            StudentRepo.dbContext.Students.Remove(StudentRepo.Get(StudentId));

            return StudentRepo.dbContext.SaveChanges();
        }
    }
}
