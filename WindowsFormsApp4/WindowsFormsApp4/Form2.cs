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
    public partial class Form2 : Form
    {
        public string FirstName;
        public string LastName;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string Firstname, string Lastname) 
        {
            this.FirstName = Firstname;
            this.LastName = Lastname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            //label1.Show();
        }
    }
}
