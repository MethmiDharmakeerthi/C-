using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void LogFile(string action = "INFO", string message = "")
        {
            string txtFile = @"D:\hey\C#\WindowsFormsApp1\WindowsFormsApp1\Log.txt";

            StreamWriter log;
            if (!File.Exists(txtFile))
            {
                log = new StreamWriter(txtFile);
            }
            else
            {
                log = File.AppendText(txtFile);
            }

            log.Write(DateTime.Now);
            log.WriteLine("\t[" + action + "]\t:\t" + message);
            log.Close();
        }
    }
}
