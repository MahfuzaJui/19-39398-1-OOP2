using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student() { }

        public Student(string name, string id, string department, float cgpa)
        {
            this.Name = name;
            this.Id = id;
            this.Department = department;
            this.CGPA = cgpa;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Department
        {
            set { this.department = value; }
            get { return this.department; }
        }

        public float CGPA
        {
            set { this.cgpa = value; }
            get { return this.cgpa; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Department: " + this.Department);
            Console.WriteLine("CGPA: " + this.CGPA);
        }

    }
}
