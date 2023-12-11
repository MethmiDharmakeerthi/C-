using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cylinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void topic_Click(object sender, EventArgs e)
        {

        }

        private void area_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 2πr(r + h)
            double radius, CyArea,Height;
            radius = Convert.ToDouble(tbxradius.Text);
            Height=Convert.ToDouble(tbxheight.Text);
            CyArea = Math.Round(2 * Math.PI * radius * (radius + Height),2);
            area.Text = "Area of Cylinder is :" + CyArea.ToString();
            MessageBox.Show("Area of Cylinder is " + CyArea);

        }
    }
}
