using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nandeesh
{
    public partial class student_usercontrol : UserControl
    {
        private static student_usercontrol _instance;

        public static student_usercontrol instance;

        public student_usercontrol()
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new student_usercontrol();

                }
                return _instance;
            }
        
            InitializeComponent();
        }

        private void student_usercontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
