using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        double area;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ludo");
            listBox1.Items.Add("Hello");
            listBox1.Items.AddRange(new string[] { "Why", "So", "Beautiful" });
            this.Controls.Add(listBox1);
            listBox1.Items.Add("HI");
            listBox1.Items.AddRange(new String[] { "Why", "Barbie" });
            this.Controls.Add(listBox2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() != "" || textBox2.Text.Trim() != "") 
            {
                double height, radius, area;
                height = Convert.ToInt32(textBox2.Text);
                radius = Convert.ToInt32(textBox1.Text);
                area = 2 * Math.PI * radius * radius + 2 * Math.PI * radius * height;
                label3.Text="Area ;- "+area;    
                label3.Show();

               

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox3.Text;
            foreach (string x in listBox1.Items) 
            { 
                if(x == searchText)
                {
                    label4.Text = "Item Found";
                    label4.Show();
                    return;
                }
               label4.Text = "Tere is no item " + searchText;
               label4.Show();

            }
        }
    }
}
