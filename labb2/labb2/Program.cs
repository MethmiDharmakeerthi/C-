namespace labb2
{
    class Labs
    {
        public void Quest1 ()
        {
            for(int i=1 ; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public void Quest2(int LL, int UL)
        {
            
            for (int f=LL; f <UL; f++)
            {
                int count = 0;
                for (int n = 1; n <= f; n++)
                {
                    if (f % n == 0)
                    {
                        //Console.WriteLine(f);
                        count++;                       
                    }
                }
                if (count == 2)
                {
                    Console.Write("{0}, ", f);
                }
            }
            Console.ReadLine();
        }

        public void Quest3() 
        {
            Console.WriteLine("\tCalculate Sum of N numbers ");
            Console.WriteLine("\t---------------------------");

            Console.Write("\n*How many numbers to Calculate Sum :- ");
            int N=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine("Enter Number {0} :- ",i+1);
                int num=Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("Sum :- ", sum);
        }

        public void Quest4() 
        {
        
        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Labs labs= new Labs();
            labs.Quest3();    
        }
    }
}