using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPROG2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(4.5f, 5.5f, 8.5f);
            t1.Side1 = 3.5f;
            t1.Side2 = 6.5f;
            t1.Side3 = 7.5f;

            Console.WriteLine("triangle 1:");
            Console.WriteLine("side1:{0}  side2:{1}  side3:{2}", t1.Side1, t1.Side2, t1.Side3);
            Console.WriteLine("area:{0}  perimeter:{1}", t1.FindArea(), t1.FindPerimeter());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("triangle 2:");
            Console.WriteLine("side1:{0}  side2:{1}  side3:{2}", t2.Side1, t2.Side2, t2.Side3);
            Console.WriteLine("area:{0}  perimeter:{1}", t2.FindArea(), t2.FindPerimeter());
            Console.WriteLine("--------------------------------------");
        }
    }
    class Triangle
    {
        //attribute
        private float side1;
        private float side2;
        private float side3;

        //constructor
        public Triangle()
        {

        }
        public Triangle(float side1, float side2, float side3)
        {

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;


        }

        //methods
        public double FindArea()
        {
            double area = 0;
            float p = FindPerimeter() / 2;
            area = Math.Sqrt(Convert.ToDouble(p * (p - side1) * (p - side2) * (p - side3)));
            //formula: p=(a+b+c)/2, S=√[p(p-a)(p-b)(p-c)];
            return area;
        }

        public float FindPerimeter()
        {
            float per = 0;
            per = side1 + side2 + side3;
            return per;
        }

        //properties
        public float Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value;
            }
        }
        public float Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
            }
        }

        public float Side3
        {
            get
            {
                return side3;
            }
            set
            {
                side3 = value;
            }
        }
    }
}
