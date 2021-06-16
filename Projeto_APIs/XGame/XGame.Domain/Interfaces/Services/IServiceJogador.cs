using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        //Metodo para autenticar o meu jogador
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        //Adicionar Jogador
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request); 

    }
}
