using System.Windows;

namespace KasirPerumahan
{
    public partial class App : Application
    {
        public static Window MainWindowInstance { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            MainWindowInstance = new MainWindow();
            MainWindowInstance.Show();
        }

        public static void NavigateToLogin()
        {
            MainWindowInstance.Content = new Views.LoginView();
        }

        public static void NavigateToAddUser()
        {
            MainWindowInstance.Content = new Views.AddUserView();
        }
    }
}