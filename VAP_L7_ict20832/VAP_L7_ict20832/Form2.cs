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
using static System.Windows.Forms.AxHost;

namespace VAP_L7_ict20832
{
    public partial class EmpRegForm : Form
    {
        static SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\methm\OneDrive\Documents\LAB7.mdf;Integrated Security=True;Connect Timeout=30");

        public EmpRegForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                SqlCommand cmdd = myConn.CreateCommand();
                cmdd.CommandType = CommandType.Text;
                cmdd.CommandText = "INSERT INTO [empTable](EmpId,Name,Age,City,AppDate) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "')";

                // cmdd.CommandText = "INSERT INTO [dbo].[empTable](App.Date) VALUES(@Adate);";
                //cmdd.Parameters.Add("@Adate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;


                cmdd.ExecuteNonQuery();

                Execte_Close_Clear_TextBoxes();
                MessageBox.Show("Data INSERTED Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Execte_Close_Clear_TextBoxes()
        {
            myConn.Close();
            textBox1.Clear();
            textBox1.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();

            var dispalyD = new TableView();
            dispalyD.Display_Data();

        }
       
    }
}
