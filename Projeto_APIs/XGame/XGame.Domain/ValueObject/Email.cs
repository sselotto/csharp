using prmToolkit.NotificationPattern;
using System;


namespace XGame.Domain.ValueObject
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco);
        }

        public string Endereco { get; private set; }
    }
}
