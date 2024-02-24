using Viagens.TorneSeUmProgramador.Core.Common.Interfaces;

namespace Viagens.TorneSeUmProgramador.Core.Common;

public class ResultadoSucesso : IResultado
{
}

public class ResultadoSucesso<T> : ResultadoSucesso, IResultado<T>
{
    public T Dados { get; }

    public ResultadoSucesso(T dados) => Dados = dados;

    public static implicit operator T(ResultadoSucesso<T> resultado) => resultado.Dados;

    public static implicit operator ResultadoSucesso<T>(T dados) => new(dados);
}
