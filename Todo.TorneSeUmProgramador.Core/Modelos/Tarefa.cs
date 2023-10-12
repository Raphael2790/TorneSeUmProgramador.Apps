namespace Todo.TorneSeUmProgramador.Core.Modelos;

public class Tarefa
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataConclusao { get; set; }
    public bool Concluida { get; set; }
}
