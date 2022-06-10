using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace задание_1
{
    /// <summary>
    /// Логика взаимодействия для AboutAp.xaml
    /// </summary>
    public partial class AboutAp : Window
    {
        public AboutAp()
        {
            InitializeComponent();
            buttonClose.Click += ButtonClose_Click;
        }

        public AboutAp(string apInfo) : this()
        {
            textBlockInfo.Text = apInfo;
        }

        private void ButtonClose_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
