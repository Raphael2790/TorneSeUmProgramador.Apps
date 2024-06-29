﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Viagens.TorneSeUmProgramador.Business.Services.Interfaces;
using Viagens.TorneSeUmProgramador.Core.Common;
using Viagens.TorneSeUmProgramador.Core.Dtos;

namespace Viagens.TorneSeUmProgramador.App.ViewModels;

public sealed partial class LoginViewModel : ObservableObject
{
    private readonly IAuthService _authService;

    public LoginViewModel(IAuthService authService)
    {
        _authService = authService;
    }

    [ObservableProperty]
    private bool senhaVisivel = false;

    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private string senha;

    [RelayCommand]
    public void OnTapSenhaImage(StackLayout stackLayout)
    {
        if (SenhaVisivel)
        {
            ((Entry)stackLayout.Children[0]).IsPassword = true;
            ((Image)stackLayout.Children[1]).Source = ImageSource.FromFile("eyeclosed.png");
            SenhaVisivel = false;
        }
        else
        {
            ((Entry)stackLayout.Children[0]).IsPassword = false;
            ((Image)stackLayout.Children[1]).Source = ImageSource.FromFile("eyeopen.png");
            SenhaVisivel = true;
        }
    }

    [RelayCommand]
    public async Task OnTapEntrar()
    {
        if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Senha))
        {
            await App.Current.MainPage.DisplayAlert("Erro", "Usuário e senha são obrigatórios", "Ok");
            return;
        }

        var loginDto = new LoginDto(Email, Senha);

        var resultado = await _authService.RealizarAutenticacaoUsuario(loginDto);

        if (resultado is ResultadoSucesso<ResultadoLoginDto> _)
        {
            await App.Current.MainPage.DisplayAlert("Sucesso", "Login realizado com sucesso", "Ok");
            return;
        }

        var falha = resultado as ResultadoFalha<ResultadoLoginDto>;
        await App.Current.MainPage.DisplayAlert("Erro", string.Join(" ", falha.Detalhe.Mensagens.Select(x => x.Texto)), "Ok");
    }
}
