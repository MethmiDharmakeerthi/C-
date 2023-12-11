using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                label3.Show();

            }
            else
            {
                label3.Hide();
                // Form2 form2 = new Form2(textBox1.Text,textBox2.Text);
                //form2.Show();
                
                Form3 form3 =new Form3(textBox1.Text,textBox2.Text);
                form3.Show();
                this.Hide();
            }
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Enter Both First Name and Last Name";
        }
    }
}
