namespace Viagens.TorneSeUmProgramador.App.Views;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}

    private void OnClickNavegarParaPassagensAreas(object sender, EventArgs e)
    {
		//Navega��o relativa
		Shell.Current.GoToAsync("/busca-passagem-area");
    }
}