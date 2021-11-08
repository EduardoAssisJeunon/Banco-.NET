using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> lista = new List<int>();
        int n, divisor = 0;
        private void numero_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int qtdPrimos = lista.Count;
            if (string.IsNullOrEmpty(numero.Text))
            {
                MessageBox.Show("Digite um número!");
            }
            else
            {              
                n = Convert.ToInt32(this.numero.Text);
                listBox1.Items.Add(n.ToString());
                int primos = listBox2.Items.Count;
                for (int p = 1; p <= n; p++)
                {
                    if (n % p == 0)
                    {
                        divisor++;
                    }                   
                }
                if (divisor == 2)
                {
                    listBox2.Items.Add(n);                                       
                    MessageBox.Show("O numero é primo");
                    lbPrimos.Text = ("Quantidade de números primos: " + primos);
                }
                else
                {
                    MessageBox.Show("O numero nao é primo");
                }
                numero.Text = "";
                
                divisor = 0;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
