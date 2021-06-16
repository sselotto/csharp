using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {
        //Metodo para autenticar o meu jogador
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        //Adicionar Jogador
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request); 

    }
}
