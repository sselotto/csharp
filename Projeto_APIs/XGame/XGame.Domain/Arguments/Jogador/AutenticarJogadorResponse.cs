using System;
using XGame.Domain.ValueObject;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse
    {
        public string PrimeiroNome { get; set; }

        public string Email { get; set; }
    }
}
