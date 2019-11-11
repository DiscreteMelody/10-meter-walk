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
    public partial class ViewTestPanel : UserControl
    {
        //to make controls visible to the controller and parent form
        public TextPanel PatientFirstTextbox
        {
            get { return this.patientFirstTextbox; }
        }
        public TextPanel PatientLastTextbox
        {
            get { return this.patientLastTextbox; }
        }
        public TextPanel DateOfBirthTextbox
        {
            get { return this.dateOfBirthTextbox; }
        }
        public Button SearchButton
        {
            get { return this.searchButton; }
        }
        public ListView TestsListView
        {
            get { return this.testsListView; }
        }

        public ViewTestPanel()
        {
            InitializeComponent();
        }
    }
}
