using System;

namespace Exercicio_dia_5 

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor de custo: ");
            float x = float.Parse(Console.ReadLine());
            item_produto p1 = new item_produto(x, 450, 350, false, "Air Max 97", "Tênis", "Nike");
            Console.WriteLine("Modelo do produto: " + p1.getDescricao());
            Console.WriteLine("Tipo do produto: " + p1.getTipo());
            Console.WriteLine("Marca do produto: " + p1.getMarca());
            Console.WriteLine("Lucro sobre a venda do produto: R$" + p1.getLucro());
            Console.ReadKey();

            Console.WriteLine("Informe o valor de custo: ");
            float y = float.Parse(Console.ReadLine());
            item_produto p2 = new item_produto(x, 1200, 600, true, "Air Force One", "Tênis", "Nike");
            Console.WriteLine("Modelo do produto: " + p2.getDescricao());
            Console.WriteLine("Tipo do produto: " + p2.getTipo());
            Console.WriteLine("Marca do produto: " + p2.getMarca());
            Console.WriteLine("Lucro sobre a venda do produto: R$" + p2.getLucro());
            Console.ReadKey();
        }

        class Produto
        {
            private string descricao;
            private string tipo;
            private string marca;


            public Produto(string descricao, string tipo, string marca)
            {
                this.descricao = descricao;
                this.tipo = tipo;
                this.marca = marca;
            }
            public void setDescricao(string d)
            {
                descricao = d;
            }
            public string getDescricao()
            {
                return descricao;
            }

            public void setTipo(string t)
            {
                tipo = t;
            }
            public string getTipo()
            {
                return tipo;
            }

            public void setMarca(string m)
            {
                marca = m;
            }
            public string getMarca()
            {
                return marca;
            }
        }
        class item_produto : Produto
        {
            private float preco_custo;
            private float preco_venda;
            private float lucro;
            private bool vendido = false;



            public item_produto(float preco_custo, float preco_venda, float lucro, bool vendido, string descricao, string tipo, string marca) : base(descricao, tipo, marca)
            {
                this.preco_custo = preco_custo;
                this.preco_venda = preco_venda;
                this.lucro = lucro;
                this.vendido = vendido;
            }


            public void setPrecoCusto(float pc)
            {
                preco_custo = pc;
            }
            public float getPrecoCusto()
            {
                return preco_custo;
            }

            public void SetPrecoVenda(float pv)
            {
                preco_venda = pv;
            }
            public float GetPrecoVenda()
            {
                return preco_venda;
            }

            public void setLucro(float mg)
            {
                lucro = mg;
            }
            public float getLucro()
            {
                return lucro - preco_custo;
            }

            public void setVendido(bool v)
            {
                vendido = v;
            }
            public bool GetVendido()
            {
                return vendido;
            }

            public float CalcularLucro()
            {
                return preco_venda - preco_custo;
            }

            public float CalcularMargemLucroPorcentagem()
            {
                return ((preco_venda * 100) / preco_custo) - 100; ;
            }

        }
    }
}
