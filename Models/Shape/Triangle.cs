using System;
using System.Collections.Generic;
using System.Text;

namespace oop_practice.Models.Shape
{
    internal class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;
        public double A
        {
            get { return _a; }
        }
        public double B
        {
            get { return _b; }
        }
        public double C
        {
            get { return _c; }
        }
        public Triangle() : base()
        {
            this.ShapeName = "Triangle";
        }
        public Triangle(double a, double b, double c) : this()
        {

            if (this.CheckSide(a, b, c) == true)
            {
                this._a = a;
                this._b = b;
                this._c = c;
            }
        }
        public override double calsArea()
        {
            double P = (A + B + C) / 2;
            Area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return Area;
        }
        public bool CheckSide(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if ((a + b) > c && (a + c) > b && (b + c) > a)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("The three side length cannot be a triangle!");
                }
            }
            else
            {
                throw new ArgumentException("The three side length must be greater than 0");
            }
        }
    }
}
