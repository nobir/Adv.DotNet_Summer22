using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public double Cgpa { get; set; }

        public Student(int id, string name, DateTime dob, double cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Dob = dob;
            this.Cgpa = cgpa;
        }
    }
}
