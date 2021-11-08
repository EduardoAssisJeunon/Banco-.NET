using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void box2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double box1, box2;
            box1 = Convert.ToDouble(this.box1.Text);
            box2 = Convert.ToDouble(this.box2.Text);
            lbSoma.Text = "Soma: " + (box1 + box2).ToString(); 
            lbSubtracao.Text = "Subtração: " + (box1 - box2).ToString();
            lbMultiplicacao.Text = "Multiplicação: " + (box1 * box2).ToString();
            lbDivisao.Text = "Divisão: " + (box1 / box2).ToString();
            MessageBox.Show("Calculos feitos!!!", "Calculado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
