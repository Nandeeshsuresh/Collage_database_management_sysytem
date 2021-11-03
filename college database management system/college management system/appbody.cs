using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Nandeesh
{
    public partial class appbody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                    int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();





        public appbody()
        {
            InitializeComponent();
            //initialization for sliding panel
            isslidingpanelexpanded = true;
            expandslidingpanelGUI();

        }

        private void appbody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            login_timer.Start();
        }

        private void login_timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;

            }
            else
            {
                login_timer.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            
        }
       


        //sliding panel starts from here
        bool isslidingpanelexpanded;
        const int maxsliderwidth=130;
        const int minsliderwidth=60;


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isslidingpanelexpanded)
            {
                //retract panel
               //retractslidingpanelGUI();

            }
            slidingpanel_timer.Start();
        }

        private void slidingpanel_timer_Tick(object sender, EventArgs e)
        {
            if (isslidingpanelexpanded)
            {
                //retract panel
                sliding_panel.Width -= 30;
                if (sliding_panel.Width <= minsliderwidth)
                {
                    //stopretract
                    isslidingpanelexpanded = false;
                    slidingpanel_timer.Stop();
                    retractslidingpanelGUI();
                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                sliding_panel.Width += 30;
                if (sliding_panel.Width >= maxsliderwidth)
                {
                    //stop expand
                    isslidingpanelexpanded = true;
                    slidingpanel_timer.Stop();
                    expandslidingpanelGUI();
                    this.Refresh();
                }
            }
        }

        private void sliding_panel_Paint(object sender, PaintEventArgs e)
        {

        
        }

        public void expandslidingpanelGUI()
        {
            //gui adjustments for expanding
            student_button.Text = "STUDENT";
            grade_button.Text = "GRADE";
            account_button.Text = "ACCOUNT";
            settings_button.Text = "SETTINGS";
            about_button.Text = "ABOUT";

            sliding_button.Image = Properties.Resources.larrow;

            student_button.Image = Properties.Resources.student;
            grade_button.Image = Properties.Resources.marks2;
            account_button.Image = Properties.Resources.acc1;
            settings_button.Image = Properties.Resources.set;
            about_button.Image = Properties.Resources.about__1_;
        }
        public void retractslidingpanelGUI()
        {
            //gui adjustments for expanding
            student_button.Text = "";
            grade_button.Text = "";
            account_button.Text = "";
            settings_button.Text = "";
            about_button.Text = "";

            sliding_button.Image = Properties.Resources.double_chevron2;

            student_button.Image = Properties.Resources.student;
            grade_button.Image = Properties.Resources.marks2;
            account_button.Image = Properties.Resources.acc1;
            settings_button.Image = Properties.Resources.set;
            about_button.Image = Properties.Resources.about__1_;
        }

        private void student_button_Click(object sender, EventArgs e)
        {
            if(!contentpanel.Controls.Contains(student_usercontrol.instance))
            {
                contentpanel.Controls.Add(student_usercontrol.instance);
                student_usercontrol.instance.Dock = DockStyle.Fill;
                student_usercontrol.instance.BringToFront();
            }
            else
            {
                student_usercontrol.instance.BringToFront();
            }
        }

        private void grade_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(cgpa_usercontrol.instance))
            {
               
                contentpanel.Controls.Add(cgpa_usercontrol.instance);
                cgpa_usercontrol.instance.Dock = DockStyle.Fill;
                cgpa_usercontrol.instance.BringToFront();
               
            }
            else
            {
                cgpa_usercontrol.instance.BringToFront();
            }
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(account_usercontrol.instance))
            {
                contentpanel.Controls.Add(account_usercontrol.instance);
                account_usercontrol.instance.Dock = DockStyle.Fill;
                account_usercontrol.instance.BringToFront();
            }
            else
            {
                account_usercontrol.instance.BringToFront();
            }
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(settings_usercontrol.instance))
            {
                contentpanel.Controls.Add(settings_usercontrol.instance);
                settings_usercontrol.instance.Dock = DockStyle.Fill;
                settings_usercontrol.instance.BringToFront();
            }
            else
            {
                settings_usercontrol.instance.BringToFront();
            }
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(about_usercontrol.instance))
            {
                contentpanel.Controls.Add(about_usercontrol.instance);
                about_usercontrol.instance.Dock = DockStyle.Fill;
                about_usercontrol.instance.BringToFront();
            }
            else
            {
                about_usercontrol.instance.BringToFront();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            this.WindowState= FormWindowState.Maximized;

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }

}
