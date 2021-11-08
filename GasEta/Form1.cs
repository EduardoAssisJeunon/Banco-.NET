using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasEta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gas.Text) && !string.IsNullOrEmpty(eta.Text))
            {
                double eta, gas;
                eta = Convert.ToDouble(this.eta.Text);
                gas = Convert.ToDouble(this.gas.Text);
                gas = gas * 0.7;
                if (eta >= gas)
                {
                    MessageBox.Show("A gasolina está compensando mais do que o etanol.");
                }
                else
                {
                    MessageBox.Show("O etanol está compensando mais do que a gasolina.");
                }
            }
            else
            {
                MessageBox.Show("OS campos estão nulos, coloque os valores.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gas_TextChanged(object sender, EventArgs e)
        {

        }

        private void eta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
