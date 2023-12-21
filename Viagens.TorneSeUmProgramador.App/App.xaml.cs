namespace Viagens.TorneSeUmProgramador.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            App.Current.UserAppTheme = AppTheme.Light;

            MainPage = new AppShell();
        }
    }
}