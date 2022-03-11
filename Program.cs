using oop_practice.Models.Shape;
using System;

namespace oop_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapeCircle = new Circle(10);
            shapeCircle.printArea();

            var shapeSquare = new Square(15);
            shapeSquare.printArea();

            var shapeTriangle = new Triangle(3, 4, 5);
            shapeTriangle.printArea();
        }
    }
}
