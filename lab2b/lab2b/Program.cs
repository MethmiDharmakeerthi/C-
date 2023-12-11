using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace lab2b
{


    class Customer
    {
        class Animal
        {
            public string name, breed, age;
            public void run()
            {
                Console.WriteLine("Animal is running");
            }
        }
        class Dog : Animal
        {
            public void bark()
            {
                Console.WriteLine("Dog is barking");
            }
        }

    }
}
