using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job3
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[20];
        int j = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mas[i] = rand.Next(-15, 15);
                listBox1.Items.Add("Mas[" + i.ToString() + "]=" + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int max = Mas.Max();
            listBox2.Items.Clear();

            for (int i = 0; i < 20; i++)
            {
                Mas[0] = max;
                listBox2.Items.Add("Mas[" + Convert.ToString(i) + "]=" + Mas[i].ToString());
            }
        }
    }
}

