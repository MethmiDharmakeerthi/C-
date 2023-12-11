using System.Security.Cryptography.X509Certificates;

namespace Base
{
     class Base
    {
        readonly string [] BrandName = {"Lenovo","Dell","Sony"};
        readonly int[] Price = {60000,65000,70000};
        public string[] Processor = {"i5","i7","i9"};
        public string[] RAM = {"2GB","4GB","8GB"};
        public string[] HDD = {"500GB","1TB","1TB" };
        public int i;

        public void SetInfo(int i)
        {
            String BrandId = BrandName[i];
            int price = Price[i];
            string processor = Processor[i]; 
            string Ram = RAM[i];
            string hdd= HDD[i];
        }
        public void Print() 
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Brand Name :- {0}", BrandName[i]);
            Console.WriteLine("Price      :- {0}", Price[i]);
            Console.WriteLine("Processor  :- {0}", Processor[i]);
            Console.WriteLine("RAM        :- {0}", RAM[i]);
            Console.WriteLine("Hard Drive :- {0}", HDD[i]);
        }
    }

  
    class LaptopDetails
    {
        string[] Laptops = { "Laptop1", "Laptop2", "Laptop3" };
        static void Main(string[] args)
        {
            Base LapTop1 = new Base();
            LapTop1.SetInfo(0);
            LapTop1.Print();

            Base LapTop2=new Base();
            LapTop2.SetInfo(1);
            LapTop2.Print();

            Base LapTop3 = new Base();
            LapTop3.SetInfo(2);
            LapTop3.Print();
            
        }

    }
}