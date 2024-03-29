﻿using System;
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
        private List<TestModel> tests = new List<TestModel>();
        private List<Button> menuButtons = new List<Button>();
        private int selectedTestIndex;

        public UIController(PrimaryForm form_to_manipulate)
        {
            this.form = form_to_manipulate;
            menuButtons = new List<Button>() { form.NewTestButton, form.ViewTestButton, form.HelpButton, form.ExitButton };

            //creation of event handlers
            createButtonEvents();

            //home screen of program
            form.Load += new EventHandler(onFormLoad);
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            form.NewTestButton.PerformClick();
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
            form.ViewTestPanel.SearchButton.Click += new EventHandler(onSearchButtonClicked);
            form.ViewTestPanel.ViewFullTestButton.Click += new EventHandler(onViewFullTestButtonClicked);
            form.ViewTestPanel.DeleteTestButton.Click += new EventHandler(onDeleteTestButtonClicked);
        }

        //shows and reposition the newTestPanel and highlightPanel, hides other panels not related to the button clicked
        private void onNewTestButtonClicked(object sender, EventArgs e)
        {
            int visiblePanelX = form.MenuPanel.Width;
            int visiblePanelY = form.HeaderPanel.Height;

            form.NewTestPanel.Visible = true;
            form.ViewTestPanel.Visible = false;
            form.HelpPanel.Visible = false;
            form.NewTestPanel.Location = new Point(visiblePanelX, visiblePanelY);

            StyleManager.setButtonAsSelected(form.NewTestButton, form.HighlightPanel);
            StyleManager.setButtonAsNormal(form.ViewTestButton);
            StyleManager.setButtonAsNormal(form.HelpButton);
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
            
            StyleManager.setButtonAsNormal(form.NewTestButton);
            StyleManager.setButtonAsSelected(form.ViewTestButton, form.HighlightPanel);
            StyleManager.setButtonAsNormal(form.HelpButton);
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
            StyleManager.setButtonAsSelected(form.HelpButton, form.HighlightPanel);
            StyleManager.setButtonAsNormal(form.NewTestButton);
            StyleManager.setButtonAsNormal(form.ViewTestButton);
        }

        private void onExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //sets the date textbox text to the current date
        private void onTodayButtonClicked(object sender, EventArgs e)
        {
            form.NewTestPanel.TestDateTextbox.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        //saves the newTest inputs to the database if the inputs are valid
        private void onSaveButtonClicked(object sender, EventArgs e)
        {
            if (!newTestInputsAreValid())
                return;

            saveData();
            clearNewTestInputs();
        }

        private void onSearchButtonClicked(object sender, EventArgs e)
        {
            if (searchTestInputsAreValid() == false)
                return;

            string patientFirst = form.ViewTestPanel.PatientFirstTextbox.Text.ToLower();
            string patientLast = form.ViewTestPanel.PatientLastTextbox.Text.ToLower();
            string dateOfBirth = form.ViewTestPanel.DateOfBirthTextbox.Text.ToLower();

            //populating the tests list with query results
            tests = SqliteDataAccess.LoadTests(patientFirst, patientLast, dateOfBirth);
            
            clearTestListView();
            displaySearchResults();

            //allow the user to edit a mistake if no results are found
            if (tests.Count == 0)
            {
                MessageBox.Show("No tests were found using the search criteria");
            }
            else
            {
                clearSearchTextboxes();
            }
        }

        private void onViewFullTestButtonClicked(object sender, EventArgs e)
        {
            if (testIsSelected() == false)
                return;

            TestModel selectedTest = tests[selectedTestIndex];

            //I would replace this with a more beautiful looking window if I have time
            string message = "Patient name:\t" + selectedTest.PatientFirst + " " + selectedTest.PatientLast +
                "\nPatient DoB:\t" + selectedTest.PatientDOB +
                "\nTest Date:\t" + selectedTest.TestDate +
                "\nTest Time:\t" + selectedTest.TestTime +
                "\nTest Admin:\t" + selectedTest.AdminName +
                "\nNotes:\n" + selectedTest.Notes;
            MessageBox.Show(message);

        }

        private void onDeleteTestButtonClicked(object sender, EventArgs e)
        {
            if (testIsSelected() == false)
                return;

            if (ConfirmationBox.ShowConfirmationScreen("Really delete the selected record? This action cannot be undone.") == false)
                return;

            SqliteDataAccess.deleteRecord(tests[selectedTestIndex]);
            form.ViewTestPanel.TestsListView.Items[selectedTestIndex].Remove();
        }

        //returns if a test is selected from the list view
        private bool testIsSelected()
        {
            if (form.ViewTestPanel.TestsListView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("No tests are selected");
                return false;
            }

            //here to prevent redundancy
            setSelectedTestIndex();
            return true;
        }

        //sets the selectedTestIndex of the user-selected test in the viewPanel
        private void setSelectedTestIndex()
        {
            selectedTestIndex = form.ViewTestPanel.TestsListView.SelectedIndices[0];
        }

        //populates the testsListView with query results from the database
        private void displaySearchResults()
        {
            foreach (TestModel test in tests)
            {
                ListViewItem item = new ListViewItem(test.PatientFirst + " " + test.PatientLast);
                item.SubItems.Add(test.TestDate);
                item.SubItems.Add(test.TestTime);
                item.SubItems.Add(test.Notes);
                form.ViewTestPanel.TestsListView.Items.Add(item);
            }
        }

        //clears the textboxes on the viewTestPanel
        private void clearSearchTextboxes()
        {
            form.ViewTestPanel.PatientFirstTextbox.clearText();
            form.ViewTestPanel.PatientLastTextbox.clearText();
            form.ViewTestPanel.DateOfBirthTextbox.clearText();
        }

        //clears the listview displaying results on the viewTestPanel
        private void clearTestListView()
        {
            form.ViewTestPanel.TestsListView.Items.Clear();
        }

        //writes inputs from newTestPanel into the database
        private void saveData()
        {
            string patientFirst = form.NewTestPanel.PatientFirstTextbox.Text;
            string patientLast = form.NewTestPanel.PatientLastTextbox.Text;
            string patientDOB = form.NewTestPanel.PatientDOBTextbox.Text;
            string testTime = form.NewTestPanel.TestTimeTextbox.Text;
            string testDate = form.NewTestPanel.TestDateTextbox.Text;
            string adminName = form.NewTestPanel.AdminFirstTextbox.Text + " " +
                form.NewTestPanel.AdminLastTextbox.Text;
            string notes = form.NewTestPanel.NotesTextbox.Text;

            TestModel newTest = new TestModel();
            newTest.PatientFirst = patientFirst.ToLower();
            newTest.PatientLast = patientLast.ToLower();
            newTest.PatientDOB = patientDOB.ToLower(); ;
            newTest.TestTime = testTime.ToLower();
            newTest.TestDate = testDate.ToLower();
            newTest.AdminName = adminName.ToLower();
            newTest.Notes = notes.ToLower();

            SqliteDataAccess.SaveTest(newTest);
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

            panel.NotesTextbox.Clear();
        }

        //checks if inputs are valid and if they are not, shows message to the user which input is invalid and why
        private bool newTestInputsAreValid()
        {
            string inputText = "";

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
            TextBox notesTextbox = form.NewTestPanel.NotesTextbox;

            //validate name fields
            for (int i = 0; i < nameTextboxes.Length; i++)
            {
                inputText = nameTextboxes[i].Text;
                if(ValidationManager.inputIsValid(inputText, ValidationManager.ValidationTypes.Name) == false)
                {
                    nameTextboxes[i].Focus();
                    return false;
                }
            }

            //validate date fields
            for (int i = 0; i < dateTextboxes.Length; i++)
            {
                inputText = dateTextboxes[i].Text;
                if (ValidationManager.inputIsValid(inputText, ValidationManager.ValidationTypes.Date) == false)
                {
                    dateTextboxes[i].Focus();
                    return false;
                }
            }

            //validate time fields
            for (int i = 0; i < timeTextboxes.Length; i++)
            {
                inputText = timeTextboxes[i].Text;
                if (ValidationManager.inputIsValid(inputText, ValidationManager.ValidationTypes.Time) == false)
                {
                    timeTextboxes[i].Focus();
                    return false;
                }
            }

            //validate the notes entered
            inputText = notesTextbox.Text;
            if (ValidationManager.inputIsValid(inputText, ValidationManager.ValidationTypes.Notes) == false)
            {
                notesTextbox.Focus();
                return false;
            }

            return true;
        }

        //validates if the search inputs are valid on the ViewTestPanel
        private bool searchTestInputsAreValid()
        {
            string inputText = "";

            inputText = form.ViewTestPanel.PatientFirstTextbox.Text;
            if(ValidationManager.inputIsValid(inputText, ValidationManager.ValidationTypes.Name) == false)
            {
                form.ViewTestPanel.PatientFirstTextbox.Focus();
                return false;
            }

            inputText = form.ViewTestPanel.PatientLastTextbox.Text;
            if (ValidationManager.inputIsValid(inputText, ValidationManager.ValidationTypes.Name) == false)
            {
                form.ViewTestPanel.PatientLastTextbox.Focus();
                return false;
            }

            inputText = form.ViewTestPanel.DateOfBirthTextbox.Text;
            if (ValidationManager.inputIsValid(inputText, ValidationManager.ValidationTypes.Date) == false)
            {
                form.ViewTestPanel.DateOfBirthTextbox.Focus();
                return false;
            }

            return true;
        }
    }
}
