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





namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\methm\OneDrive\Documents\Hello.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void clear_text()
        {
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
            dispaly();


        }
        private void button2_Click(object sender, EventArgs e) 
        
        {
            dispaly();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        public void dispaly() 
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [vvTable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dta);
            dataGridView1.DataSource = dta;
            conn.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "!";

               
    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("You should enter Values");
                label5.Show();
            }
            else
            {
                label5.Hide();
                Save();
            }
        }

        public void Save()
        {
              //  try
              //  {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into [vvTable](regNo,FirstName,LastName,dob)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "')";
                    cmd.ExecuteNonQuery();
                    clear_text();
                    MessageBox.Show("Data Inserted Successfully");

                /* }
               catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }*/


            }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dispaly();
        }
    }
}
