using System.Windows;
using System.Windows.Controls;

namespace KasirPerumahan.Views
{
    public partial class AddUserView : UserControl
    {
        public AddUserView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("User berhasil ditambahkan", "Sukses", MessageBoxButton.OK, MessageBoxImage.Information);
            App.NavigateToLogin();
        }
    }
}