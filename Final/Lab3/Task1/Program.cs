using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach(var student in StudentServices.Gets())
            {
                Console.WriteLine(student.Name.ToString());
            }
        }
    }
}
