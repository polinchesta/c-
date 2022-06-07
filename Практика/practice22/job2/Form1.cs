using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double f = Math.Pow(x, 2);
            double a = 0;
            if (x*y>0)
            {
                 a = Math.Pow(f + y, 2) - Math.Sqrt(f * y);
            }
            if (x*y<0)
            {
                 a = Math.Pow(f + y, 2) + Math.Sqrt(Math.Abs(x)*y);
            }
            else
            {
                 a = Math.Pow(f + y, 2) + 1;
            }
                        textBox4.Text = Convert.ToString(a);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
