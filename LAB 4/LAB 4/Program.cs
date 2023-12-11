using System;

namespace LAB_4
{
    class Student
    {
        private string Name,HomeTown;
        private int Age;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string homeTown
        {
            get { return HomeTown; }
            set { HomeTown = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }


        public void printMethod()
        {
            Console.WriteLine("\nStudent's Name is {0} ", Name);
            Console.WriteLine("Student's HomeTown is {0}",HomeTown);
            Console.WriteLine("Studnet's Age is {0}", age);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            Console.Write("Enter Your Name :- ");
            s1.name =Console.ReadLine();

            Console.Write("Enter HomeTown :- ");
            s1.homeTown = Console.ReadLine();

            Console.Write("Enter Age :- ");
            s1.age = Convert.ToInt32(Console.ReadLine());

            s1.printMethod();

            Console.ReadKey();

        }
    }
}