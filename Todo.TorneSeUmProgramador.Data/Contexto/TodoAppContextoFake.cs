using Todo.TorneSeUmProgramador.Core.Modelos;

namespace Todo.TorneSeUmProgramador.Data.Contexto;

public class TodoAppContextoFake
{
    public static TodoAppContextoFake Instance = new();

    public List<Tarefa> Tarefas { get; set; }

    public TodoAppContextoFake()
    {
        Tarefas = new List<Tarefa>();
    }
}
