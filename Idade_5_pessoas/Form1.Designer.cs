namespace Idade_5_pessoas
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
            this.b = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lbmaior = new System.Windows.Forms.Label();
            this.lbmenor = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a idade:";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(41, 51);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(189, 20);
            this.box1.TabIndex = 1;
            this.box1.TextChanged += new System.EventHandler(this.box1_TextChanged);
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(41, 94);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(189, 23);
            this.b.TabIndex = 2;
            this.b.Text = "Armazenar idade";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 160);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(76, 13);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Primeira idade:";
            this.lb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 186);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(82, 13);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "Segunda idade:";
            this.lb2.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(12, 209);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(78, 13);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "Terceira idade:";
            this.lb3.Visible = false;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(12, 234);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(71, 13);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Quarta idade:";
            this.lb4.Visible = false;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(12, 258);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(68, 13);
            this.lb5.TabIndex = 7;
            this.lb5.Text = "Última idade:";
            this.lb5.Visible = false;
            // 
            // lbmaior
            // 
            this.lbmaior.AutoSize = true;
            this.lbmaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmaior.Location = new System.Drawing.Point(142, 160);
            this.lbmaior.Name = "lbmaior";
            this.lbmaior.Size = new System.Drawing.Size(110, 16);
            this.lbmaior.TabIndex = 8;
            this.lbmaior.Text = "MAIOR IDADE:";
            this.lbmaior.Visible = false;
            // 
            // lbmenor
            // 
            this.lbmenor.AutoSize = true;
            this.lbmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmenor.Location = new System.Drawing.Point(142, 186);
            this.lbmenor.Name = "lbmenor";
            this.lbmenor.Size = new System.Drawing.Size(117, 16);
            this.lbmenor.TabIndex = 9;
            this.lbmenor.Text = "MENOR IDADE:";
            this.lbmenor.Visible = false;
            // 
            // media
            // 
            this.media.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media.Location = new System.Drawing.Point(41, 123);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(189, 23);
            this.media.TabIndex = 10;
            this.media.Text = "Calcular Média ";
            this.media.UseVisualStyleBackColor = true;
            this.media.Visible = false;
            this.media.Click += new System.EventHandler(this.media_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 294);
            this.Controls.Add(this.media);
            this.Controls.Add(this.lbmenor);
            this.Controls.Add(this.lbmaior);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.b);
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
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lbmaior;
        private System.Windows.Forms.Label lbmenor;
        private System.Windows.Forms.Button media;
    }
}

