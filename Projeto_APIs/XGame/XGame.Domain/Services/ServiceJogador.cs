using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        //Por ser privado é utilizado apenas para consultar _repositoryJogador
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }
        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Jogador jogador = new Jogador();
            jogador.Email = request.Email;
            jogador.Nome = request.Nome;
            jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;


            Guid id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarHogadorRequest", "AutenticarJogadorRequest é Obrigatório");
            }

            var email = new Email("paulo");

            var jogador = new Jogador(email, "222");

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
            {
                return null;
            }

            //Acessar o repository e chamar o metodo Autenticarjogador 

            var response = _repositoryJogador.AutenticarJogador(request);
            return response;
        }

        private bool IsEmail(String email)
        {
            return false;
        }


    }
}

