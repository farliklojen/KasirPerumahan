using System.Windows;
using System.Windows.Controls;

namespace KasirPerumahan.Views
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            App.NavigateToAddUser();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fitur kembali belum diimplementasikan", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}