using System;

namespace Exercicio_Prof_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            aluno aluno1 = new aluno("Duardo", "020.316.156-45");
            tcc tcc1 = new tcc("Sistemas de Informação", "4 anos", "Tecnologia de Informação", "Duardo", "625489");
            Console.WriteLine(tcc1.getNome());
            Console.ReadKey();
        }

        class aluno
        {
            private string nome_aluno;
            private string cpf;

            public aluno(string nome_aluno, string cpf)
            {
                this.nome_aluno = nome_aluno;
                this.cpf = cpf;
            }
            public void setNome(string n)
            {
                nome_aluno = n;
            }
            public string getNome()
            {
                return nome_aluno;
            }

            public void setCpf(string c)
            {
                cpf = c;
            }
            public string getCpf()
            {
                return cpf;
            }
        }

        class professor
        {
            private string nome;
            private int cpf;
            private string area;

            public professor(string nome, int cpf, string area)
            {
                this.nome = nome;
                this.cpf = cpf;
                this.area = area;
            }

            public void setNome(string n)
            {
                nome = n;
            }
            public string getNome()
            {
                return nome;
            }

            public void setCpf(int c)
            {
                cpf = c;
            }
            public int getCpf()
            {
                return cpf;
            }

            public void setArea(string a)
            {
                area = a;
            }
            public string getArea()
            {
                return area;
            }
        }

        class tcc : aluno
        {
            private string titulo, resumo, area;

            public tcc(string titulo, string resumo, string area, string nome_aluno, string cpf) : base(nome_aluno, cpf)
            {
                this.titulo = titulo;
                this.resumo = resumo;
                this.area = area;
            }
            public void setTitulo(string t)
            {
                titulo = t;
            }
            public string getTitulo()
            {
                return titulo;
            }

            public void setResumo(string r)
            {
                resumo = r;
            }
            public string getResumo()
            {
                return resumo;
            }

            public void setArea(string a)
            {
                area = a;
            }
            public string getArea()
            {
                return area;
            }
        }

    }
}