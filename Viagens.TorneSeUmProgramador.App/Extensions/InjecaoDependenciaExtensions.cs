﻿using Flurl.Http.Configuration;
using Viagens.TorneSeUmProgramador.App.ViewModels;
using Viagens.TorneSeUmProgramador.App.Views;
using Viagens.TorneSeUmProgramador.Business.Services;
using Viagens.TorneSeUmProgramador.Business.Services.Interfaces;
using Viagens.TorneSeUmProgramador.Core.Interfaces;
using Viagens.TorneSeUmProgramador.Data.Clients;
using Viagens.TorneSeUmProgramador.Data.Logger;

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
        return services;
    }

    private static IServiceCollection ConfigurarServicos(this IServiceCollection services)
    {
        services.AddTransient<IBuscaService, BuscaService>();
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
                .Add("viagens-api-client", "https://localhost:44326/")
        );
        services.AddSingleton<IViagensApiClient, ViagensApiClient>();
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
