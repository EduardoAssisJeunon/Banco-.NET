using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaProg1
{
    public class TV
    {
        private int tamanho;
        private int canal;
        private int volume;
        private bool ligada;
        public void setTamanho(int tamanho)
        {
            this.tamanho = tamanho;
        }
        public int getTamanho()
        {
            return tamanho;
        }
        public void setCanal(int canal)
        {
            this.canal = canal;
        }
        public int getCanal()
        {
            return canal;
        }
        public void setVolume(int volume)
        {
            this.volume = volume;
        }
        public int getVolume()
        {
            return volume;
        }
        public void setLigada(bool ligada)
        {
            this.ligada = ligada;
        }
        public bool getLigada()
        {
            return ligada;
        }
    }
    public class ModeloTV
    {
        private string marca;
        private string modelo;

        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public string getMarca()
        {
            return marca;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return modelo;
        }
    }
    public interface ControleRemoto
    {
        void MudarCanal(int canal);

        void AumentaVolume(int taxa);

        void DiminuiVolume(int taxa);

        bool Ligar(bool ligada);

        bool Desligar(bool desligada);
 
    }

     

    class Program
    {
        static void Main(string[] args)
        {
            ModeloTV aparelho = new ModeloTV();
            Console.WriteLine("Digite o modelo da televisão: ");
            aparelho.setModelo(Console.ReadLine());
            Console.WriteLine("Digite a marca da televisão: ");
            aparelho.setMarca(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
