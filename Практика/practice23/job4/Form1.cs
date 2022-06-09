using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            g.FillRectangle(Brushes.Black, 240, 180, 10, 10);
        
            SolidBrush B = new SolidBrush(Color.Red);
            g.FillEllipse(B, 200, 100, 200, 100);

            for (int i = 0; i < 1; i++)
            g.DrawEllipse(new Pen(Brushes.DarkGreen, 4),
            200, 100 * i + 100, 200, 100 * i + 100);

            g.FillRectangle(Brushes.Black, 270, 140, 2, 10);
            g.FillRectangle(Brushes.Black, 250, 160, 7, 10);
            g.FillRectangle(Brushes.Black, 250, 144, 4, 10);
            g.FillRectangle(Brushes.Black, 260, 180, 3, 10);
            g.FillRectangle(Brushes.Black, 275, 120, 1, 10);
            g.FillRectangle(Brushes.Black, 290, 170, 7, 10);
            g.FillRectangle(Brushes.Black, 295, 190, 8, 10);
            g.FillRectangle(Brushes.Black, 265, 180, 7, 10);
            g.FillRectangle(Brushes.Black, 350, 170, 10, 10);
            g.FillRectangle(Brushes.Black, 340, 160, 7, 10);
            g.FillRectangle(Brushes.Black, 350, 110, 9, 10);
            g.FillRectangle(Brushes.Black, 321, 180, 7, 10);
            g.FillRectangle(Brushes.Black, 344, 170, 4, 10);
            g.FillRectangle(Brushes.Black, 300, 160, 7, 10);
            g.FillRectangle(Brushes.Black, 312, 140, 1, 10);
            g.FillRectangle(Brushes.Black, 315, 140, 2, 10);
        }

}
}
