using System;
using System.Collections.Generic;
using System.Text;

namespace oop_practice.Models.Shape
{
    public abstract class Shape
    {
        private double _area;
        private string _shapename;
        protected double Area
        {
            get { return _area; }
            set { _area = value; }
        }
        protected string ShapeName
        {
            get { return _shapename; }
            set { _shapename = value; }
        }
        protected Shape()
        {
            _area = 0;
            _shapename = "";
        }

        public double getArea()
        {
            return this.calsArea();
        }
        public abstract double calsArea();
        public virtual void printArea()
        {
            Console.WriteLine(String.Format(@"{0} Area：{1}", ShapeName, getArea()));
        }
    }
}
