using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticaoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Sjeja bem-vindo a empresa X");

            Console.WriteLine("Digite 1 - Contração de um plano.");
            Console.WriteLine("Digite 2 - Reclamação de serviço prestado.");
            Console.WriteLine("Digite 3 - Segunda via de boleto");
            Console.WriteLine("Digite 4 - Sair.");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações de plano novo.");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação");
                    break;
                case "3":
                    Console.WriteLine("Segunda via de boleto enviada por email.");
                    break;
                case "4":
                    Console.WriteLine("Tenha um bom dia!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada");
                    break;
            }
            #endregion
        }
    }
}
