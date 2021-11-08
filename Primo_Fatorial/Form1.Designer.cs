namespace Primo_Fatorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.primo = new System.Windows.Forms.Button();
            this.fatorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de Cálculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite um número inteiro positivo: ";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(276, 103);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(141, 20);
            this.box1.TabIndex = 2;
            // 
            // primo
            // 
            this.primo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primo.Location = new System.Drawing.Point(41, 162);
            this.primo.Name = "primo";
            this.primo.Size = new System.Drawing.Size(131, 91);
            this.primo.TabIndex = 3;
            this.primo.Text = "Primo";
            this.primo.UseVisualStyleBackColor = true;
            this.primo.Click += new System.EventHandler(this.primo_Click);
            // 
            // fatorial
            // 
            this.fatorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatorial.Location = new System.Drawing.Point(240, 162);
            this.fatorial.Name = "fatorial";
            this.fatorial.Size = new System.Drawing.Size(131, 91);
            this.fatorial.TabIndex = 4;
            this.fatorial.Text = "Fatorial";
            this.fatorial.UseVisualStyleBackColor = true;
            this.fatorial.Click += new System.EventHandler(this.fatorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(435, 310);
            this.Controls.Add(this.fatorial);
            this.Controls.Add(this.primo);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Button primo;
        private System.Windows.Forms.Button fatorial;
    }
}

