using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = { 23, 4, 45, 2, 6, 673, 4, 35, 67, 8, 434 };

            var filter_numbers = (from number in numbers where number > 20 select number).ToArray();

            foreach (var number in filter_numbers)
            {
                Console.WriteLine(number);
            }
            */

            List<Student> students = new List<Student> {
                new Student(1, "Name 1", new DateTime(1992, 03, 2), 2.5),
                new Student(2, "Name 2", new DateTime(1990, 03, 2), 2.9),
                new Student(3, "Name 3", new DateTime(2015, 03, 2), 3.4),
                new Student(4, "Name 4", new DateTime(1996, 03, 2), 3.7),
                new Student(5, "Name 5", new DateTime(1998, 03, 2), 3.9)
            };
            /*
            foreach (var student in students)
            {
                Console.WriteLine();
            }
            */

            var filter1 = (from student in students where student.Cgpa > 3.0f select student).ToList();

            var filter2 = (from student in students where student.Id > 3 && student.Cgpa > 2.5 select student).ToList();

            var filter3 = (from student in students where (DateTime.Now.Subtract(student.Dob).Days / 365 > 18) select student).ToList();

            var filter4 = (from student in students select new { Id = student.Id, Cgpa = student.Cgpa }).ToList();

            var filter5 = (from student in students where (DateTime.Now.Subtract(student.Dob).Days / 365 < 16) select new { Id = student.Id, Dob = student.Dob}).ToList();


            foreach (var student in filter3)
            {
                // Filter 5
                // Console.WriteLine(student.Id + " " + student.Dob.ToShortDateString());

                // Filter 4
                // Console.WriteLine(student.Id + " " + student.Cgpa);

                // Filter 3, 2 and 1
                Console.WriteLine(student.Id + "\t" + student.Name + "\t" + student.Dob.ToShortDateString() + "\t" + student.Cgpa);
            }
        }
    }
}
