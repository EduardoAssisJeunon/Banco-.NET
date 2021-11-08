using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade_pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void i_TextChanged(object sender, EventArgs e)
        {

        }
        List<int> lista = new List<int>();
        int idade, IDMenor = 120, IDMaior, quantidade;
        double media, soma;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(i.Text))
            {
                MessageBox.Show("Digite uma idade!!!");
            }
            else
            {               
                idade = Convert.ToInt32(this.i.Text);
                lista.Add(idade);
                listBox1.Items.Add(idade);
                quantidade++;
                soma = idade + soma;
                    if (idade > IDMaior)
                    {
                        IDMaior = idade;
                        lbmaior.Text = ("Maior idade: " + IDMaior);
                    }
                
                
                 if (idade < IDMenor)
                 {
                     IDMenor = idade;
                     lbmenor.Text = ("Menor idade: " + IDMenor);
                 }                   
                    media = soma / quantidade;
                    i.Text = "";                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A média das idades é de " + media);
            
        }
    }
}
