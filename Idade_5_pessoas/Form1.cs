using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade_5_pessoas
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
        private void media_Click(object sender, EventArgs e)
        {
            m = (idade[0] + idade[1] + idade[2] + idade[3] + idade[4]) / 5;
            MessageBox.Show("A média das idades é de " + m + " // a maior idade é " + idadeMaior +
                " // a menor idade é " + idadeMenor,"DADOS");
        }

        int v=0;
        double i = 0, i2 = 0, idadeMaior, idadeMenor, m;      
        double[] idade = new double[5];
        private void b_Click(object sender, EventArgs e)
        {           
            if (v <= 4)
            {
                idade[v] = double.Parse(this.box1.Text);
                MessageBox.Show("Idade armazenada!");
                i = double.Parse(this.box1.Text);
                i2 = double.Parse(this.box1.Text);
                v++;               
                box1.Text = "";
                if (i > idadeMaior) {
                    idadeMaior = i;
                } 
                if (i2 < idadeMenor) 
                {                  
                    idadeMenor = i2;                    
                } 
                if (idade[0] != 0)
                {
                    lb1.Visible = true;
                    lb1.Text = "Primeira idade: " + idade[0];
                }
                if (idade[1] != 0)
                {
                    lb2.Visible = true;
                    lb2.Text = "Segunda idade: " + idade[1];
                }

                if (idade[2] != 0)
                {
                    lb3.Visible = true;
                    lb3.Text = "Terceira idade: " + idade[2];
                }
                if (idade[3] != 0)
                {
                    lb4.Visible = true;
                    lb4.Text = "Quarta idade: " + idade[3];
                }
                if (idade[4] != 0)
                {
                    lb5.Visible = true;
                    lb5.Text = "Última idade: " + idade[4];
                    lbmaior.Visible = true;
                    lbmenor.Visible = true;
                    lbmaior.Text = "MAIOR IDADE: " + idadeMaior;
                    lbmenor.Text = "MENOR IDADE: " + idadeMenor;
                    media.Visible = true;
                }                                                          
            }   else
            {
                MessageBox.Show("As 5 idades ja foram colocadas!");
            }
        }
    }
}
