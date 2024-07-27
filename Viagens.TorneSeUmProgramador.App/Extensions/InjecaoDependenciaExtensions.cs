using Flurl.Http.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Plugin.Fingerprint.Abstractions;
using Plugin.Fingerprint;
using Viagens.TorneSeUmProgramador.App.AppServices;
using Viagens.TorneSeUmProgramador.App.Storages;
using Viagens.TorneSeUmProgramador.App.ViewModels;
using Viagens.TorneSeUmProgramador.App.ViewModels.Components;
using Viagens.TorneSeUmProgramador.App.Views;
using Viagens.TorneSeUmProgramador.Business.Services;
using Viagens.TorneSeUmProgramador.Business.Services.Interfaces;
using Viagens.TorneSeUmProgramador.Core.Interfaces;
using Viagens.TorneSeUmProgramador.Data.Clients;
using Viagens.TorneSeUmProgramador.Data.Logger;
using Viagens.TorneSeUmProgramador.Data.Proxies;

namespace Viagens.TorneSeUmProgramador.App.Extensions;

public static class InjecaoDependenciaExtensions
{
    public static void ConfigurarDependencias(this IServiceCollection services)
    {
        services.ConfigurarViewModels()
            .ConfigurarRepositorios()
            .ConfigurarServicos()
            .ConfigurarPersistencia()
            .ConfigurarClients()
            .ConfigurarViews()
            .ConfigurarLogger();
    }

    private static IServiceCollection ConfigurarViewModels(this IServiceCollection services)
    {
        services.AddTransient<LoginViewModel>();
        services.AddTransient<PaginaInicialViewModel>();
        services.AddTransient<OfertasViewModel>();
        services.AddTransient<AvatarUsuarioViewModel>();
        return services;
    }

    private static IServiceCollection ConfigurarServicos(this IServiceCollection services)
    {
        //serviços do app
        services.AddTransient<IBuscaService, BuscaService>();
        services.AddTransient<IAuthService, AuthService>();
        services.AddSingleton<ILocalizacaoService, LocalizacaoService>();
        services.AddSingleton<IAppCache, AppCachePreferencesStorage>();

        //serviços nativos
        services.AddSingleton<IConnectivity>(Connectivity.Current);
        services.AddSingleton<IGeolocation>(Geolocation.Default);
        services.AddSingleton<IMediaPicker>(MediaPicker.Default);
        services.AddSingleton<IFingerprint>(CrossFingerprint.Current);

        return services;
    }

    private static IServiceCollection ConfigurarRepositorios(this IServiceCollection services)
    {
        return services;
    }

    private static IServiceCollection ConfigurarPersistencia(this IServiceCollection services)
    {
        return services;
    }

    private static IServiceCollection ConfigurarClients(this IServiceCollection services)
    {
        services.AddSingleton(sp =>
            new FlurlClientCache()
                .Add("viagens-api-client", "https://bc2a-2804-14c-96-8b89-c9b4-2edc-5241-d25a.ngrok-free.app/")
                .Add("auth-api-client", "https://bc2a-2804-14c-96-8b89-c9b4-2edc-5241-d25a.ngrok-free.app/")
        );

        services.AddSingleton<IViagensApiClient, ViagensApiClient>();

        services.AddSingleton<IAuthClient, AuthClient>();

        services.AddSingleton<IViagensProxy, ViagensProxy>();

        return services;
    }

    private static IServiceCollection ConfigurarViews(this IServiceCollection services)
    {
        services.AddSingleton<Login>();
        services.AddSingleton<PaginaInicial>();
        services.AddSingleton<BuscaPassagemArea>();
        services.AddSingleton<MeusFavoritos>();
        services.AddSingleton<MinhasViagens>();
        services.AddSingleton<Ofertas>();
        services.AddSingleton<Perfil>();
        return services;
    }

    public static IServiceCollection ConfigurarLogger(this IServiceCollection services)
    {
        services.AddLogging();
        services.AddSingleton(typeof(IAppLogger<>), typeof(AppLogger<>));
        return services;
    }
}
