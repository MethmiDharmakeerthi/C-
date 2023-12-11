namespace derivedmethod
{
    using System;
    class Base
    {
        public void Display() 
        {
            Console.WriteLine("Base Method");
        }
        public void Hey(int x)
        {
            Console.WriteLine("Method Hey using parameter {0}", x);

        }
    }
    class Derived : Base 
    {
        public new void Display() //hides base method
        {
            Console.WriteLine("Derived Method");
        }
    }
    class HideTest
    {
        static void Main(string[] args)
        {
            
            Base b = new Base();
            Derived d = new Derived();

            b.Display();
            b.Hey(3);
            d.Display();
            b.Hey(100);
        }
    }
}