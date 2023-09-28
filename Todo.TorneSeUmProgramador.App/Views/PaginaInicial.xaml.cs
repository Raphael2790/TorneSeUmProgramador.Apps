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
			},
			new
			{
				Nome = "Tarefa 2",
				Descricao = "Descrição da tarefa 2",
			},
		};
	}

    private void PesquisaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void AdiconarTarefa_ButtonClicked(object sender, EventArgs e)
    {

    }
}