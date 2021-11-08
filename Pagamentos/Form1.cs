using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double salario;
        
        private void calc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O salário do funcionario com nome de " + comboBox1.SelectedItem.ToString() +
               " no cargo de Diretor é igual a: R$ " + salario,
               "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dir.Checked)
            {
                salario = 10000;
                MessageBox.Show("O salário ja pode ser calculado");
                calcDir.Visible = true;
                calcGer.Visible = false;
                calcDev.Visible = false;
                calcVen.Visible = false;
            }
             if(ger.Checked) {
                valorBonus.Visible = true;
                valorHoras.Visible = false;
                valorVendas.Visible = false;
                calcGer.Visible = true;
                calcDir.Visible = false;
                calcDev.Visible = false;
                calcVen.Visible = false;
                lbB.Visible = true;
                lbH.Visible = false;
                lbV.Visible = false;
            } 
             if(dev.Checked)
            {
                valorHoras.Visible = true;
                valorBonus.Visible = false;
                valorVendas.Visible = false;
                calcDev.Visible = true;
                calcDir.Visible = false;
                calcGer.Visible = false;
                calcVen.Visible = false;
                lbB.Visible = false;
                lbH.Visible = true;
                lbV.Visible = false;
            } 
             if(ven.Checked)
            {
                valorVendas.Visible = true;
                valorBonus.Visible = false;
                valorHoras.Visible = false;
                calcVen.Visible = true;
                calcDir.Visible = false;
                calcGer.Visible = false;
                calcDev.Visible = false;
                lbB.Visible = false;
                lbH.Visible = false;
                lbV.Visible = true;
            }
            else
            {
                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double bonus = Convert.ToDouble(valorBonus.Text);
            salario = 6000 + bonus;
        }
        private void valorHoras_TextChanged(object sender, EventArgs e)
        {
            double horas = Convert.ToDouble(valorHoras.Text);
            salario = 50 * horas;
        }
        private void valorVendas_TextChanged(object sender, EventArgs e)
        {
            double vendas = Convert.ToDouble(valorVendas.Text);
            vendas = vendas * 0.1;
            salario = 1000 + vendas;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ven_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dev_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcGer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O salário do funcionario com nome de " + comboBox1.SelectedItem.ToString() +
                " no cargo de gerente é igual a: R$ " + salario + " ! (R$ 6000,00 de salário + bonus de " + valorBonus.Text + ")", 
                "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calcVen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O salário do funcionario com nome de " + comboBox1.SelectedItem.ToString() +
                " no cargo de vendedor é igual a: R$ " + salario + " ! (R$ 1000,00 de salário + vendas de " + valorVendas.Text + ")",
                "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calcDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O salário do funcionario com nome de " + comboBox1.SelectedItem.ToString() +
                " no cargo de desenvolvedor é igual a: R$ " + salario + 
                " ! (R$ 50,00 por hora, e a quantidade de horas trabalhadas foram de:  " + valorHoras.Text + ")",
                "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
