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
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        SqlConnection myConn =new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\methm\OneDrive\Documents\DB_Server1.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlConnection cmd;
        public Form1()
        {
            Program.LogFile("INFO", "Program is STARTED");

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myConn.Open(); 
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "INSERT INTO [MyTable](Name,SurName,Address) values ('"+txbName.Text+ "','"+ txbSurName .Text+ "','"+txbAddress.Text+"')";
            cmd.ExecuteNonQuery();
            Program.LogFile("INFO", "Data has been INSERTED");

            Execte_Close_Clear_TextBoxes();
            MessageBox.Show("Data INSERTED Successfully");
        }
        //To Clear Fields 
        public void Execte_Close_Clear_TextBoxes()
        {
            myConn.Close();
            txbName.Clear();
            txbSurName.Clear();
            txbAddress.Clear();
            txbSearch.Clear();
            Display_Data();
            Program.LogFile("INFO", "Feilds are REFRESHED");
        }
        //To Display Data
        public void Display_Data()
        {
            myConn.Open();
            SqlCommand cmd=myConn.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText="Select * from [MyTable]";
            cmd.ExecuteNonQuery();           
            DataTable myDTable = new DataTable();
            SqlDataAdapter myDAdapter = new SqlDataAdapter(cmd);
            myDAdapter.Fill(myDTable);
            dataGridView1.DataSource = myDTable;
            Program.LogFile("INFO", "All the Data is Displayed");
            myConn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM [MyTable] where Name = '" + txbName.Text + "'";
            cmd.ExecuteNonQuery();
            Execte_Close_Clear_TextBoxes();
            MessageBox.Show("Data DELETED Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //or Address ='"+ txbAddress + "'
            cmd.CommandText = "UPDATE [MyTable] set Name = '" + txbName.Text + "' where SurName = '"+ txbSurName.Text +"'";
            cmd.ExecuteNonQuery();
            Execte_Close_Clear_TextBoxes();
            MessageBox.Show("Data UPDATED Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myConn.Open();
            SqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [MyTable] where Name = '" + txbSearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable DT=new DataTable();
            SqlDataAdapter DA =new SqlDataAdapter(cmd);
            DA.Fill(DT);
            dataGridView1.DataSource= DT;
            myConn.Close();
            txbName.Clear();
            txbSurName.Clear();
            txbAddress.Clear();
            txbSearch.Clear();
            MessageBox.Show("Data Searched Successfully");
        }
    }
}
