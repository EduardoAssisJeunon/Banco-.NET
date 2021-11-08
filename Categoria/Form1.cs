using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idade.Text) && !string.IsNullOrEmpty(nome.Text))
            {
                string nome;
                nome = Convert.ToString(this.nome.Text);
                double idade;
                idade = Convert.ToDouble(this.idade.Text);
                if (idade < 14) {
                    MessageBox.Show("A categoria do(a) " + nome + " é MIRIM");
                }else if(idade == 14 || idade == 15)
                {
                    MessageBox.Show("A categoria do(a) " + nome + " é INFALTIL");
                }else if(idade == 16 || idade == 17)
                {
                    MessageBox.Show("A categoria do(a) " + nome + "é JUVENIL");
                }
                else if (idade == 18 || idade == 19 ||  idade == 20)
                {
                    MessageBox.Show("A categoria do(a) " + nome + " é JUNIORES");
                }
                else
                {
                    MessageBox.Show("A categoria do(a) " + nome + "  é PROFISSIONAL");
                }
            }
            else {
                MessageBox.Show("Digite os dados do(a) atleta!!", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
