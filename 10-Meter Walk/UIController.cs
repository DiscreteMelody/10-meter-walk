using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Meter_Walk
{
    public class UIController
    {
        private PrimaryForm form;

        public UIController(PrimaryForm form_to_manipulate)
        {
            this.form = form_to_manipulate;

            //creation of event handlers
            createButtonEvents();
        }

        private void createButtonEvents()
        {
            //menu buttons
            form.NewTestButton.Click += new EventHandler(onNewTestButtonClicked);
            form.ViewTestButton.Click += new EventHandler(onViewTestButtonClicked);
            form.HelpButton.Click += new EventHandler(onHelpButtonClicked);
            form.ExitButton.Click += new EventHandler(onExitButtonClicked);

            //nested buttons
            form.NewTestPanel.TodayButton.Click += new EventHandler(onTodayButtonClicked);
            form.NewTestPanel.SaveButton.Click += new EventHandler(onSaveButtonClicked);
        }

        //shows and reposition the newTestPanel and highlightPanel, hides other panels not related to the button clicked
        private void onNewTestButtonClicked(object sender, EventArgs e)
        {
            int testPanelX = form.MenuPanel.Width;
            int testPanelY = form.HeaderPanel.Height;
            int highlightPanelX = form.HighlightPanel.Location.X;
            int highlightPanelY = form.NewTestButton.Location.Y;

            form.NewTestPanel.Visible = true;
            form.ViewTestPanel.Visible = false;
            form.HelpPanel.Visible = false;
            form.NewTestPanel.Location = new Point(testPanelX, testPanelY);
            form.HighlightPanel.Location = new Point(highlightPanelX, highlightPanelY);
        }

        //shows and reposition the viewTestPanel and highlightPanel, hides other panels not related to the button clicked
        private void onViewTestButtonClicked(object sender, EventArgs e)
        {
            int testPanelX = form.MenuPanel.Width;
            int testPanelY = form.HeaderPanel.Height;
            int highlightPanelX = form.HighlightPanel.Location.X;
            int highlightPanelY = form.ViewTestButton.Location.Y;

            form.NewTestPanel.Visible = false;
            form.ViewTestPanel.Visible = true;
            form.HelpPanel.Visible = false;
            form.ViewTestPanel.Location = new Point(testPanelX, testPanelY);
            form.HighlightPanel.Location = new Point(highlightPanelX, highlightPanelY);
        }

        //shows and reposition the helpPanel and highlightPanel, hides other panels not related to the button clicked
        private void onHelpButtonClicked(object sender, EventArgs e)
        {
            int helpPanelX = form.MenuPanel.Width;
            int helpPanelY = form.HeaderPanel.Height;
            int highlightPanelX = form.HighlightPanel.Location.X;
            int highlightPanelY = form.HelpButton.Location.Y;

            form.NewTestPanel.Visible = false;
            form.ViewTestPanel.Visible = false;
            form.HelpPanel.Visible = true;
            form.HelpPanel.Location = new Point(helpPanelX, helpPanelY);
            form.HighlightPanel.Location = new Point(highlightPanelX, highlightPanelY);
        }

        private void onExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onTodayButtonClicked(object sender, EventArgs e)
        {
            form.NewTestPanel.TestTimeTextbox.Text = DateTime.Now.ToString("hh:mm tt");
            form.NewTestPanel.TestDateTextbox.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void onSaveButtonClicked(object sender, EventArgs e)
        {
            if (!newTestInputsAreValid())
                return;

            saveData();
            clearNewTestInputs();
        }

        private void saveData()
        {

        }

        //removes text entered from the newTestPanel textboxes and restores their watermarks
        private void clearNewTestInputs()
        {
            NewTestPanel panel = form.NewTestPanel;
            TextPanel[] textpanels = new TextPanel[]
            {
                panel.PatientFirstTextbox, panel.PatientLastTextbox, panel.PatientDOBTextbox,
                panel.AdminFirstTextbox, panel.AdminLastTextbox, panel.TestTimeTextbox, panel.TestDateTextbox
            };

            for (int i = 0; i < textpanels.Length; i++)
            {
                textpanels[i].clearText();
            }
        }

        //checks if inputs are valid and if they are not, shows message to the user which input is invalid and why
        private bool newTestInputsAreValid()
        {
            string inputText = "";
            string nameFormat = @"^[a-zA-Z]|[-]{1,25}$";    //names are A-Z with hyphens and between 1-25 characters
            string nameFormatErrorMessage = "Names can only contain hyphens, letters A-Z, and cannot be longer than 25 characters.";
            string dateFormat = @"^[0-1]{1}[0-9]{1}\/[0-9]{2}\/[0-9]{4}$";  //dates are mm/dd/yyyy format
            string dateFormatErrorMessage = "Dates should be formatted mm/dd/yyyy. January 15th, 2007 would be 01/15/2007";
            string timeFormat = @"^[0-9]{2}:{1}[0-9]{2} {1}[AaPp][mM]$";   //times are in hh:mm am/pm format
            string timeFormatErrorMessage = "Times should be formatted hh:mm am/pm. 1:40 pm would be 01:40 pm";

            TextPanel[] nameTextboxes = new TextPanel[] {   //to be checked using the nameFormat
                form.NewTestPanel.PatientFirstTextbox, form.NewTestPanel.PatientLastTextbox,
                form.NewTestPanel.AdminFirstTextbox, form.NewTestPanel.AdminLastTextbox
            };
            TextPanel[] dateTextboxes = new TextPanel[]     //to be checked using the dateFormat
            {
                form.NewTestPanel.PatientDOBTextbox, form.NewTestPanel.TestDateTextbox
            };
            TextPanel[] timeTextboxes = new TextPanel[]     //to be checked using the timeFormat
            {
                form.NewTestPanel.TestTimeTextbox   //useful if there are multiple boxes to check
            };

            //validate name fields
            for(int i = 0; i < nameTextboxes.Length; i++)
            {
                inputText = nameTextboxes[i].Text;
                if(Regex.IsMatch(inputText, nameFormat) == false)
                {
                    showInvalidEntry(nameTextboxes[i], nameFormatErrorMessage);
                    return false;
                }
            }

            //validate date fields
            for (int i = 0; i < dateTextboxes.Length; i++)
            {
                inputText = dateTextboxes[i].Text;
                if (Regex.IsMatch(inputText, dateFormat) == false)
                {
                    showInvalidEntry(dateTextboxes[i], dateFormatErrorMessage);
                    return false;
                }
            }

            //validate time fields
            for (int i = 0; i < timeTextboxes.Length; i++)
            {
                inputText = timeTextboxes[i].Text;
                if (Regex.IsMatch(inputText, timeFormat) == false)
                {
                    showInvalidEntry(timeTextboxes[i], timeFormatErrorMessage);
                    return false;
                }
            }

            return true;
        }

        private void showInvalidEntry(Control invalid_control, string message_to_show)
        {
            invalid_control.Focus();
            MessageBox.Show(message_to_show);
        }
    }
}
