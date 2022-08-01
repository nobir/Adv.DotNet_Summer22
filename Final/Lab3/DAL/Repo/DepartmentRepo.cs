using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class DepartmentRepo
    {
        private static Lab3Task1Context dbContext = new Lab3Task1Context();

        public static int Create(Department department)
        {
            DepartmentRepo.dbContext.Departments.Add(department);

            return DepartmentRepo.dbContext.SaveChanges();
        }

        public static List<Department> Gets()
        {
            return DepartmentRepo.dbContext.Departments.ToList();
        }

        public static Department Get(int DepartmentId)
        {
            return DepartmentRepo.dbContext.Departments.Find(DepartmentId);
        }

        public static List<Student> GetStudentsByDepartment(int DepartmentId)
        {
            return DepartmentRepo.dbContext.Departments.Find(DepartmentId).Students.ToList();
        }

        public static List<Student> GetStudentsByDepartment(Department department)
        {
            return DepartmentRepo.dbContext.Departments.Find(department).Students.ToList();
        }

        public static int Update(Department department)
        {
            var _department = DepartmentRepo.Get(department.Id);

            _department.Name = department.Name;

            return DepartmentRepo.dbContext.SaveChanges();
        }

        public static int Delete(int DepartmnetId)
        {
            DepartmentRepo.dbContext.Departments.Remove(DepartmentRepo.Get(DepartmnetId));

            return DepartmentRepo.dbContext.SaveChanges();
        }
    }
}
