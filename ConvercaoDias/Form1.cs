using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvercaoDias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double box1, meses, semanas, ano;
            box1 = Convert.ToDouble(this.box1.Text);
            semanas = box1 / 7;
            meses = box1 / 30;
            ano = box1 / 365;
            
                MessageBox.Show("Ano(s) completo(s): " + ano + "; Mes(es) completo(s): " + meses + 
                    "; Semana(s) completa(s): " + semanas);
                    
        }
    }
}
