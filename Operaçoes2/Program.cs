using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaçoes2
{
    class Program
    {
        static void Main(string[] args)
        {
                double n1, n2, n3, n4, n5, n6, n7, n8;
                Console.Write("Digite o primeiro numero para fazer a soma: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero para fazer a soma: ");
                string numero = Console.ReadLine();
                n2 = double.Parse(numero);
                double soma = n1 + n2;
                Console.WriteLine("A soma é {0}", soma);
                Console.Write("Digite o primeiro numero para fazer a subtração: ");
                n3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero para fazer a subtração: ");
                string numero1 = Console.ReadLine();
                n4 = double.Parse(numero1);
                double subtracao = n3 - n4;
                Console.WriteLine("A subtracao é {0}", subtracao);
                Console.Write("Digite o primeiro numero para fazer a multiplicação: ");
                n5 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero para fazer a multiplicação: ");
                string numero2 = Console.ReadLine();
                n6 = double.Parse(numero2);
                double multiplicacao = n5 * n6;
                Console.WriteLine("A multiplicação é {0}", multiplicacao);               
                Console.Write("Digite o primeiro numero para fazer a divisão: ");
                n7 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero para fazer a divisão: ");
                string numero3 = Console.ReadLine();
                n8 = double.Parse(numero3);
                double divisao = n7 / n8;
                Console.WriteLine("A divisão é {0}", divisao);
                Console.ReadKey();
            }
        }
    }

    

