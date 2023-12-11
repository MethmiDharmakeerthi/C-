using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxLanguages.SelectedItems.Clear();
            string searchkey = searchtext.Text.ToLower();
            if (!string.IsNullOrEmpty(searchkey))
            {
                // Find the item in the list and store the index to the item.
                int index = lbxLanguages.FindString(searchkey);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (index != -1)
                {
                    lbxLanguages.SetSelected(index, true);
                    Status.Text = "The search string is matched with an item in the ListBox";
                    MessageBox.Show("The search string is matched with an item in the ListBox");


                }

                else
                {
                    Status.Text = "The search string did not match any items in the ListBox";
                    MessageBox.Show("The search string did not match any items in the ListBox");

                }
  
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
