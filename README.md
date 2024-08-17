# Torne se aplicativo de viagens - `Torne se Um Viajante` :trophy:
Aplicativo desnvolvido em conjunto com a comunidade do Torne Se Um Programador com finalidade de aprendizado de novas tecnologias utilizando `dotnet` 

## Desenho fluxo aplicação:

![Desenho Solução](https://github.com/user-attachments/assets/9a2472b0-1373-4179-b60d-a999a98337f6)

# Ferramentas de Desenvolvimento
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/)
- [Srccpy](https://github.com/Genymobile/scrcpy)
- [Celular Proprio ou Emulador](https://learn.microsoft.com/pt-br/windows/android/emulator)

# Links Úteis :bookmark_tabs:

- [O Que é o MAUI?](https://learn.microsoft.com/pt-br/dotnet/maui/what-is-maui)
- [Baixando Srccpy](https://github.com/Genymobile/scrcpy/blob/master/doc/windows.md)
- [Publicar um aplicativo Android usando a linha de comando](https://learn.microsoft.com/pt-br/dotnet/maui/android/deployment/publish-cli?view=net-maui-8.0)
- [Como criar um readme usando markdown](https://docs.github.com/pt/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
- [Passo a passo publicação aplicativo - Video](https://www.youtube.com/watch?v=L9sU_aGeQEY)
- [Prototipação aplicativo](https://www.figma.com/design/q3dAD9UWL0L10BAxz0HGPe/Torne-Se-Um-Viajante?node-id=0-1&t=dbDv7VNALNXYC1V4-0)
- [Figma](https://www.figma.com/files/team/1302987226673698665/recents-and-sharing/recently-viewed?fuid=856910953144087629)

# Documentação
 - [Como publicar um aplicativo na play store](https://learn.microsoft.com/en-us/dotnet/maui/android/deployment/publish-google-play?view=net-maui-8.0)
 - [Navegação utilizando o Shell](https://learn.microsoft.com/pt-br/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0)
 - [Utilizando seletor de midia do dispoisitivo](https://learn.microsoft.com/pt-br/dotnet/maui/platform-integration/device-media/picker?view=net-maui-8.0&tabs=android)
 - [Obtendo a localização atual do dispositivo](https://learn.microsoft.com/pt-br/dotnet/maui/platform-integration/device/geolocation?view=net-maui-8.0&tabs=android)
 - [Criando deeplinks no aplicativo](https://learn.microsoft.com/pt-br/dotnet/maui/android/app-links?view=net-maui-8.0)
 - [Verificando a conectividade do dispositivo](https://learn.microsoft.com/pt-br/dotnet/maui/platform-integration/communication/networking?view=net-maui-8.0&tabs=android)

## Pré requisitos :warning:

- [.Net 7.0](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/overview)
- [Api BFF](https://github.com/Raphael2790/Viagens.TorneSeUmProgramador.Api)

## Dependencias :package:
| Nuget | Documentação |
| --- | --- |
| Entity Framework Core | <https://docs.microsoft.com/pt-br/ef/core/overview> |
| Plugin Fingerprint | <https://www.nuget.org/packages/Plugin.Fingerprint/3.0.0-beta.1>



# Comandos úteis
## Gerar chave keystore
keytool -genkeypair -v -keystore {filename}.keystore -alias {keyname} -keyalg RSA -keysize 2048 -validity 10000

## Comando para assinar o aplicativo
dotnet publish -f net7.0-android -c Release -p:AndroidKeyStore=true -p:AndroidSigningKeyStore={filename}.keystore -p:AndroidSigningKeyAlias={keyname} -p:AndroidSigningKeyPass={password} -p:AndroidSigningStorePass={password}

## Duvidas :envelope:

  Para dúvidas, sugestões ou quaisquer dificuldades na implementação da solução basta mandar mensagem no chat do Discord do Torne Se Um Programador na aba de CSharp, sinta-se a vontade para alterar, melhorar e enviar pull request para o projeto.  