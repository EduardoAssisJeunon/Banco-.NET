using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaNomes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> lista = new List<string>();
        string n;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(nome.Text))
            {
                MessageBox.Show("Digite um nome!");
            } else
            {
                n = (nome.Text);
                lista.Add(n);
                listBox1.Items.Add(n);               
                nome.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char letra = Convert.ToChar(l.Text);
            foreach(string p in lista)
            {
                if (letra == p[0])
                {
                    listBox2.Items.Add(p);
                }
            }
        }
    }
}
