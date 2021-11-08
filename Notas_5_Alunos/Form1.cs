using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_5_Alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n2;
        int i = 0;
        double[] nota = new double[5];
        private void calc_Click(object sender, EventArgs e)
        {
           if (i < 4)
            {
                MessageBox.Show("Coloque outra nota!");                
            } else
            n2 = (nota[0] + nota[1] + nota[2] + nota[3] + nota[4])/ 5;
            MessageBox.Show("A média das notas é de: " + n2);
        }

        private void v_Click(object sender, EventArgs e)
        {
            if (i <= 4)
            {
                
                nota[i] = double.Parse(this.n.Text);

                MessageBox.Show("Nota armazenada no vetor!");
                if (nota[0] != 0)
                {
                    lb1.Visible = true;
                    lb1.Text = ("Nota 1 = " + nota[0]);
                }
                if (nota[1] != 0)
                {
                    lb2.Visible = true;
                    lb2.Text = ("Nota 2 = " + nota[1]);
                }
                if (nota[2] != 0)
                {
                    lb3.Visible = true;
                    lb3.Text = ("Nota 3 = " + nota[2]);
                }
                if (nota[3] != 0)
                {
                    lb4.Visible = true;
                    lb4.Text = ("Nota 4 = " + nota[3]);
                }
                if (nota[4] != 0)
                {
                    lb5.Visible = true;
                    lb5.Text = ("Nota 5 = " + nota[4]);
                }
                calc.Visible = true;
                i++;
                MessageBox.Show("Quantidade de notas armazenadas: " + i);
            } else {
                MessageBox.Show("As 5 notas ja foram adicionadas!!");
                    }
        }
    }
}
