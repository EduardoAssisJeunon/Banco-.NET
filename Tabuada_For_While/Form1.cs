using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada_For_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n2, n3;

        private void calcFor_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(this.n.Text);
            for (n2 = 0; n2 <= 9; n2++)
            {
                n3 = n * n2;
                MessageBox.Show("" + n3, n + "*" + n2, MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

        private void calcWhile_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(this.n.Text);
            
            do
            {
                n3 = n * n2;
                MessageBox.Show("" + n3, n + "*" + n2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                n2++;
            } while (n2 <= 9);
        }
    }
}
