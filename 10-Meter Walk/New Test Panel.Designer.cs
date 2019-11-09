namespace _10_Meter_Walk
{
    partial class New_Test_Panel
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
            this.todayButton = new System.Windows.Forms.Button();
            this.testInformationPanel = new System.Windows.Forms.Panel();
            this.patientInformationPanel = new System.Windows.Forms.Panel();
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.testInformationLabel = new System.Windows.Forms.Label();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.dateOfBirthTextbox = new _10_Meter_Walk.TextPanel();
            this.patientLastTextbox = new _10_Meter_Walk.TextPanel();
            this.patientFirstTextbox = new _10_Meter_Walk.TextPanel();
            this.adminLastTextbox = new _10_Meter_Walk.TextPanel();
            this.adminFirstTextbox = new _10_Meter_Walk.TextPanel();
            this.timeTextbox = new _10_Meter_Walk.TextPanel();
            this.dateTextbox = new _10_Meter_Walk.TextPanel();
            this.saveButton = new _10_Meter_Walk.CircularButton();
            this.testInformationPanel.SuspendLayout();
            this.patientInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // todayButton
            // 
            this.todayButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.todayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todayButton.FlatAppearance.BorderSize = 0;
            this.todayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.todayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.todayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todayButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayButton.ForeColor = System.Drawing.Color.White;
            this.todayButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.todayButton.Location = new System.Drawing.Point(214, 75);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(131, 84);
            this.todayButton.TabIndex = 7;
            this.todayButton.Text = "Performed\r\nToday";
            this.todayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.todayButton.UseVisualStyleBackColor = false;
            // 
            // testInformationPanel
            // 
            this.testInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.testInformationPanel.Controls.Add(this.notesLabel);
            this.testInformationPanel.Controls.Add(this.notesTextbox);
            this.testInformationPanel.Controls.Add(this.adminLastTextbox);
            this.testInformationPanel.Controls.Add(this.adminFirstTextbox);
            this.testInformationPanel.Controls.Add(this.timeTextbox);
            this.testInformationPanel.Controls.Add(this.dateTextbox);
            this.testInformationPanel.Controls.Add(this.testInformationLabel);
            this.testInformationPanel.Controls.Add(this.todayButton);
            this.testInformationPanel.Location = new System.Drawing.Point(3, 3);
            this.testInformationPanel.Name = "testInformationPanel";
            this.testInformationPanel.Size = new System.Drawing.Size(355, 480);
            this.testInformationPanel.TabIndex = 3;
            // 
            // patientInformationPanel
            // 
            this.patientInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.patientInformationPanel.Controls.Add(this.dateOfBirthTextbox);
            this.patientInformationPanel.Controls.Add(this.patientLastTextbox);
            this.patientInformationPanel.Controls.Add(this.patientFirstTextbox);
            this.patientInformationPanel.Controls.Add(this.patientInformationLabel);
            this.patientInformationPanel.Location = new System.Drawing.Point(364, 3);
            this.patientInformationPanel.Name = "patientInformationPanel";
            this.patientInformationPanel.Size = new System.Drawing.Size(267, 320);
            this.patientInformationPanel.TabIndex = 4;
            // 
            // patientInformationLabel
            // 
            this.patientInformationLabel.AutoSize = true;
            this.patientInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientInformationLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationLabel.Location = new System.Drawing.Point(4, 10);
            this.patientInformationLabel.Name = "patientInformationLabel";
            this.patientInformationLabel.Size = new System.Drawing.Size(259, 32);
            this.patientInformationLabel.TabIndex = 0;
            this.patientInformationLabel.Text = "Patient Information";
            // 
            // testInformationLabel
            // 
            this.testInformationLabel.AutoSize = true;
            this.testInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.testInformationLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testInformationLabel.Location = new System.Drawing.Point(68, 10);
            this.testInformationLabel.Name = "testInformationLabel";
            this.testInformationLabel.Size = new System.Drawing.Size(219, 32);
            this.testInformationLabel.TabIndex = 8;
            this.testInformationLabel.Text = "Test Information";
            // 
            // notesTextbox
            // 
            this.notesTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTextbox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextbox.Location = new System.Drawing.Point(9, 343);
            this.notesTextbox.Multiline = true;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextbox.Size = new System.Drawing.Size(336, 118);
            this.notesTextbox.TabIndex = 13;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.BackColor = System.Drawing.Color.Transparent;
            this.notesLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(146, 317);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(62, 23);
            this.notesLabel.TabIndex = 14;
            this.notesLabel.Text = "Notes";
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.BackColor = System.Drawing.Color.Transparent;
            this.saveLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.Location = new System.Drawing.Point(474, 450);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(62, 25);
            this.saveLabel.TabIndex = 9;
            this.saveLabel.Text = "Save";
            // 
            // dateOfBirthTextbox
            // 
            this.dateOfBirthTextbox.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.dateOfBirthTextbox.Location = new System.Drawing.Point(48, 165);
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
            this.patientLastTextbox.Location = new System.Drawing.Point(48, 120);
            this.patientLastTextbox.Name = "patientLastTextbox";
            this.patientLastTextbox.Size = new System.Drawing.Size(186, 39);
            this.patientLastTextbox.TabIndex = 2;
            this.patientLastTextbox.TogglesBorder = true;
            this.patientLastTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.patientLastTextbox.WatermarkText = "Last Name";
            // 
            // patientFirstTextbox
            // 
            this.patientFirstTextbox.BackColor = System.Drawing.Color.Transparent;
            this.patientFirstTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.patientFirstTextbox.Location = new System.Drawing.Point(48, 75);
            this.patientFirstTextbox.Name = "patientFirstTextbox";
            this.patientFirstTextbox.Size = new System.Drawing.Size(186, 39);
            this.patientFirstTextbox.TabIndex = 1;
            this.patientFirstTextbox.TogglesBorder = true;
            this.patientFirstTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.patientFirstTextbox.WatermarkText = "First Name";
            // 
            // adminLastTextbox
            // 
            this.adminLastTextbox.BackColor = System.Drawing.Color.Transparent;
            this.adminLastTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.adminLastTextbox.Location = new System.Drawing.Point(84, 248);
            this.adminLastTextbox.Name = "adminLastTextbox";
            this.adminLastTextbox.Size = new System.Drawing.Size(186, 39);
            this.adminLastTextbox.TabIndex = 12;
            this.adminLastTextbox.TogglesBorder = true;
            this.adminLastTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.adminLastTextbox.WatermarkText = "Test Admin Last";
            // 
            // adminFirstTextbox
            // 
            this.adminFirstTextbox.BackColor = System.Drawing.Color.Transparent;
            this.adminFirstTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.adminFirstTextbox.Location = new System.Drawing.Point(84, 203);
            this.adminFirstTextbox.Name = "adminFirstTextbox";
            this.adminFirstTextbox.Size = new System.Drawing.Size(186, 39);
            this.adminFirstTextbox.TabIndex = 11;
            this.adminFirstTextbox.TogglesBorder = true;
            this.adminFirstTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.adminFirstTextbox.WatermarkText = "Test Admin First";
            // 
            // timeTextbox
            // 
            this.timeTextbox.BackColor = System.Drawing.Color.Transparent;
            this.timeTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.timeTextbox.Location = new System.Drawing.Point(9, 120);
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.Size = new System.Drawing.Size(186, 39);
            this.timeTextbox.TabIndex = 10;
            this.timeTextbox.TogglesBorder = true;
            this.timeTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.timeTextbox.WatermarkText = "Time (hh:mm am/pm)";
            // 
            // dateTextbox
            // 
            this.dateTextbox.BackColor = System.Drawing.Color.Transparent;
            this.dateTextbox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.dateTextbox.Location = new System.Drawing.Point(9, 75);
            this.dateTextbox.Name = "dateTextbox";
            this.dateTextbox.Size = new System.Drawing.Size(186, 39);
            this.dateTextbox.TabIndex = 9;
            this.dateTextbox.TogglesBorder = true;
            this.dateTextbox.WatermarkColor = System.Drawing.Color.Gray;
            this.dateTextbox.WatermarkText = "Date (mm/dd/yyyy)";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.saveButton.BorderRadius = 20F;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::_10_Meter_Walk.Properties.Resources.save;
            this.saveButton.Location = new System.Drawing.Point(463, 360);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 82);
            this.saveButton.TabIndex = 2;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // New_Test_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.patientInformationPanel);
            this.Controls.Add(this.testInformationPanel);
            this.Controls.Add(this.saveButton);
            this.Name = "New_Test_Panel";
            this.Size = new System.Drawing.Size(634, 486);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.New_Test_Panel_Paint);
            this.testInformationPanel.ResumeLayout(false);
            this.testInformationPanel.PerformLayout();
            this.patientInformationPanel.ResumeLayout(false);
            this.patientInformationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button todayButton;
        private CircularButton saveButton;
        private System.Windows.Forms.Panel testInformationPanel;
        private System.Windows.Forms.Panel patientInformationPanel;
        private System.Windows.Forms.Label patientInformationLabel;
        private TextPanel patientFirstTextbox;
        private TextPanel patientLastTextbox;
        private TextPanel dateOfBirthTextbox;
        private System.Windows.Forms.Label testInformationLabel;
        private TextPanel timeTextbox;
        private TextPanel dateTextbox;
        private System.Windows.Forms.TextBox notesTextbox;
        private TextPanel adminLastTextbox;
        private TextPanel adminFirstTextbox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label saveLabel;
    }
}
