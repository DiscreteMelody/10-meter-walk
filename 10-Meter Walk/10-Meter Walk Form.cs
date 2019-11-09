using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Meter_Walk
{
    public partial class PrimaryForm : Form
    {
        //making the form controls accessible to the UIController
        public Button NewTestButton
        {
            get { return this.newTestButton; }
        }
        public Button ViewTestButton
        {
            get { return this.viewTestButton; }
        }
        public Button HelpButton
        {
            get { return this.helpButton; }
        }
        public Button ExitButton
        {
            get { return this.exitButton; }
        }
        public NewTestPanel NewTestPanel
        {
            get { return this.newTestPanel; }
        }
        public ViewTestPanel ViewTestPanel
        {
            get { return this.viewTestPanel; }
        }
        public Panel HeaderPanel
        {
            get { return this.headerPanel; }
        }
        public Panel MenuPanel
        {
            get { return this.menuPanel; }
        }
        public HelpPanel HelpPanel
        {
            get { return this.helpPanel; }
        }
        public Panel HighlightPanel
        {
            get { return this.highlightPanel; }
        }



        public PrimaryForm()
        {
            InitializeComponent();
        }
    }
}
