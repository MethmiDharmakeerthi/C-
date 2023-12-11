using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace two
{
    public partial class Form1 : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\methm\OneDrive\Documents\LAB6-2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection cmd;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Display_Data()
        {
            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [empTable]";
            cmd.ExecuteNonQuery();
            DataTable myDTable = new DataTable();
            SqlDataAdapter myDAdapter = new SqlDataAdapter(cmd);
            myDAdapter.Fill(myDTable);
            dataGridView1.DataSource = myDTable;
            myConn.Close();
        }
        public void Execte_Close_Clear_TextBoxes()
        {
            myConn.Close();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            Display_Data();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [empTable] where Name = '" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            Execte_Close_Clear_TextBoxes();
            MessageBox.Show("Data DELETED Successfully");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String gender = "";
            if (male.Checked)
            {
                gender = "Male";
            }
            else if (female.Checked)
            {
                gender = "Female";
            }
            else if (other.Checked)
                gender = "Other";

            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [empTable](EmpId,Name,HomeTown,Age,AppDate,Gender) values ('" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.Date + "','"+gender+"')";
            cmd.ExecuteNonQuery();

            Execte_Close_Clear_TextBoxes();
            MessageBox.Show("Data INSERTED Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //or Address ='"+ txbAddress + "'
            cmd.CommandText = "UPDATE [MyTable] set Name = '" + textBox2.Text + "' where EmpId = '" + textBox5.Text + "'";
            cmd.ExecuteNonQuery();
            Execte_Close_Clear_TextBoxes();
            MessageBox.Show("Data UPDATED Successfully");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [empTable] where Name = '" + textBox6.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            myConn.Close();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


            MessageBox.Show("Data Searched Successfully");
        }
    }
}
