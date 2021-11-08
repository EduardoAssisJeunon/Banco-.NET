using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraTeste
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            c.setNumero1(14);
            c.setNumero2(50);
            Console.WriteLine(c.soma());
            Console.WriteLine(c.subtracao());
            Console.WriteLine(c.multiplicacao());
            Console.WriteLine(c.divisao());
            Console.ReadKey();
        }
    }

class Calculadora
{
    private double n1;
    private double n2;
        public Calculadora ()
        {
        }
    public Calculadora(double n1, double n2)
    {
        this.n1 = n1;
        this.n2 = n2;
    }
    public void setNumero1(double n1)
    {
        this.n1 = n1;
    }
    public double getNumero1()
    {
        return n1;
    }

    public void setNumero2(double n2)
    {
        this.n2 = n2;
    }
    public double getNumero2()
    {
        return n2;
    }
    public double soma()
    {
        return n1 + n2;
    }
    public double subtracao()
    {
        return n1 - n2;
    }
    public double multiplicacao()
    {
        return n1 * n2;
    }
    public double divisao()
    {
        return n1 / n2;
    }
}
}






