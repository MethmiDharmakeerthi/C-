using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wicrama_business
{
    internal static class Program
    {
        public static void LogFile(string action = "INFO", string message = "")
        {
            string txtFile = @"D:\hey\C#\WindowsFormsApp2\auditlog.txt";

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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcomepage());
        }
    }
}
