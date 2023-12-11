using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace VAP_L6_ICT20832
{
    public partial class Form1 : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\methm\OneDrive\Documents\LAB6.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection cmd;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txname.Text == "")
            {
                MessageBox.Show("Enter Your Name");
                txname.Focus();
            }

            string gender = "";
            if (Male.Checked)
            {
                gender = "Male";
            }
            else if (Female.Checked)
            {
                gender = "Female";
            }

            string Sports = "";
            foreach (var checkedItem in this.checkedListBox2.CheckedItems)
            {

                Sports += checkedItem.ToString() + ",";

            }

            if (DateTime.Now.Year!=null && txname.Text!=null && PhoneNum.Text!=null && gender!="" && comboBox1 != null)
                {
                    try
                    {
                        myConn.Open();
                        SqlCommand cmd = myConn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [myTable](Name,DOB,PhoneNo,Gender,Department,Sports) values ('" + txname.Text + "','" + dateTimePicker1.Text + "','" + PhoneNum.Text + "','" + gender + "','" + comboBox1.Text + "','" + Sports + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data INSERTED Successfully");
                        Execte_Close_Clear_TextBoxes();
                    }
                    catch
                    {
                        MessageBox.Show("Something Wrong. Please Check again");

                    }

                }
                else
                {
                MessageBox.Show("Something Wrong. Please Check again");
                }

        }
        public void Execte_Close_Clear_TextBoxes()
        {
            myConn.Close();
            txname.Clear();
            PhoneNum.Clear();
            comboBox1.Focus();
            foreach (int i in checkedListBox2.CheckedIndices)
            {
                checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }

        }
        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
