using Todo.TorneSeUmProgramador.App.Views;

namespace Todo.TorneSeUmProgramador.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaInicial();
        }
    }
}