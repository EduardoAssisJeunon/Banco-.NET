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

        public TV()
        {

        }
        public TV(int tamanho)
        {
            this.tamanho = tamanho;
        }
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
    public class ModeloTV : TV, ControleRemoto
    {
        private string marca;
        private string modelo;

        public ModeloTV()
        {

        }
        public ModeloTV(int tamanho) : base(tamanho)
        {

        }
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

        public void MudarCanal(int canal)
        {
            setCanal(canal);
        }
        public void AumentaVolume(int taxa)
        {
            setVolume(getVolume() + taxa);
        }
        public void DiminuiVolume(int taxa)
        {
            setVolume(getVolume() - taxa);
        } 
        public bool Ligar()
        {
            return true;
        }
        public bool Desligar()
        {
            return false;
        }
    }
    public interface ControleRemoto
    {
        public void MudarCanal(int canal);

        public void AumentaVolume(int taxa);

        public void DiminuiVolume(int taxa);

        public bool Ligar();

        public bool Desligar();

    }
  
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            ModeloTV[] modelo;
            modelo = new ModeloTV[10];
            bool achou;
            int o;
            do
            {
                Console.Clear();
                ModeloTV aparelho = new ModeloTV();
                Console.WriteLine("1: Cadastrar televisão: ");
                Console.WriteLine("2: Consultar TV por modelo: ");
                Console.WriteLine("3: Consultar TV por Marca: ");
                Console.WriteLine("4: Sair!");
                o = Convert.ToInt32(Console.ReadLine());

                if (o == 1)
                {
                    Console.Clear();                   
                    if (i < 10)
                    {
                        modelo[i] = new ModeloTV();
                        Console.WriteLine("Digite o tamanho da televisão: ");
                        modelo[i].setTamanho(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("Digite a marca da televisão: ");
                        modelo[i].setMarca(Console.ReadLine());

                        Console.WriteLine("Digite o modelo da televisão: ");
                        modelo[i].setModelo(Console.ReadLine());
                        i++;
                        Console.WriteLine("Tevelisão cadastrada!");
                    }
                    else
                    {
                        Console.WriteLine("Número máximo de Tv's cadastradas");
                    }
                }

                if (o == 2)
                {
                    achou = false;
                    Console.Clear();
                    Console.WriteLine("Digite o modelo da TV: ");
                    string resposta = Console.ReadLine();
                    for(int l = 0; l<modelo.Length; l++)
                    {
                        if (modelo[l] != null && resposta == modelo[l].getModelo())
                        {
                            
                            Console.WriteLine("TV " + (l + 1));
                            Console.WriteLine("Tamanho: " + modelo[l].getTamanho());
                            Console.WriteLine("Modelo: " + modelo[l].getModelo());
                            Console.WriteLine("Marca: " + modelo[l].getMarca());
                            Console.WriteLine(" - - - - - - - - - - - - - - - - - -");
                            achou = true;
                        }
                    } if (achou == false)
                    {
                        Console.WriteLine("Televisão não encontrada.");
                    }
                }

                if (o == 3)
                {
                    achou = false;
                    Console.Clear();
                    Console.WriteLine("Digite o marca da TV: ");
                    string resposta = Console.ReadLine();
                    for (int l = 0; l < modelo.Length; l++)
                    {
                        if (modelo[l] != null && resposta == modelo[l].getMarca())
                        {
                            Console.WriteLine("TV " + (l + 1));
                            Console.WriteLine("Tamanho: " + modelo[l].getTamanho());
                            Console.WriteLine("Modelo: " + modelo[l].getModelo());
                            Console.WriteLine("Marca: " + modelo[l].getMarca());
                            Console.WriteLine(" - - - - - - - - - - - - - - - - - -");
                            achou = true;
                        }
                    }if (achou == false)
                    {
                        Console.WriteLine("Televisão não encontrada!");
                    }
                }

                if (o == 4)
                {
                    Console.WriteLine("Isso é tudo pessoal");
                }
                Console.ReadKey();
            } while (o != 4);
            
        }
    }
}