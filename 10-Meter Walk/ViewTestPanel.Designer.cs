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
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.dateOfBirthTextbox = new _10_Meter_Walk.TextPanel();
            this.patientLastTextbox = new _10_Meter_Walk.TextPanel();
            this.patientFirstTextbox = new _10_Meter_Walk.TextPanel();
            this.recordsPanel = new System.Windows.Forms.Panel();
            this.recordsTable = new System.Windows.Forms.DataGridView();
            this.patientInformationPanel.SuspendLayout();
            this.recordsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTable)).BeginInit();
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
            // recordsPanel
            // 
            this.recordsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.recordsPanel.Controls.Add(this.recordsTable);
            this.recordsPanel.Location = new System.Drawing.Point(3, 288);
            this.recordsPanel.Name = "recordsPanel";
            this.recordsPanel.Size = new System.Drawing.Size(628, 195);
            this.recordsPanel.TabIndex = 6;
            // 
            // recordsTable
            // 
            this.recordsTable.AllowUserToDeleteRows = false;
            this.recordsTable.AllowUserToOrderColumns = true;
            this.recordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsTable.Location = new System.Drawing.Point(3, 26);
            this.recordsTable.Name = "recordsTable";
            this.recordsTable.ReadOnly = true;
            this.recordsTable.Size = new System.Drawing.Size(622, 150);
            this.recordsTable.TabIndex = 0;
            // 
            // ViewTestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recordsPanel);
            this.Controls.Add(this.patientInformationPanel);
            this.Name = "ViewTestPanel";
            this.Size = new System.Drawing.Size(634, 486);
            this.patientInformationPanel.ResumeLayout(false);
            this.patientInformationPanel.PerformLayout();
            this.recordsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel patientInformationPanel;
        private TextPanel dateOfBirthTextbox;
        private TextPanel patientLastTextbox;
        private TextPanel patientFirstTextbox;
        private System.Windows.Forms.Label patientInformationLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel recordsPanel;
        private System.Windows.Forms.DataGridView recordsTable;
    }
}
