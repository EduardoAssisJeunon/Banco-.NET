using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int divisores = 0;
        private void primo_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(box1.Text))
            {
                MessageBox.Show("Digite um número!!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int numero = Convert.ToInt32(this.box1.Text);
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores == 2)
                {
                    MessageBox.Show("O número " + numero + " é primo!!!", "PRIMO");
                }
                else
                {
                    MessageBox.Show("O número " + numero + " não é primo!!!", "NÃO PRIMO");
                }
                box1.Text = "";
            }
        }

        private void fatorial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(box1.Text))
            {
                MessageBox.Show("Digite um número!!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                int numero = Convert.ToInt32(this.box1.Text);
            int fatorial;
            fatorial = numero;
            for (int i = numero - 1; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }
            MessageBox.Show("O fatorial do número " + numero + " é: " + fatorial, "Fatorial");
            box1.Text = "";
        } }
    
    }
}
