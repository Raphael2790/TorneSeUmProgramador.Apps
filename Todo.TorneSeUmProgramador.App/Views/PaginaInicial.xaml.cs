namespace Todo.TorneSeUmProgramador.App.Views;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();

		TarefasCollectionView.ItemsSource = new List<object>
		{
			new
			{
				Nome = "Tarefa 1",
				Descricao = "Descrição da tarefa 1",
				Concluida = false
			},
			new
			{
				Nome = "Tarefa 2",
				Descricao = "Descrição da tarefa 2",
				Concluida = true
			},
		};
	}

    private void PesquisaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private async void AdiconarTarefa_ButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new AdicionarEditarTarefa());
	}

    #region Exemplos de código
    private void ExemplosCompilaçãoCondicional()
	{
#if ANDROID
        DisplayAlert("Android", "Adicionar tarefa", "OK");
#endif

#if WINDOWS
        DisplayAlert("Windows", "Adicionar tarefa", "OK");
#endif
    }

    //  protected override void OnSizeAllocated(double width, double height)
    //  {
    //pesquisaEntry.WidthRequest = width - 100;
    //pesquisaEntry.HorizontalOptions = LayoutOptions.Center;

    //      base.OnSizeAllocated(width, height);
    //  }
    #endregion
}