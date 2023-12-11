using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ict20832question3
{

    public partial class Form1 : Form
    {
        private static int teacount,milkcount,coffeecount = 0;
        private static int discount = 0;
        private static double total;

      
        public Form1()
        {
            InitializeComponent();
        }
        private void DecrementRestricMinus(int a, TextBox txtbox) 
        {
            a--;
            txtbox.Text = a.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                total = teacount * 50 + coffeecount * 100 + milkcount * 150;

                if (textBox4.Text.Trim() == "" || Convert.ToInt32(textBox4.Text) == 0)
                {

                    label11.Text = total.ToString();
                }
                else
                {
                    discount = Convert.ToInt32(textBox4.Text);
                    double totaldiscount = total * discount / 100;
                    label10.Text = totaldiscount.ToString();
                    total = total - totaldiscount;
                    label11.Text = total.ToString();
                }
            }
            catch (Exception ex)
            { 
            MessageBox.Show(ex.Message);

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacount++;
            textBox1.Text = teacount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teacount--;
            textBox1.Text = teacount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            milkcount++;
            textBox2.Text = milkcount.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            milkcount--;
            textBox2.Text = milkcount.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            coffeecount++;
            textBox3.Text= coffeecount.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            coffeecount--;
            textBox3.Text= coffeecount.ToString();
        }
    }
}
