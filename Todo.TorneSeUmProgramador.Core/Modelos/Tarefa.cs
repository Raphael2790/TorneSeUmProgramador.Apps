namespace Todo.TorneSeUmProgramador.Core.Modelos;

public class Tarefa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataConclusao { get; set; }
    public bool Concluida { get; set; }
}
