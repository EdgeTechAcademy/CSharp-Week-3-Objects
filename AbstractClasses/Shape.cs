using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class Shape
    {
        // Classes extendding Shape require the GetArea method to avoid a compile-time error
        public abstract double GetArea();
    }

    class Square : Shape
    {
        double side;
        public Square(double n) => side = n;
        public override double GetArea() => side * side;

    }
    class Circle : Shape
    {
        double radius;
        public Circle(double n) => radius = n;
        public override double GetArea() => Math.PI * radius * radius;

    }
    class Triangle : Shape
    {
        double height, width;
        public Triangle(double height, double width) {
            this.height = height; this.width = width; 
        }
        public override double GetArea() => .5 * height * width;
    }
}
