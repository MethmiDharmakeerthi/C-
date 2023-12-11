namespace Animal
{
    class Animal
    { 
        private string NumofLegs;
        public virtual void speak()
        {
            Console.WriteLine("Animals Speaks");
        }
    }

    class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Cats Meowww");
        }
    }
    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Dogs Bark");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Animal Animal1 = new Animal();
            Console.WriteLine("Animal speaks :- {0}",Animal1.speak);

            Cat cat1 = new Cat();
            Console.WriteLine("Animal speaks :- {0}", cat1.speak);

            Dog dog1 = new Dog();
            Console.WriteLine("Animal speaks :- {0}", dog1.speak);


        }
    }
}