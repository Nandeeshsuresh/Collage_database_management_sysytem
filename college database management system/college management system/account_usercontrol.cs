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
    public partial class account_usercontrol : UserControl
    {
        private static account_usercontrol _instance;
        public static account_usercontrol instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new account_usercontrol();
                }
                return _instance;
            }
        }
        
        public account_usercontrol()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\repos1\\Nandeesh\\Nandeesh\\Database1.mdf;Integrated Security=True");
        public void refresh_datagridview()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showaccstddata_sp", con);
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
            SqlCommand cmd = new SqlCommand("addastdid_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@astd_id", astdid_textbox.Text);
            cmd.Parameters.AddWithValue("@balance", bal_textbox.Text);
            cmd.Parameters.AddWithValue("@scholarship",scholarship_textbox.Text);
            cmd.Parameters.AddWithValue("@fines",fines_textBox.Text);

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

        private void account_usercontrol_Load(object sender, EventArgs e)
        {
            refresh_datagridview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("accountdelete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@astd_id",astdid_textbox.Text);

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
            astdid_textbox.Text = null;
            bal_textbox.Text = null;
            scholarship_textbox.Text = null;
            fines_textBox.Text = null;
        }
    }
    }

