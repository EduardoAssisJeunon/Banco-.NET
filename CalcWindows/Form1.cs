using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultado, numero1, numero2;
        
        private void calcula_Click(object sender, EventArgs e)
        {
            lbResult.Text = " " + resultado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbResult.Text = "1";
            double n1 = 1;
            n1 = Convert.ToDouble(this.n1.Text);

            if(resultado == 0)
            {
                numero1 = 1;

            } else if (numero2 == 0)
            {
                numero2 = 1;
            }
            
        }       

        private void n2_Click(object sender, EventArgs e)
        {
            lbResult.Text = "2";
            double n2 = 2;
            n2 = Convert.ToDouble(this.n2.Text);
            if (numero1 == 0)
            {
                numero1 = 2;
            }
            else if (numero2 == 0)
            {
                numero2 = 2;
            }
            
        }

        private void n3_Click(object sender, EventArgs e)
        {
            lbResult.Text = "3";
            double n3 = 3;
            n3 = Convert.ToDouble(this.n3.Text);
            if (numero1 == 0)
            {
                numero1 = 3;
            }
            else if (numero2 == 0)
            {
                numero2 = 3;
            }
            
        }

        private void n4_Click(object sender, EventArgs e)
        {
            lbResult.Text = "4";
            double n4 = 4;
            n4 = Convert.ToDouble(this.n4.Text);
            if (numero1 == 0)
            {
                numero1 = 4;
            }
            else if (numero2 == 0)
            {
                numero2 = 4;
            }
            
        }

        private void n5_Click(object sender, EventArgs e)
        {
            lbResult.Text = "5";
            double n5 = 5;
            n5 = Convert.ToDouble(this.n5.Text);
            if (numero1 == 0)
            {
                numero1 = 5;
            }
            else if (numero2 == 0)
            {
                numero2 = 5;
            }
            
        }

        private void n6_Click(object sender, EventArgs e)
        {
            lbResult.Text = "6";
            double n6 = 6;
            n6 = Convert.ToDouble(this.n6.Text);
            if (numero1 == 0)
            {
                numero1 = 6;
            }
            else if (numero2 == 0)
            {
                numero2 = 6;
            }
            
        }

        private void n7_Click(object sender, EventArgs e)
        {
            lbResult.Text = "7";
            double n7 = 7;
            n7 = Convert.ToDouble(this.n7.Text);
            if (numero1 == 0)
            {
                numero1 = 7;
            }
            else if(numero2 == 0)
            {
                numero2 = 7;
            }
            
        }

        private void n8_Click(object sender, EventArgs e)
        {
            lbResult.Text = "8";
            double n8 = 8;
            n8 = Convert.ToDouble(this.n8.Text);
            if (numero1 == 0)
            {
                numero1 = 8;
            }
            else if (numero2 == 0)
            {
                numero2 = 8;
            }
            
        }

        private void n9_Click(object sender, EventArgs e)
        {
            lbResult.Text = "9";
            double n9 = 9;
            n9 = Convert.ToDouble(this.n9.Text);
            if (numero1 == 0)
            {
                numero1 = 9;
            }
            else if(numero2 == 0)
            {
                numero2 = 9;
            }           
        }

        private void n0_Click(object sender, EventArgs e)
        {
            lbResult.Text = "0";
            double n0 = 0;
            n0 = Convert.ToDouble(this.n0.Text);
            
        }

        private void mais_Click(object sender, EventArgs e)
        {
            lbResult.Text = " + ";
            resultado = numero1 + numero2;
        }

        private void menos_Click(object sender, EventArgs e)
        {
            lbResult.Text = " - ";
            resultado = numero1 - numero2;           
        }

 

        private void multiplica_Click(object sender, EventArgs e)
        {
            lbResult.Text = " X ";
            resultado = numero1 * numero2;          
        }

        private void divide_Click(object sender, EventArgs e)
        {
            lbResult.Text = " / ";
            resultado = numero1 / numero2;           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            lbResult.Text = "0";
            resultado = 0;
            numero1 = 0;
            numero2 = 0;
        }
    }
}
