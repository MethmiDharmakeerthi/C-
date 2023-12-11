using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3
{
    internal class Program

    {
        static void Main(string[] args)
        {

            // string trimmed_text = whole_text.Trim();
            //string[] split_text = trimmed_text.Split(' ');

            Console.WriteLine("\t**Word Count**\n");
            

            Console.Write("Enter a paragraph:- ");
            string whole_text = Console.ReadLine();
            string trimmed_text = whole_text.Trim();
            string[] split_text = trimmed_text.Split(' ');
            int space_count = 0;
            string new_text = "";

            foreach (string av in split_text)
            {
                if (av == "")
                {
                    space_count++;
                }
                else
                {
                    new_text = new_text + av + ",";
                }
            }

            new_text = new_text.TrimEnd(',');
            split_text = new_text.Split(',');
            Console.WriteLine("Words count in this paragraph is :- {0}",split_text.Length.ToString());

        }

    }
}

    
