namespace Viagens.TorneSeUmProgramador.Core.Interfaces;

public interface IDeepLinkService
{
    Task<bool> AbrirWhatsAppComMensagem(string? mensagem = null);
}
