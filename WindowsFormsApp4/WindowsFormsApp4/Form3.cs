using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public string FirstName, LastName;


        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string FirstName, string LastName) 
        {
            InitializeComponent(); 
            this.FirstName= FirstName;
            this.LastName= LastName;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "HI" + FirstName + " " + LastName;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
