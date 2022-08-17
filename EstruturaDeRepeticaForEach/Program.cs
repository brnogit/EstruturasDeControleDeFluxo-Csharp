using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticaForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estrutura de Repetição - For Each

            Console.WriteLine("Digite uma sequência de números separados pelo espaço");
            //0 1 2 3 4 5 6 7 8 9 10

            var numerosTexto = Console.ReadLine();

            var numeros = numerosTexto.Split(' ');

            foreach (var numero in numeros) // string numero in numeros
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            #endregion
        }
    }
}
