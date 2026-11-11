using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NetworkInspektor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNacist_Click(object sender, RoutedEventArgs e)
        {
        }

        private void LstAdaptery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstAdaptery.SelectedItem is ListBoxItem adapter)
            {
                txtNazev.Text = adapter.Content?.ToString() ?? string.Empty;
            }
        }
    }
}