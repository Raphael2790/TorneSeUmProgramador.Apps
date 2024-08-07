﻿using Viagens.TorneSeUmProgramador.Core.Enums;

namespace Viagens.TorneSeUmProgramador.Core.Dtos;

public record OfertaDto(int Id, string? Imagem, string? Titulo, string? Local,
    string? Latitude, string? Longitude, string? Preco, string? PrecoAnterior, string Data, string TipoPacote);