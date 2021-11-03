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
    public partial class settings_usercontrol : UserControl
    {
        private static settings_usercontrol _instance;
        public static settings_usercontrol instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new settings_usercontrol();
                }
                return _instance;
            }
        }


        public settings_usercontrol()
        {
            InitializeComponent();
        }
    }
}
