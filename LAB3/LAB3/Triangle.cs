using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;


        public Triangle() { }

        public Triangle(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X
        {
            set { this.x = value; }
            get { return this.x; }
        }

        public int Y
        {
            set { this.y = value; }
            get { return this.y; }
        }

        public int Z
        {
            set { this.z = value; }
            get { return this.z; }
        }

        public void TestTriangle()
        {
            string val = "";
            if(this.x == this.y && this.y == this.z)
            {
                val = "Equilateral";
            }
            else if(this.x == this.y || this.y == this.z || this.z == this.x)
            {
                val = "Isosceles";
            }
            else
            {
                val = "Scalene";
            }

            Console.WriteLine("Test Triable: {0}", val);
        }

        public void ShowInfo()
        {
            Console.WriteLine("X: " + this.X);
            Console.WriteLine("Y: " + this.Y);
            Console.WriteLine("Z: " + this.Z);
        }
    }

}
