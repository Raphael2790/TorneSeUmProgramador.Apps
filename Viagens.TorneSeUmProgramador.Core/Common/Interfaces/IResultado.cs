namespace Viagens.TorneSeUmProgramador.Core.Common.Interfaces;

public interface IResultado
{
}

public interface IResultado<out T> : IResultado
{
}
