using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Meter_Walk
{
    public class CircularButton : Button
    {
        private Color borderColor;
        private float borderRadius;
        private SolidBrush brush;
        private Pen pen;

        [Description("The color of the round border"), Category("Data")]
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        [Description("The radius of the button's border"), Category("Data")]
        public float BorderRadius
        {
            get { return this.borderRadius; }
            set { this.borderRadius = value; }
        }
        public Pen Pen
        {
            get { return this.pen; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }

    }
}
