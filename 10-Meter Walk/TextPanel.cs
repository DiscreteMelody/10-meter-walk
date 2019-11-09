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
    public partial class TextPanel : UserControl
    {
        private string watermarkText = "";
        private Color watermarkColor = Color.White;
        private Color foreColor = Color.White;
        private Color borderColor = Color.Transparent;
        private bool togglesBorder = false;

        [Browsable(true)]
        [Description("The Watermark text of the textbox"), Category("Data")]
        public string WatermarkText
        {
            get { return this.watermarkText; }
            set { this.watermarkText = value; }
        }
        [Browsable(true)]
        [Description("The color of the watermark text"), Category("Data")]
        public Color WatermarkColor
        {
            get { return this.watermarkColor; }
            set { this.watermarkColor = value; }
        }
        [Browsable(true)]
        [Description("The color of the padding around the textbox"), Category("Data")]
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        [Description("Toggles if the border will switch between transparent and the selected border color upon selection"), Category("Data")]
        public bool TogglesBorder
        {
            get { return this.togglesBorder; }
            set { this.togglesBorder = value; }
        }
        public string Text
        {
            get { return this.textBox.Text; }
            set
            {
                this.onTextBoxClicked();
                this.textBox.Text = value;
                this.onTextBoxLeave();
            }
        }

        public TextPanel()
        {
            InitializeComponent();
            this.foreColor = textBox.ForeColor;
        }

        private void paddingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Focus();
            onTextBoxClicked();
        }

        //if the textbox is left blank upon leaving, the text will switch to the watermark
        private void textBox_Leave(object sender, EventArgs e)
        {
            onTextBoxLeave();
        }

        private void onTextBoxLeave()
        {
            if (textBox.Text == "")
            {
                textBox.Text = watermarkText;
                textBox.ForeColor = watermarkColor;
            }
            this.BackColor = Color.Transparent;
        }

        private void onTextBoxClicked()
        {
            if(textBox.Text == this.watermarkText)
            {
                textBox.Text = "";
                textBox.ForeColor = foreColor;
            }
            if (togglesBorder)
            {
                this.BackColor = borderColor;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            onTextBoxClicked();
        }

        private void paddingPanel_Enter(object sender, EventArgs e)
        {
            onTextBoxClicked();
        }

        private void TextPanel_MouseClick(object sender, MouseEventArgs e)
        {
            onTextBoxClicked();
        }

        private void TextPanel_Load(object sender, EventArgs e)
        {
            onTextBoxClicked();
            onTextBoxLeave();
        }

        /// <summary>
        /// empties the text of the text panel and resets the watermark and border as if it became inactive
        /// </summary>
        public void clearText()
        {
            this.textBox.Text = "";
            this.onTextBoxClicked();
            this.onTextBoxLeave();
        }
    }
}
