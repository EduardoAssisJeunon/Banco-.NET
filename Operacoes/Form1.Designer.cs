namespace Operacoes
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
            this.label3 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSoma = new System.Windows.Forms.Label();
            this.lbSubtracao = new System.Windows.Forms.Label();
            this.lbMultiplicacao = new System.Windows.Forms.Label();
            this.lbDivisao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo número:";
            // 
            // box1
            // 
            this.box1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.box1.Location = new System.Drawing.Point(16, 105);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(438, 26);
            this.box1.TabIndex = 3;
            this.box1.TextChanged += new System.EventHandler(this.box1_TextChanged);
            // 
            // box2
            // 
            this.box2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.box2.Location = new System.Drawing.Point(16, 180);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(438, 26);
            this.box2.TabIndex = 4;
            this.box2.TextChanged += new System.EventHandler(this.box2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(153, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSoma
            // 
            this.lbSoma.AutoSize = true;
            this.lbSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbSoma.Location = new System.Drawing.Point(16, 305);
            this.lbSoma.Name = "lbSoma";
            this.lbSoma.Size = new System.Drawing.Size(52, 18);
            this.lbSoma.TabIndex = 6;
            this.lbSoma.Text = "Soma:";
            // 
            // lbSubtracao
            // 
            this.lbSubtracao.AutoSize = true;
            this.lbSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbSubtracao.Location = new System.Drawing.Point(16, 334);
            this.lbSubtracao.Name = "lbSubtracao";
            this.lbSubtracao.Size = new System.Drawing.Size(80, 18);
            this.lbSubtracao.TabIndex = 7;
            this.lbSubtracao.Text = "Subtração:";
            // 
            // lbMultiplicacao
            // 
            this.lbMultiplicacao.AutoSize = true;
            this.lbMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbMultiplicacao.Location = new System.Drawing.Point(257, 334);
            this.lbMultiplicacao.Name = "lbMultiplicacao";
            this.lbMultiplicacao.Size = new System.Drawing.Size(98, 18);
            this.lbMultiplicacao.TabIndex = 8;
            this.lbMultiplicacao.Text = "Multiplicação:";
            // 
            // lbDivisao
            // 
            this.lbDivisao.AutoSize = true;
            this.lbDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbDivisao.Location = new System.Drawing.Point(257, 305);
            this.lbDivisao.Name = "lbDivisao";
            this.lbDivisao.Size = new System.Drawing.Size(61, 18);
            this.lbDivisao.TabIndex = 9;
            this.lbDivisao.Text = "Divisão:";
            this.lbDivisao.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 400);
            this.Controls.Add(this.lbDivisao);
            this.Controls.Add(this.lbMultiplicacao);
            this.Controls.Add(this.lbSubtracao);
            this.Controls.Add(this.lbSoma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSoma;
        private System.Windows.Forms.Label lbSubtracao;
        private System.Windows.Forms.Label lbMultiplicacao;
        private System.Windows.Forms.Label lbDivisao;
    }
}

