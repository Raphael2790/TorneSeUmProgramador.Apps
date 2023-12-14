namespace Viagens.TorneSeUmProgramador.App.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void OnClickNevagarParaPaginaHome(object sender, EventArgs e)
    {
		//Navegação absoluta
		Shell.Current.GoToAsync("//home");
    }
}