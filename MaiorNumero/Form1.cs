using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double box1, box2, maior;
            box1 = Convert.ToDouble(this.box1.Text);
            box2 = Convert.ToDouble(this.box2.Text);

            /* if (box1 > box2)
            {
                MessageBox.Show("O primeiro número (" + box1 + ") é maior!", "RESULTADO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O segundo número (" + box2 + ") é maior!", "RESULTADO", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            */
            maior = (box1 > box2 ? box1 : box2);
            MessageBox.Show("O maior número é: " + maior);

        }

        private void box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void box2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
