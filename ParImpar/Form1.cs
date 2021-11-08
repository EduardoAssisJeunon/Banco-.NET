using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void n_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double numero;
            numero = Convert.ToDouble(this.numero.Text);
            if (numero % 2 == 0)
            {
                MessageBox.Show("O número é par!");
            }
            else
            {
                MessageBox.Show("O número é impar!");
            }
        }
    }
}
