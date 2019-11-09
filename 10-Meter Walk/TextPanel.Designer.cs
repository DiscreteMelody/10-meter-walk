namespace _10_Meter_Walk
{
    partial class TextPanel
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
            this.textBoxPanel = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.BackColor = System.Drawing.Color.White;
            this.textBoxPanel.Controls.Add(this.textBox);
            this.textBoxPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPanel.Location = new System.Drawing.Point(5, 3);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxPanel.Size = new System.Drawing.Size(176, 33);
            this.textBoxPanel.TabIndex = 6;
            this.textBoxPanel.Enter += new System.EventHandler(this.paddingPanel_Enter);
            this.textBoxPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paddingPanel_MouseClick);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(5, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(166, 20);
            this.textBox.TabIndex = 0;
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // TextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBoxPanel);
            this.Name = "TextPanel";
            this.Size = new System.Drawing.Size(186, 39);
            this.Load += new System.EventHandler(this.TextPanel_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextPanel_MouseClick);
            this.textBoxPanel.ResumeLayout(false);
            this.textBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel textBoxPanel;
        private System.Windows.Forms.TextBox textBox;
    }
}
