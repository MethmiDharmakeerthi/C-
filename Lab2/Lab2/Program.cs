namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0,i,n;

            for ( i = 1; i < 100; i++)
            {
                for ( n =1 ; n <=i; n++)
                {
                    if (i % n == 0)
                        count ++;
                        
                }
                if (count == 2)
                {
                    Console.WriteLine("{0}",i);
                }
            }

        }
    }
}