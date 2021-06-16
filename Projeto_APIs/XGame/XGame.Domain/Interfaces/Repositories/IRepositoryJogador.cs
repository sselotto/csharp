using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        //Metodo para autenticar o meu jogador
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request); //Esse é o que vai ao BD capturar os dados

        //Adicionar Jogador
        Guid AdicionarJogador(Jogador jogador); // Vai devolver apenas o Id, quem devolve mensagem é o service

    }
}
