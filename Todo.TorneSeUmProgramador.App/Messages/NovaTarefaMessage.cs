using CommunityToolkit.Mvvm.Messaging.Messages;
using Todo.TorneSeUmProgramador.Core.Modelos;

namespace Todo.TorneSeUmProgramador.App.Messages;

public class NovaTarefaMessage : ValueChangedMessage<Tarefa>
{
    public NovaTarefaMessage(Tarefa value) : base(value)
    {
    }
}
