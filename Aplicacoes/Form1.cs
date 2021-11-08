using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            box1 = null;
            box2 = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double box1, box2, soma;
            box1 = Convert.ToDouble(this.box1.Text);
            box2 = Convert.ToDouble(this.box2.Text);
            soma = box1 + box2;
            MessageBox.Show("A soma dos números é: " + soma, "Soma", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double box1, box2, divisao;
            box1 = Convert.ToDouble(this.box1.Text);
            box2 = Convert.ToDouble(this.box2.Text);
            divisao = box1 / box2;
            MessageBox.Show("A divisão dos números é: " + divisao, "Divisão", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            double box1, box2, multiplicacao;
            box1 = Convert.ToDouble(this.box1.Text);
            box2 = Convert.ToDouble(this.box2.Text);
            multiplicacao = box1 * box2;
            MessageBox.Show("A divisão dos números é: " + multiplicacao, "Divisão", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            double box1, box2, subtracao;
            box1 = Convert.ToDouble(this.box1.Text);
            box2 = Convert.ToDouble(this.box2.Text);
            subtracao = box1 - box2;
            MessageBox.Show("A divisão dos números é: " + subtracao, "Divisão", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
