namespace _10_Meter_Walk
{
    partial class ViewTestPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientInformationPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.dateOfBirthTextbox = new _10_Meter_Walk.TextPanel();
            this.patientLastTextbox = new _10_Meter_Walk.TextPanel();
            this.patientFirstTextbox = new _10_Meter_Walk.TextPanel();
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.recordsPanel = new System.Windows.Forms.Panel();
            this.testsListView = new System.Windows.Forms.ListView();
            this.patientNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteLabel = new System.Windows.Forms.Label();
            this.viewLabel = new System.Windows.Forms.Label();
            this.viewFullTestButton = new _10_Meter_Walk.CircularButton();
            this.deleteTestButton = new _10_Meter_Walk.CircularButton();
            this.patientInformationPanel.SuspendLayout();
            this.recordsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientInformationPanel
            // 
            this.patientInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.patientInformationPanel.Controls.Add(this.searchButton);
            this.patientInformationPanel.Controls.Add(this.dateOfBirthTextbox);
            this.patientInformationPanel.Controls.Add(this.patientLastTextbox);
            this.patientInformationPanel.Controls.Add(this.patientFirstTextbox);
            this.patientInformationPanel.Controls.Add(this.patientInformationLabel);
            this.patientInformationPanel.Location = new System.Drawing.Point(3, 3);
            this.patientInformationPanel.Name = "patientInformationPanel";
            this.patientInformationPanel.Size = new System.Drawing.Size(316, 279);
            this.patientInformationPanel.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.Location = new System.Drawing.Point(93, 213);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 54);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // dateOfBirthTextbox
            // 
            this.dateOfBirthTextbox.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.dateOfBirthTextbox.Location = new System.Drawing.Point(65, 149);
            this.dateOfBirthTextbox.Name = "dateOfBirthTextbox";
            this.dateOfBirthTextbox.Size = new System.Drawing.Size(186, 39);
            this.dateOfBirthTextbox.TabIndex = 3;
            this.dateOfBirthTextbox.TogglesBorder = true;
            this.dateOfBirthTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.dateOfBirthTextbox.WatermarkText = "DoB (mm/dd/yyyy)";
            // 
            // patientLastTextbox
            // 
            this.patientLastTextbox.BackColor = System.Drawing.Color.Transparent;
            this.patientLastTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.patientLastTextbox.Location = new System.Drawing.Point(65, 104);
            this.patientLastTextbox.Name = "patientLastTextbox";
            this.patientLastTextbox.Size = new System.Drawing.Size(186, 39);
            this.patientLastTextbox.TabIndex = 2;
            this.patientLastTextbox.TogglesBorder = true;
            this.patientLastTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.patientLastTextbox.WatermarkText = "Patient Last Name";
            // 
            // patientFirstTextbox
            // 
            this.patientFirstTextbox.BackColor = System.Drawing.Color.Transparent;
            this.patientFirstTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.patientFirstTextbox.Location = new System.Drawing.Point(65, 59);
            this.patientFirstTextbox.Name = "patientFirstTextbox";
            this.patientFirstTextbox.Size = new System.Drawing.Size(186, 39);
            this.patientFirstTextbox.TabIndex = 1;
            this.patientFirstTextbox.TogglesBorder = true;
            this.patientFirstTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.patientFirstTextbox.WatermarkText = "Patient First Name";
            // 
            // patientInformationLabel
            // 
            this.patientInformationLabel.AutoSize = true;
            this.patientInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientInformationLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationLabel.Location = new System.Drawing.Point(14, 15);
            this.patientInformationLabel.Name = "patientInformationLabel";
            this.patientInformationLabel.Size = new System.Drawing.Size(289, 32);
            this.patientInformationLabel.TabIndex = 0;
            this.patientInformationLabel.Text = "Search Previous Tests";
            // 
            // recordsPanel
            // 
            this.recordsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.recordsPanel.Controls.Add(this.testsListView);
            this.recordsPanel.Location = new System.Drawing.Point(3, 288);
            this.recordsPanel.Name = "recordsPanel";
            this.recordsPanel.Size = new System.Drawing.Size(628, 195);
            this.recordsPanel.TabIndex = 6;
            // 
            // testsListView
            // 
            this.testsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientNameHeader,
            this.testDateHeader,
            this.timeHeader,
            this.notesHeader});
            this.testsListView.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testsListView.FullRowSelect = true;
            this.testsListView.GridLines = true;
            this.testsListView.Location = new System.Drawing.Point(4, 4);
            this.testsListView.MultiSelect = false;
            this.testsListView.Name = "testsListView";
            this.testsListView.Size = new System.Drawing.Size(621, 188);
            this.testsListView.TabIndex = 0;
            this.testsListView.UseCompatibleStateImageBehavior = false;
            this.testsListView.View = System.Windows.Forms.View.Details;
            // 
            // patientNameHeader
            // 
            this.patientNameHeader.Text = "Patient Name";
            this.patientNameHeader.Width = 116;
            // 
            // testDateHeader
            // 
            this.testDateHeader.Text = "Date of Test";
            this.testDateHeader.Width = 92;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time";
            this.timeHeader.Width = 86;
            // 
            // notesHeader
            // 
            this.notesHeader.Text = "Notes";
            this.notesHeader.Width = 305;
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.Color.Transparent;
            this.deleteLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.Location = new System.Drawing.Point(515, 180);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(77, 25);
            this.deleteLabel.TabIndex = 11;
            this.deleteLabel.Text = "Delete";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.BackColor = System.Drawing.Color.Transparent;
            this.viewLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.Location = new System.Drawing.Point(375, 180);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(62, 25);
            this.viewLabel.TabIndex = 13;
            this.viewLabel.Text = "View";
            // 
            // viewFullTestButton
            // 
            this.viewFullTestButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.viewFullTestButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.viewFullTestButton.BorderRadius = 20F;
            this.viewFullTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewFullTestButton.FlatAppearance.BorderSize = 0;
            this.viewFullTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.viewFullTestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.viewFullTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewFullTestButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFullTestButton.Image = global::_10_Meter_Walk.Properties.Resources.glasses;
            this.viewFullTestButton.Location = new System.Drawing.Point(364, 90);
            this.viewFullTestButton.Name = "viewFullTestButton";
            this.viewFullTestButton.Size = new System.Drawing.Size(82, 82);
            this.viewFullTestButton.TabIndex = 12;
            this.viewFullTestButton.UseVisualStyleBackColor = false;
            // 
            // deleteTestButton
            // 
            this.deleteTestButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteTestButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.deleteTestButton.BorderRadius = 20F;
            this.deleteTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTestButton.FlatAppearance.BorderSize = 0;
            this.deleteTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.deleteTestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.deleteTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTestButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTestButton.Image = global::_10_Meter_Walk.Properties.Resources.trash;
            this.deleteTestButton.Location = new System.Drawing.Point(513, 90);
            this.deleteTestButton.Name = "deleteTestButton";
            this.deleteTestButton.Size = new System.Drawing.Size(82, 82);
            this.deleteTestButton.TabIndex = 10;
            this.deleteTestButton.UseVisualStyleBackColor = false;
            // 
            // ViewTestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.viewFullTestButton);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.deleteTestButton);
            this.Controls.Add(this.recordsPanel);
            this.Controls.Add(this.patientInformationPanel);
            this.Name = "ViewTestPanel";
            this.Size = new System.Drawing.Size(634, 486);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewTestPanel_Paint);
            this.patientInformationPanel.ResumeLayout(false);
            this.patientInformationPanel.PerformLayout();
            this.recordsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel patientInformationPanel;
        private TextPanel dateOfBirthTextbox;
        private TextPanel patientLastTextbox;
        private TextPanel patientFirstTextbox;
        private System.Windows.Forms.Label patientInformationLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel recordsPanel;
        private System.Windows.Forms.ListView testsListView;
        private System.Windows.Forms.ColumnHeader patientNameHeader;
        private System.Windows.Forms.ColumnHeader testDateHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.Label deleteLabel;
        private CircularButton deleteTestButton;
        private System.Windows.Forms.Label viewLabel;
        private CircularButton viewFullTestButton;
        private System.Windows.Forms.ColumnHeader notesHeader;
    }
}
