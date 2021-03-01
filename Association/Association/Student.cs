using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        private string id;
        private string name;
        private float cgpa;

        private Department dept;

        public Student() { }

        public Student(string id, string name, float cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Cgpa = cgpa;
        }

        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }

        }

        public float Cgpa
        {
            set { this.cgpa = value; }
            get { return this.cgpa; }
        }

        public Department Dept
        {
            set { this.dept = value; }
            get { return this.dept; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student Name: {0}", this.Name);
            Console.WriteLine("Student ID: {0}", this.Id);
            Console.WriteLine("CGPA: {0}", this.Cgpa);
        }

        public void ShowDepartment()
        {
            this.ShowInfo();
            this.Dept.ShowInfo();
        }
    }
}