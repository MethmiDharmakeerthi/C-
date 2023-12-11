using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wicrama_business
{
    
    public partial class Welcomepage : Form
    {
        public Welcomepage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Welcomepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp newsignup = new SignUp();
            newsignup.Show();
            Program.LogFile("INFO", "User SigUp Page has been Opened");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginpage = new Login();
            loginpage.Show();
            Program.LogFile("INFO", "User Login Page has been Opened");

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
