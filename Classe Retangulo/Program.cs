using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo
{

	class quadradao
	{
		static void Main(string[] arg)
		{
			retangulo novo = new retangulo(2, 5);
			Console.WriteLine(novo.getArea());
			Console.WriteLine(novo.getPerimetro());
			novo.novosLados(10, 7);
			Console.WriteLine(novo.getArea());
			Console.WriteLine(novo.getPerimetro());
		}
	}


	public class retangulo
	{
		double lado1;
		double lado2;
		double perimetro;
		double area;
		
		public retangulo(double l, double l2, double p, double a)
		{
			this.lado1 = l;
			this.lado2 = l2;
			this.perimetro = p;
			this.area = a;
		}

		public void setnovosLados(double l, double l2)
		{
			lado1 = l;
			lado2 = l2;
		}
		public double getnovosLados()
        {
			return getnovosLados;
        }
		public void setCalculaArea(double lado1, double lado2)
		{
			area = lado1 * lado2;
		}

		public double getArea()
		{
			return area;
		}
		public void setCalculaPerimetro(double lado1, double lado2)
		{
			perimetro = lado1 * 2 + lado2 * 2;
		}
		public double getPerimetro()
		{
			return perimetro;
		}
	}
}