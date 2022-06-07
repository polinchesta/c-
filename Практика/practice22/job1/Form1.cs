using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-1,22";
            double y = double.Parse(textBox2.Text);
            textBox2.Text += Environment.NewLine;
            textBox1.Text = "14,26";
            double x = double.Parse(textBox1.Text);
            textBox1.Text += Environment.NewLine;
            double z = 3.5 * Math.Pow(10, -2);
            textBox3.Text = "0,035";
            textBox3.Text += Environment.NewLine;
            double t = (2 * Math.Cos(x - Math.PI / 6) / 0.5 + Math.Pow(Math.Sin(y), 2) * (1 + (Math.Pow(z, 2) / 3 - Math.Pow(z, 2) / 5)));
            textBox5.Text = Convert.ToString(t);
        }
    }
}
