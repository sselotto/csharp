using System;


namespace Tratamento_Excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        //Construtor recebendo uma string message
        //Repassa essa mensagem para o construtor da classe applicationException

        public DomainException(string message) : base(message)
        {

        }
    }
}
    

