using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Meter_Walk
{
    public partial class New_Test_Panel : UserControl
    {
        

        public New_Test_Panel()
        {
            InitializeComponent();
        }

        private void New_Test_Panel_Paint(object sender, PaintEventArgs e)
        {
            StyleManager.addCircularBorder(saveButton, e);
        }
    }
}
