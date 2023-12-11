namespace he
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 54, 69, 41, 3, 99, 11, 27 };

            int[] b = new int[arr.Length];

            int index, place;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                index = i - 1;
                place = length + index;
                if (index >= 0)
                {
                    b[index] = arr[i];
                }
                else
                {
                    b[place] = arr[i];
                }

            }
            foreach (int i in b)
                Console.Write("{0}", i.ToString());
        }
    }
}