namespace Aplicacoes
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Soma = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.Subtracao = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite dois números para fazer o calculo:";
            // 
            // box1
            // 
            this.box1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box1.BackColor = System.Drawing.SystemColors.MenuText;
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.box1.ForeColor = System.Drawing.Color.Red;
            this.box1.Location = new System.Drawing.Point(13, 49);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(402, 30);
            this.box1.TabIndex = 1;
            // 
            // box2
            // 
            this.box2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box2.BackColor = System.Drawing.SystemColors.InfoText;
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.box2.ForeColor = System.Drawing.Color.Red;
            this.box2.Location = new System.Drawing.Point(13, 137);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(402, 30);
            this.box2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(215, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // Soma
            // 
            this.Soma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Soma.Location = new System.Drawing.Point(13, 189);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(90, 62);
            this.Soma.TabIndex = 4;
            this.Soma.Text = "+";
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // Divisao
            // 
            this.Divisao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Divisao.Location = new System.Drawing.Point(114, 189);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(96, 62);
            this.Divisao.TabIndex = 5;
            this.Divisao.Text = "%";
            this.Divisao.UseVisualStyleBackColor = false;
            this.Divisao.Click += new System.EventHandler(this.button2_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Multiplicacao.Location = new System.Drawing.Point(215, 189);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(96, 62);
            this.Multiplicacao.TabIndex = 6;
            this.Multiplicacao.Text = "X";
            this.Multiplicacao.UseVisualStyleBackColor = false;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // Subtracao
            // 
            this.Subtracao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Subtracao.Location = new System.Drawing.Point(316, 189);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(96, 62);
            this.Subtracao.TabIndex = 7;
            this.Subtracao.Text = "-";
            this.Subtracao.UseVisualStyleBackColor = false;
            this.Subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(13, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(402, 54);
            this.button5.TabIndex = 8;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 391);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Subtracao);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.Button Subtracao;
        private System.Windows.Forms.Button button5;
    }
}

