using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Conta
{
	class Banco
	{
		static void Main(string[] args)
		{
			Conta nova = new Conta("Duardo", 3214235, 1000, 3000);
			Console.WriteLine(nova.getVerificaSaldo());
			Console.WriteLine(nova.getVerificaLimite());
			Console.ReadKey();
		}
	}
	class Conta
	{

		private string dono;
		private int numero;
		private double saldo;
		private double limite;


		public Conta(string brabo, int nm, double s, double l)
		{

			this.dono = brabo;
			this.numero = nm;
			this.saldo = s;
			this.limite = l;
		}

		public void setSaque(double quantidade)
		{
			saldo = saldo - quantidade;
		}
		public double getVerificaSaldo()
		{
			return saldo;
		}

		public void setDeposita(double quantidade)
		{
			saldo = saldo + quantidade;
		}
		public double getVerificaLimite()
		{
			return limite;
		}

		public void setAlteraLimite(double novo_lim)
		{
			limite = novo_lim;
		}
		public void setAumentaLimite(double quantidade)
		{
			limite = limite + quantidade;
		}
		public void setDiminuiLimite(double quantidade)
		{
			limite = limite - quantidade;
		}

	}
}