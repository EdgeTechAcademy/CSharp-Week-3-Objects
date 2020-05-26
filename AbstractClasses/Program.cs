using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dexter = new Dog("Dexter", 22);
            Cat felix = new Cat("Felix", 8);

            WhatSoundDoesItMake(dexter);
            WhatSoundDoesItMake(felix);
            Console.WriteLine();

            var square = new Square(12);
            Console.WriteLine($"Area of the square = {GetShapeArea(square)}");
            var circle = new Circle(12);
            Console.WriteLine($"Area of the circle = {GetShapeArea(circle)}");
            var triangle = new Triangle(12, 12);
            Console.WriteLine($"Area of the triangle = {GetShapeArea(triangle)}");
        }

        //  get the sound of the animal no matter what animal it is
        static void WhatSoundDoesItMake(Animal critter)
        {
            Console.WriteLine($"What does {critter.Name} say? {critter.Sound()}");
        }

        //  get area of the shape no matter what shape the shape is in
        static double GetShapeArea(Shape shape)
        {
            return shape.GetArea();
        }
    }
}
