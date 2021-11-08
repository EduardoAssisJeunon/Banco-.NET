using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double saldo, limit;
        private void button1_Click(object sender, EventArgs e)
        {
            double valor;
            valor = Convert.ToDouble(mov.Text);
            limit = Convert.ToDouble(limite.Text);
             
                if (valor > limit)
                {
                    MessageBox.Show("O seu limite não permite esse saque!", "ERRO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("O seu saque foi efetuado com sucesso!", "SAQUE", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    saldo = saldo - valor;
                    atualizaSaldo();
                }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor;
            valor = Convert.ToDouble(mov.Text);         
            saldo = saldo + valor;
            MessageBox.Show("O seu depósito foi efetuado com sucesso!", "DEPÓSITO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            atualizaSaldo();       
        }

        void atualizaSaldo()
        {
            lbRS.Text = "R$ " + saldo;
        }
        void atualizaLimite()
        {
            lbLimite.Text = "R$ " + limit;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaSaldo();
            
        }

        private void box1_TextChanged(object sender, EventArgs e)
        {
                       
        }

        private void limite_TextChanged(object sender, EventArgs e)
        {
            atualizaLimite();         
        }

        private void lim_Click(object sender, EventArgs e)
        {
            limit = Convert.ToDouble(limite.Text);
            if(limit > saldo)
            {
                MessageBox.Show("O seu saldo não suporta esse limite!", "ALTERAÇÃO", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("O seu limite foi alterado!", "ALTERAÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                atualizaLimite();
            }           
        }
    }
}
