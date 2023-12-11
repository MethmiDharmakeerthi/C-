using methmi;
void prints()
{
}
static void Main(String[] args)
{
    Student st1 = new Student();
    Console.Write("Enter Student Name :-");
    st1.Name = Console.ReadLine();
    Console.Write("Enter Studnet HomeTown :- ");
    st1.Hometown = Console.ReadLine();
    Console.Write("Enter Student Age :- ");
    st1.Age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Student Name is {0}", st1.Name);

    prints();
    Console.ReadKey();

}



namespace methmi
{
    class Student
    {
        private string name;
        private int age;
        private string hometown;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Hometown
        {
            get { return hometown; }
            set { hometown = value; }
        }
    }
}