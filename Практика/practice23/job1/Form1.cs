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
            listBox1.Items.Add(listBox1.Text);
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count1 = 0, count2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    count1++;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    count2++;
                }
            }

            label2.Text = "Количество  нулей = " + count2.ToString();
            label1.Text = "Количество единиц = " + count1.ToString();
        }
    }
}


