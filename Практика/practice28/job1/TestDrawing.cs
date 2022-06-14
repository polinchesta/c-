using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace job1
{
    internal class TestDrawing:Control
    {
        protected override void OnRender (System.Windows.Media.DrawingContext drawingContext)
        {
            drawingContext.DrawLine(new Pen(Brushes.Red,2),
                new Point (0,0),
                new Point (this.Height, this.Width));

            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
                new Point(0, this.Width),
                new Point(this.Height, 0));

            base.OnRender(drawingContext);
        }
            }

}
