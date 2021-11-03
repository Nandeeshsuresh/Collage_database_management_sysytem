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
    public partial class student_usercontrol : UserControl
    {
        private static student_usercontrol _instance;
        public static student_usercontrol instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new student_usercontrol();
                }
                return _instance;
            }
        }
        public student_usercontrol()
        {
            InitializeComponent();
        }



        public void refresh_datagridview()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showallstudentdata_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);

            }
            
        }






        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\repos1\\Nandeesh\\Nandeesh\\Database1.mdf;Integrated Security=True");



        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("studentadd_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@std_id",stdid_textbox.Text);
            cmd.Parameters.AddWithValue("@name", name_textbox.Text);
            cmd.Parameters.AddWithValue("@addr", address_textbox.Text);
            cmd.Parameters.AddWithValue("@phnum", phno_textbox.Text);
            cmd.Parameters.AddWithValue("@sex", sex_textbox.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", dob_textbox.Text);
            cmd.Parameters.AddWithValue("@depart_name", departname_textbox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("       <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();

            refresh_datagridview();
        }

        private void student_usercontrol_Load(object sender, EventArgs e)
        {
            refresh_datagridview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("studentdata_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@std_id", stdid_textbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("       <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

                refresh_datagridview();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchstudent_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@std_id", stdid_textbox.Text);


                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("            <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stdid_textbox.Text = null;
            name_textbox.Text = null;
            address_textbox.Text = null;
            phno_textbox.Text = null;
            sex_textbox.Text = null;
            dob_textbox.Text = null;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
