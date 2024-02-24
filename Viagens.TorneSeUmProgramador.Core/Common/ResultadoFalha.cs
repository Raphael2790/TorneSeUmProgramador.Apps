using Viagens.TorneSeUmProgramador.Core.Common.Interfaces;

namespace Viagens.TorneSeUmProgramador.Core.Common;

public class ResultadoFalha : IResultado
{
}

public class ResultadoFalha<T> : ResultadoFalha, IResultado<T>
{
    public DetalheFalha Detalhe { get; }

    public ResultadoFalha(DetalheFalha detalhe) => Detalhe = detalhe;
}
