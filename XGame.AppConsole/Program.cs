using System;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            //Instancia o serviço
            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servico");

            //Adiciona um novo jogador
            AdicionarJogador(service);

            //Verifica a validade do serviço
            Console.WriteLine("Meu serviço é valido -> " + service.IsValid());

            //Loga as notificações do serviço
            service.Notifications.ToList().ForEach(x => {
                Console.WriteLine(x.Message);
            });


            Console.ReadKey();
        }


        public static void AutenticarJogador(ServiceJogador service)
        {
            var request = new AutenticarJogadorRequest() 
            { 
                Email = "teste@teste.com",
                Senha = "123456"
            };

            Console.WriteLine("Criei instancia do objeto request");

            service.AutenticarJogador(request);
        }

        public static void AdicionarJogador(ServiceJogador service)
        {
            var request = new AdicionarJogadorRequest()
            {
                Email = "teste@teste.com",
                PrimeiroNome = "Valdir",
                UltimoNome = "Marcheuski",
                Senha = "123456"
            };

            Console.WriteLine("Criei instancia do objeto request");

            service.AdicionarJogador(request);
        }
    }
}
