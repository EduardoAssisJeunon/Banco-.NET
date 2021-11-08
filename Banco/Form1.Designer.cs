namespace Banco
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
            this.lbRS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mov = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLimite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.limite = new System.Windows.Forms.TextBox();
            this.lim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Controle de Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo: ";
            // 
            // lbRS
            // 
            this.lbRS.AutoSize = true;
            this.lbRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbRS.ForeColor = System.Drawing.Color.Green;
            this.lbRS.Location = new System.Drawing.Point(103, 75);
            this.lbRS.Name = "lbRS";
            this.lbRS.Size = new System.Drawing.Size(73, 24);
            this.lbRS.TabIndex = 2;
            this.lbRS.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor da Movimentação:";
            // 
            // mov
            // 
            this.mov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mov.Location = new System.Drawing.Point(253, 112);
            this.mov.Name = "mov";
            this.mov.Size = new System.Drawing.Size(175, 29);
            this.mov.TabIndex = 4;
            this.mov.TextChanged += new System.EventHandler(this.box1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "SACAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(253, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 59);
            this.button2.TabIndex = 6;
            this.button2.Text = "DEPOSITAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Limite: ";
            // 
            // lbLimite
            // 
            this.lbLimite.AutoSize = true;
            this.lbLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbLimite.Location = new System.Drawing.Point(103, 244);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(73, 24);
            this.lbLimite.TabIndex = 8;
            this.lbLimite.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Novo Limite:";
            // 
            // limite
            // 
            this.limite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.limite.Location = new System.Drawing.Point(144, 297);
            this.limite.Name = "limite";
            this.limite.Size = new System.Drawing.Size(130, 29);
            this.limite.TabIndex = 10;
            this.limite.TextChanged += new System.EventHandler(this.limite_TextChanged);
            // 
            // lim
            // 
            this.lim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lim.Location = new System.Drawing.Point(287, 267);
            this.lim.Name = "lim";
            this.lim.Size = new System.Drawing.Size(141, 59);
            this.lim.TabIndex = 11;
            this.lim.Text = "ALTERAR LIMITE";
            this.lim.UseVisualStyleBackColor = false;
            this.lim.Click += new System.EventHandler(this.lim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 398);
            this.Controls.Add(this.lim);
            this.Controls.Add(this.limite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbLimite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLimite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox limite;
        private System.Windows.Forms.Button lim;
    }
}

