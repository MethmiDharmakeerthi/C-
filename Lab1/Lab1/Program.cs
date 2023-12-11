using System.IO.Pipes;

namespace Lab1
{
    class Questions
    {
        public void Quest3()
        {
            Console.WriteLine("\tAdd Two Integers");
            Console.WriteLine("\t--------------------\n");

            Console.Write("\n*Enter 1st Int Value :- ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n*Enter 2nd Int Value :- ");
            int val2 = Int32.Parse(Console.ReadLine());

            int sum = val1 + val2;
            Console.WriteLine("\n*Total :- " + sum);

            Console.ReadKey();
        }

        public void Quest5(float num1,float num2) 
        {
            Console.WriteLine("\tAdd two Doubles");
            Console.WriteLine("\t-----------------\n");
            float sum = num1 + num2;
            Console.WriteLine("*{0} + {1} :- {2}\n", num1, num2, sum);

            Console.ReadKey();
        }

        public void Quest4() 
        {
            Console.WriteLine("\tMultiply two Doubles");
            Console.WriteLine("\t----------------------\n");
            Console.Write("Enter First Double  :- ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter Second Double :- ");
            double y = Double.Parse(Console.ReadLine());
            double mul = x * y;
            Console.WriteLine("\n*{0} * {1} = {2}\n", x, y, mul);
            Console.ReadLine();
        }

        public void Quest6() 
        {
            Console.WriteLine("Calculate Simple Interest");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine("* Simple Interest = Principal * Time * Rate \n");
            Console.Write("\n-Enter Principle Amount :- ");
            double p = Double.Parse(Console.ReadLine());
            Console.Write("\n-Enter Time Period :- ");
            double t = Double.Parse(Console.ReadLine());
            Console.Write("\n-Enter Interest Rate :- ");
            double r = Convert.ToDouble(Console.ReadLine());

            double interset = (p * t * r) / 100;
            Console.WriteLine("**Interest :- "+interset);
            Console.ReadLine();



        }

        public void Quest7( double l, double w) 
        {
            Console.WriteLine("\tArea of a Rectangle");
            Console.WriteLine("------------------------\n");
            double area = l * w;
            Console.WriteLine("Area of Rectangle is :-  {0}", area);
        }

        public void Quest8() 
        {
            Console.WriteLine("\tArea and Perimeter Calculator");
            Console.WriteLine("\t-------------------------------\n");
            Console.Write("*Enter Radius :- ");
            double R = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI*R*R;
            double perimeter = 2*Math.PI*R;
            
            Console.WriteLine("\n*Area of the Circle :- "+area);
            Console.WriteLine("\n*Perimeter of the Circle :- " + perimeter);
            
        }
        public void Quest9() 
        {
            Console.WriteLine("\tAverage Calculator");
            Console.WriteLine("\t------------------\n");
            Console.Write("Enter 1'st Num :- ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2'nd Num :- ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd Num  :- ");
            int third = Convert.ToInt32(Console.ReadLine());

            double ave = (first + sec + third) / 3;
            Console.WriteLine("Average of {0} , {1} ,{2} :- {3}",first,sec,third,ave);
            Console.ReadLine() ;
        }
        public void Quest10()
        {
            Console.WriteLine("\tAverage Calculator");
            Console.WriteLine("\t------------------\n");
            Console.Write("\n* Enter Base Integer :- ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n* Enter Power Integer :-");
            int powNum=Convert.ToInt32(Console.ReadLine());
            double ans = Math.Pow(baseNum,powNum);
            Console.WriteLine("\n* {0} ^ {1} = {2}", baseNum, powNum, ans);
            Console.ReadLine() ;
        }

        public void Quest11() 
        {
            Console.WriteLine("\t Word Count of a String");
            Console.WriteLine("\t------------------------\n");
            Console.Write("Enter Paragraph :- ");
            string para = Console.ReadLine();
            string trimmedpara = para.Trim();
            string [] splitpara = trimmedpara.Split(" ");
            int wordcount = splitpara.Length;
            foreach (string s in splitpara)
            {
                if (s == "") 
                {
                    wordcount--;
                }
            }
            Console.WriteLine("Word Count :- {0}", wordcount);

        }

        public void wordcount() 
        {
            Console.WriteLine("Enter paragraph :- ");
            string para= Console.ReadLine();
            string[] splitpara = para.Split(" ");
            int wordcount =splitpara .Length;
            foreach (string s in splitpara) 
            {
                if (s == "") 
                {
                    wordcount--;
                }
            }
            Console.WriteLine("Word count :- "+ wordcount);
        }

        public void Quest12() 
        {
            double rupeerate = 365.96;
            Console.WriteLine("\t USD to LKR converter");
            Console.WriteLine("\t----------------------\n");
            Console.WriteLine("Enter Amount USD :-  ");
            double amount =Convert.ToDouble(Console.ReadLine());
            double amountrs = amount / rupeerate;
            Console.WriteLine("{0} USD is {1:F2} Rupees",amount,amountrs);

        }

        public void Quest13(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x + " is an even number");
            }
            else
                Console.WriteLine(x + "is an odd Number");
        }

        public void Quest14(int num1,int num2,int num3)
        {
            int[] num = { num1, num2, num3 };
            int max = num.Max();
            Console.WriteLine("Max num among {0},{1},{2} is :- {3}",num1,num2,num3,max);
            Console.ReadLine();

        }

        public void Quest15(string month) 
        {
            string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            for(int i=0;i<months.Length;i++) 
            {
                if (month.ToLower() == months[i])
                {
                    int monthindex=i+1;
                    Console.WriteLine(month+" is {0}' Month ",monthindex);
                    return;
                }
            }
            Console.WriteLine(month + " is Not Found ");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Questions ques = new Questions();
            ques.Quest15("DEcember");
            //ques.Quest14(25, 75, 39);
            //ques.Quest13(14);
           // ques.cuurencyconverter();
            //ques.wordcount();
            //ques.Quest11();
           // ques.Quest10();
            //ques.Quest9();
           // ques.Quest8();

            //ques.Quest7(10,5);
            //ques.Quest6();
           // ques.Quest4(10.25f,10.00f);
           // ques.addTwoDoubles();
        }
    }

  
}