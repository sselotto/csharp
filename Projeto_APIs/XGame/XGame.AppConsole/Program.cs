using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Services;
using XGame.Domain.Arguments.Jogador;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando ...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servico");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");

            var response = service.AutenticarJogador(request);
            Console.ReadKey();
        }
    }
}
