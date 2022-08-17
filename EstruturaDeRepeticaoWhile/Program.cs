using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estrutura de Repetição - While
            Console.WriteLine("Digite uma sequência de números separados por espaço.");
            // 0 1 2 3 4 5 6 7 8 9 10
            var numerosTexto = Console.ReadLine();

            var numeros = numerosTexto.Split(' ');

            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);

                contador++;
            }

            Console.ReadKey();
            #endregion
        }
    }
}
