using System;
using System.Text;
using System.Xml.Linq;

namespace ConsoleAppStudentRankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
             String csvfile = @"D:\hey\C#\ConsoleAppStudentRankingSystem\ConsoleAppStudentRankingSystem\Output.txt";
            try
            {
                FileHandler.writeLog(0,"Program has been started ","Pragram","Main");
                Console.WriteLine("\n\t ** Student Ranking System **\n");                //Topic
                string[] Subjects = { "Maths", "English", "Science", "IT" };               //Subjects Array
                Console.Write("\nEnter the Number of Students in the class :-  ");       //Get Number of Students to be calculated                
                int NumofStud = Convert.ToInt32(Console.ReadLine());
                FileHandler.writeLog(0, "Number of Students to be calculated has been Entered.", "Program", "Main");

                String[] StudentName = new String[NumofStud];
                Double[] StudentMarks = new double[Subjects.Length];
                Double[] StudentAverage = new double[NumofStud];
                string[] StudentMaxSub = new string[Subjects.Length];
                FileHandler.writeLog(0, "Variables and Arrays has been created ", "Program", "Main");


                for (int i = 0; i < NumofStud; i++)
                {
                    Console.WriteLine("\n\n-- Student {0} Details.--\n", i + 1);
                    Console.Write("\n* Enter Name:- ");
                    StudentName[i] = Console.ReadLine();
                    FileHandler.writeLog(0, " User Name has been entered ", "Program", "Main");


                    for (int n = 0; n < Subjects.Length; n++)
                    {
                        Console.Write("\n* Enter {0}'s {1} Marks :- ", StudentName[i], Subjects[n]);
                        StudentMarks[n] = Convert.ToInt32(Console.ReadLine());
                        FileHandler.writeLog(0, "Student Mark is inserted ", "Program", "Main");

                    }
                    int IndexofMaxMarks = Array.IndexOf(StudentMarks, StudentMarks.Max());
                    StudentMaxSub[i] = Subjects[IndexofMaxMarks];                     //IndexofMaxMarks=Index of MaxSub
                    StudentAverage[i] = (StudentMarks.Sum() / (StudentMarks.Length));
                    FileHandler.writeLog(0, "Students best subject is calculated", "Program", "Main");

                }
                var RankArray = StudentAverage.Clone();     //Clone of Rank Array
                Array.Sort((Array)RankArray);                  //Sort Clone Array
                Array.Reverse((Array)(RankArray));
                FileHandler.writeLog(0, "Rank array is sorted ", "Program", "Main");


                Console.WriteLine("\n\n\t ** Students and Marks **\n");
                for (int m = 0; m < NumofStud; m++)
                {
                    int RankofStudent = Array.IndexOf((Array)RankArray, StudentAverage.GetValue(m)) + 1;
                    Console.WriteLine("{0}'s Average {1}\t  Max Sub {2}\t Rank {3}", StudentName[m], StudentAverage[m], StudentMaxSub[m], RankofStudent);
                    FileHandler.writeLog(0, "Students names average best subject has been desplayed ", "Program", "Main");

                }

                
            }
            catch
            {
                FileHandler.writeLog(0, "There is a problem with entered Details ", "Program", "Main");

            }


            try
         
            {
                String separator = ",";
                StringBuilder output = new StringBuilder();
                String[] headings = { "Student Name", "Rank", "Best Subject" };
                output.AppendLine(string.Join(separator, headings));
                File.AppendAllText(csvfile, output.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data could not be written to the CSV file.");
                return;
            }
            Console.WriteLine("The data has been successfully saved to the CSV file");
           
            Console.ReadKey();


        }
    
        
        }

    }

























