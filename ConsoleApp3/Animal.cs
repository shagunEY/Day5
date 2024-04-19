using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Sound of animal");
        }
    }
    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Cat: Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        public static void Main()
        {
            Animal ani = new Animal();
            ani.makeSound();
            Animal dog = new Dog();
            dog.makeSound();
            Animal cat = new Cat();
            cat.makeSound();
        }
    }
}
