using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.Write("Digite o primeiro numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            string numero = Console.ReadLine();
            n2 = double.Parse(numero);
            double soma = n1 + n2;
            double subtracao = n1 - n2;
            double multiplicacao = n1 * n2;
            double divisao = n1 / n2; 
            Console.WriteLine("A soma é {0}", soma);
            Console.WriteLine("A subtracao é {0}", subtracao);
            Console.WriteLine("A multiplicação é {0}", multiplicacao);
            Console.WriteLine("A divisão é {0}", divisao);
            Console.ReadKey();
        }
    }
}
