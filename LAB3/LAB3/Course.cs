using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course() { }

        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.CourseName = courseName;
            this.CourseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public string CourseName
        {
            set { this.courseName = value; }
            get { return this.courseName; }
        }

        public string CourseCode
        {
            set { this.courseCode = value; }
            get { return this.courseCode; }
        }

        public int CourseCredit
        {
            set { this.courseCredit = value; }
            get { return this.courseCredit; }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + this.CourseName);
            Console.WriteLine("Course Code: " + this.CourseCode);
            Console.WriteLine("Course Credit: " + this.CourseCredit);
        }
    }
}
