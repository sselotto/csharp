using System;



namespace Tratamento_Excecoes_2.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }

    }
}
