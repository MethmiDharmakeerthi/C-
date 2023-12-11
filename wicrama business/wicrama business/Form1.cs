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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace wicrama_business
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            /*lblenterName.Text = "Enter your user name here";
            lblenterpw.Text = "Enter your password here";
            if(txtbxusername.Focus()==true )
            {
                lblenterName.Hide();
            }
            else if(txtbxpassword.Focus()==true )
            {
                lblenterpw.Hide();
            }
            */

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }
        private void txtbxusername_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtbxusername.Text;
                string password = txtbxpassword.Text;

                if (username == "" || username == " ")
                {
                    MessageBox.Show("Enter your User Name Here !");
                    txtbxusername.Focus();
                }
                else if (password == "" || password == " ")
                {
                    MessageBox.Show("Enter your Password Here !");
                    txtbxusername.Focus();
                }
                Program.LogFile("INFO", " User Name and Password validation is Checked");

                SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\methm\OneDrive\Documents\CorpDB.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM memberTable WHERE username='" + username + "' AND password='" + password + "'", myConn);
                Program.LogFile(" DB ", "Matching User Name and Password with DataBase Data");

                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    /* If the user is successfully authenticated then the form will be moved to the Home Page */
                    this.Hide();
                    new home().Show();
                    Program.LogFile("INFO", "User Home Page has been accessed");

                }
                else
                    MessageBox.Show("Invalid username or password");
                    Program.LogFile("ERROR","Invalid username or password");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Program.LogFile("INFO", "Error :Exception has been occured");

            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp newsignup = new SignUp();
            newsignup.Show();
            Program.LogFile("INFO", "User SigUp Page has been accessed ");

        }
    }
}
