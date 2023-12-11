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
using System.Net.Configuration;

namespace wicrama_business
{
    


    public partial class SignUp : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\methm\OneDrive\Documents\CorpDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection cmd;
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void MethodMsgBox(string msg)
        {
            MessageBox.Show(msg, "CLOSE WINDOW");
        }
        public void Execte_Close_Clear_TextBoxes()
        {
            myConn.Close();
            txbxsurname1.Clear();
            tbxName.Clear();
            tbxuserName.Clear();
            txbxpw.Clear();
            txbxconfirmpw.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbxsurname1.Text != "" && txbxpw.Text != "" && txbxpw.Text == txbxconfirmpw.Text && checkBox1.Checked == true)
                {
                    myConn.Open();
                    SqlCommand cmd = myConn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [memberTable](Name,SurName,Username,Password) values ('" + tbxName.Text + "','" + txbxsurname1.Text + "','" + tbxuserName.Text + "','" + txbxpw.Text + "')";
                    cmd.ExecuteNonQuery();

                    Execte_Close_Clear_TextBoxes();
                    MessageBox.Show("Data INSERTED Successfully");
                    Program.LogFile(" DB ", "New member has been registered.");
                }
                else
                {
                    if (tbxName.Text == "")
                    {
                        MethodMsgBox("Enter Your Name !");
                        Program.LogFile("ERROR","Member Name is needed for Register");

                    }
                    else if (tbxuserName.Text == "")
                    {
                        MethodMsgBox("Enter Your UserName !");
                        tbxuserName.Focus();
                        Program.LogFile("ERROR", "Member UserName is needed for Register");

                    }
                    else if (txbxpw.Text == "")
                    {
                        MethodMsgBox("Enter Your PassWord !");
                        txbxpw.Focus();
                        Program.LogFile("ERROR", "Password is needed for Register");

                    }

                    else if (txbxpw.Text != txbxconfirmpw.Text)

                    {
                        MethodMsgBox("Password not Matching !");
                        txbxpw.Clear();
                        txbxconfirmpw.Clear();
                        txbxpw.Focus();
                        Program.LogFile("ERROR", "Password and Confirm password is not matching");

                    }
                    else if (checkBox1.Checked == false)
                    {
                        MessageBox.Show("To continue you must agree to terms and conditions !!!", "TERMS AND CONDITIONS");
                        checkBox1.Focus();
                        Program.LogFile("EROR", "Agree to Terms and Conditions");

                    }
                }
            }
          catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.LogFile("ERROR", "Exeption Occured");

            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Login loginpage = new Login();
            loginpage.Show();
            Program.LogFile("INFO", "User Login Page has been accessed");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbxpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxuserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
