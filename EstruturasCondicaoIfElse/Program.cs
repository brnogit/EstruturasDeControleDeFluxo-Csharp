using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCondicaoIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            var notaDigitada = Console.ReadLine();

            var nota = int.Parse(notaDigitada);

            if (nota >= 70)
            {
                Console.WriteLine("Aprovado.");
            } else if (nota >= 40)
            {
                Console.WriteLine("Em recuperação.");
            }else
            {
                Console.WriteLine("Reprovado.");
            }

            
        }
    }
}
