using System;
using System.Collections.Generic;
using System.Text;

namespace oop_practice.Models.Shape
{
    public class Circle : Shape
    {
        const double PI = 3.1415;
        private double _r = 0;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        public Circle() : base()
        {
            this.ShapeName = "Circle";
        }
        public Circle(double r) : this()
        {
            this.R = r;
        }
        public override double calsArea()
        {
            Area = PI * R * R;
            return Area;
        }
    }
}
