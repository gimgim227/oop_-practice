using System;
using System.Collections.Generic;
using System.Text;

namespace oop_practice.Models.Shape
{
    public class Square : Shape
    {
        private double _len = 0;
        public double Len
        {
            get { return _len; }
            set { _len = value; }
        }
        public Square() : base()
        {
            this.ShapeName = "Square";
        }
        public Square(double len) : this()
        {
            this.Len = len;
        }
        public override double calsArea()
        {
            Area = _len * _len;
            return Area;
        }
    }
}
