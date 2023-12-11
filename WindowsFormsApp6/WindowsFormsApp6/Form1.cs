using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class Method
    {
        public static void FileLog(string action = "INFO", string message = "")
        {
            string textFile = "\\C:\\Users\\methm\\Downloads\\logg.txt";

            StreamWriter log;

            if (!File.Exists(textFile))
                log = new StreamWriter(textFile);
            else
                log = File.AppendText(textFile);

            log.Write(DateTime.Now);
            log.WriteLine("\t[" + action + "]\t:\t" + message);
            log.Close();

        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
