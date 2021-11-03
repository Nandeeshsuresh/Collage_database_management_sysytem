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


namespace Nandeesh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\repos1\\Nandeesh\\Nandeesh\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;



        private string getusername()
        {
            //fetch data from data base
            con.Open();
            string syntax = "select value from SYSTEMTABLE where property='username'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;



        }


        private string getpassword()
        {
            //fetch data from data base
            con.Open();
            string syntax = "select value from SYSTEMTABLE where property='password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            string auname = getusername(), apass = getpassword(), euname, epass;
            euname = textBox1.Text;
            epass = textBox2.Text;

            if(auname==euname&&epass==apass)
            {
                //login
      
                appbody obj = new appbody();
                this.Hide();
                obj.Show();


            }
            else
            {
                //dontlogin
                MessageBox.Show("user name and password doesnt match");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
