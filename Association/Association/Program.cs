using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            //One to One

            Student s1 = new Student("19-39398-1", "Jui", 3.9F);
            Student s2 = new Student("1234", "Mahfuza", 3.85F);
            Student s3 = new Student("2905", "Sharmili", 3.8F);

            Department d1 = new Department("CS", "Computer Science");
            Department d2 = new Department("EEE", "Electrical & Electronic Engineering");

            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d1;

            s1.ShowDepartment();

            s2.ShowDepartment();
;
            s3.ShowDepartment();

         
            d1.Name = "Computer Science & Engineering";     //change the department name

            s1.ShowDepartment();

            //one to many

            d1.AddStudent(s1);
            d1.AddStudent(s2);

            d1.PrintStudent();
        }
    }
}