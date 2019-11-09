using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Meter_Walk
{
    public static class StyleManager
    {
        private static Brush brush;
        private static Pen pen;

        /// <summary>
        /// Paints a circle around a circular button
        /// </summary>
        /// <param name="circular_button">the circular button to be drawn around</param>
        /// <param name="paint_event"></param>
        public static void addCircularBorder(CircularButton circular_button, PaintEventArgs paint_event)
        {
            try
            {
                brush = new SolidBrush(circular_button.BorderColor);
                pen = new Pen(brush);
                pen.Width = circular_button.BorderRadius;
                paint_event.Graphics.DrawEllipse(pen, circular_button.Location.X - 1, circular_button.Location.Y - 1, circular_button.Width + 1, circular_button.Height + 1);
                Console.WriteLine(circular_button.Pen.Width);
            }
            catch
            {
                //do nothing
            }
            
        }
    }
}
