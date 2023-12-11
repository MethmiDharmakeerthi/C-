using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addtwoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var num1 = Convert.ToInt32(textBox1.Text);
                var num2 = Convert.ToInt32(textBox2.Text);
                var total = num1 + num2;
                textBox3.Text = total.ToString();
                MessageBox.Show(" "+total);

            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
                textBox1.Focus();
            }
            
        }
    }
}
