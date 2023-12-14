namespace Viagens.TorneSeUmProgramador.App.Views;

public partial class BuscaPassagemArea : ContentPage
{
	public BuscaPassagemArea()
	{
		InitializeComponent();
	}

    private void OnClickVoltar(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}