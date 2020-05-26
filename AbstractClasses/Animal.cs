using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class Animal
    {
        private string name;
        private int weight;

        public abstract string Sound();

        public Animal(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
    }

    class Dog : Animal
    {
        public Dog(string name, int weight) : base(name, weight)
        {

        }
        public override string Sound()
        {
            return "woof woof";
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int weight) : base(name, weight)
        {

        }
        public override string Sound()
        {
            return "meow!";
        }
    }
}
