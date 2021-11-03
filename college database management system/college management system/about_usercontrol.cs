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
    public partial class about_usercontrol : UserControl
    {
        private static about_usercontrol _instance;
        public static about_usercontrol instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new about_usercontrol();
                }
                return _instance;
            }
        }

        public about_usercontrol()
        {
            InitializeComponent();
        }
    }
}
