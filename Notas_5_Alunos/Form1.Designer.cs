namespace Notas_5_Alunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a nota do aluno:";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(41, 61);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(172, 20);
            this.n.TabIndex = 1;
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(41, 129);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(172, 23);
            this.calc.TabIndex = 2;
            this.calc.Text = "Calcular Média ";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Visible = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // v
            // 
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(41, 100);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(172, 23);
            this.v.TabIndex = 3;
            this.v.Text = "Guardar Nota";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(41, 171);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(42, 13);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "Nota 1:";
            this.lb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(41, 184);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(42, 13);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Nota 2:";
            this.lb2.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(41, 197);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(42, 13);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "Nota 3:";
            this.lb3.Visible = false;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(41, 210);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(42, 13);
            this.lb4.TabIndex = 7;
            this.lb4.Text = "Nota 4:";
            this.lb4.Visible = false;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(41, 223);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(42, 13);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "Nota 5:";
            this.lb5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 287);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.v);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
    }
}

