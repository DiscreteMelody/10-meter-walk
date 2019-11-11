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
    public partial class NewTestPanel : UserControl
    {
        //making the controls accessible to parent form and UIController
        public Button TodayButton
        {
            get { return todayButton; }
        }
        public Button SaveButton
        {
            get { return saveButton; }
        }
        public TextPanel PatientFirstTextbox
        {
            get { return this.patientFirstTextbox; }
        }
        public TextPanel PatientLastTextbox
        {
            get { return this.patientLastTextbox; }
        }
        public TextPanel PatientDOBTextbox
        {
            get { return this.patientDOBTextbox; }
        }
        public TextPanel AdminFirstTextbox
        {
            get { return this.adminFirstTextbox; }
        }
        public TextPanel AdminLastTextbox
        {
            get { return this.adminLastTextbox; }
        }
        public TextBox NotesTextbox
        {
            get { return this.notesTextbox; }
        }
        public TextPanel TestDateTextbox
        {
            get { return this.testDateTextbox; }
        }
        public TextPanel TestTimeTextbox
        {
            get { return this.testTimeTextbox; }
        }

        public NewTestPanel()
        {
            InitializeComponent();
        }

        //paint a circular border around the save button
        private void New_Test_Panel_Paint(object sender, PaintEventArgs e)
        {
            StyleManager.addCircularBorder(saveButton, e);
        }
    }
}
