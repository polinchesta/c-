using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace AppSample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
            => Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
    }
}
