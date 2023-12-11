using System.Reflection.Emit;

namespace example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numarray = new float[5];
            float sum = 0;


            Console.WriteLine("\tRead 5 numbers and calculate sum and average");
            Console.WriteLine("\t--------------------------------------------\n");
            Console.WriteLine("-input 5 numbers\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Number  {0} :-  ", i+1);
                float num = Single.Parse(Console.ReadLine());
                numarray[i] = num;
            }
            Console.WriteLine("\n\n\t***Entered Numbers***");
            for (int j = 0; j < 5; j++) 
            {
                sum = sum + numarray[j];
                Console.WriteLine(numarray[j]);
            }

            Console.WriteLine("\n* Sum of the Numbers :- {0}",sum);
            Console.WriteLine("* Average of the Numbers :- {0}",sum/5);
            Console.ReadKey();
            
        }
    }
}