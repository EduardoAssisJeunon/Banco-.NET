namespace Tabuada_For_While
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
            this.n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcWhile = new System.Windows.Forms.Button();
            this.calcFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n
            // 
            this.n.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(23, 90);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(299, 29);
            this.n.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número:";
            // 
            // calcWhile
            // 
            this.calcWhile.Location = new System.Drawing.Point(23, 143);
            this.calcWhile.Name = "calcWhile";
            this.calcWhile.Size = new System.Drawing.Size(299, 23);
            this.calcWhile.TabIndex = 2;
            this.calcWhile.Text = "Calcular Tabuada While";
            this.calcWhile.UseVisualStyleBackColor = true;
            this.calcWhile.Click += new System.EventHandler(this.calcWhile_Click);
            // 
            // calcFor
            // 
            this.calcFor.Location = new System.Drawing.Point(23, 191);
            this.calcFor.Name = "calcFor";
            this.calcFor.Size = new System.Drawing.Size(299, 23);
            this.calcFor.TabIndex = 3;
            this.calcFor.Text = "Calcular Tabuada For";
            this.calcFor.UseVisualStyleBackColor = true;
            this.calcFor.Click += new System.EventHandler(this.calcFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcFor);
            this.Controls.Add(this.calcWhile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcWhile;
        private System.Windows.Forms.Button calcFor;
    }
}

