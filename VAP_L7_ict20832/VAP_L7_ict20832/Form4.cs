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

namespace VAP_L7_ict20832
{
    public partial class TableView : Form
    {
        static SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\methm\OneDrive\Documents\LAB7.mdf;Integrated Security=True;Connect Timeout=30");

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
        public TableView()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display_Data();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
