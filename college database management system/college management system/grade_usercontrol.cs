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
    public partial class cgpa_usercontrol : UserControl
    {
        private static cgpa_usercontrol _instance;
        public static cgpa_usercontrol instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new cgpa_usercontrol();
                }
                return _instance;
            }
        }
        public cgpa_usercontrol()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\repos1\\Nandeesh\\Nandeesh\\Database1.mdf;Integrated Security=True");
        public void refresh_datagridview()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showstudentcgpa_sp", con);
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
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("addstdcgpa", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cstd_id", cstdid_textbox.Text);
            cmd.Parameters.AddWithValue("@sem", sem_textbox.Text);
            cmd.Parameters.AddWithValue("@cgpa", cgpa_textbox.Text);

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

        private void cgpa_usercontrol_Load(object sender, EventArgs e)
        {
            refresh_datagridview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("cstdiddelete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cstd_id", cstdid_textbox.Text);

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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cstdid_textbox.Text = null;
            sem_textbox.Text = null;
            cgpa_textbox.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchcgpa_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cstd_id",cstdid_textbox.Text);


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
    }

}
