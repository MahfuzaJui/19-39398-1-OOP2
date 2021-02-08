using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Student
             */
            Console.WriteLine(" Student ");

            Student student1 = new Student();

            student1.Name = "Mahfuza Sharmili Jui";
            student1.Id = "19-39398-1";
            student1.Department = "CSE";
            student1.CGPA = 3.85F;

            student1.ShowInfo();


            Student student2 = new Student("JUI", "19-32424-1", "CSE", 2.5F);
            student2.ShowInfo();

            Console.WriteLine("\n");

            /**
             * Triangle
             */


            Console.WriteLine("Triangle ");

            Triangle triangle1 = new Triangle();

            triangle1.X = 20;
            triangle1.Y = 20;
            triangle1.Z = 20;

            triangle1.ShowInfo();
            triangle1.TestTriangle();


            Triangle triangle2 = new Triangle(20, 30, 20);
            triangle2.ShowInfo();
            triangle2.TestTriangle();

            Triangle triangle3 = new Triangle(20, 30, 40);
            triangle3.ShowInfo();
            triangle3.TestTriangle();

            Console.WriteLine("\n");

            /**
             * Account
             */

            Console.WriteLine(" Account ");

            Account account1 = new Account();

            account1.AccName = "Mahfuza Sharmili Jui";
            account1.Acid = "123-123-123-123";
            account1.Balance = 4000;

            account1.Deposit(1000);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", account1.AccName, account1.Acid, account1.Balance);

            account1.Withdraw(300);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", account1.AccName, account1.Acid, account1.Balance);


            Account account2 = new Account("JUI", "132-132-132-132", 40000);

            account1.Deposit(1000);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", account2.AccName, account2.Acid, account2.Balance);

            account1.Withdraw(300);
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}", account2.AccName, account2.Acid, account2.Balance);

            Console.WriteLine("\n");


            /**
             * Course
             */

            Console.WriteLine(" Course ");

            Course course1 = new Course();

            course1.CourseName = "OOP2";
            course1.CourseCode = "CSC3311";
            course1.CourseCredit = 3;

            course1.ShowCourseInfo();


            Course course2 = new Course("Software Engineering", "CSC3112", 3);
            course2.ShowCourseInfo();
        }
    }
}