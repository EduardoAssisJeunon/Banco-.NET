namespace Pagamentos
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
            this.calcDir = new System.Windows.Forms.Button();
            this.dir = new System.Windows.Forms.RadioButton();
            this.ger = new System.Windows.Forms.RadioButton();
            this.ven = new System.Windows.Forms.RadioButton();
            this.dev = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cargo = new System.Windows.Forms.Panel();
            this.valorBonus = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.valorHoras = new System.Windows.Forms.TextBox();
            this.valorVendas = new System.Windows.Forms.TextBox();
            this.lbH = new System.Windows.Forms.Label();
            this.lbV = new System.Windows.Forms.Label();
            this.calcGer = new System.Windows.Forms.Button();
            this.calcDev = new System.Windows.Forms.Button();
            this.calcVen = new System.Windows.Forms.Button();
            this.cargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcDir
            // 
            this.calcDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDir.Location = new System.Drawing.Point(55, 311);
            this.calcDir.Name = "calcDir";
            this.calcDir.Size = new System.Drawing.Size(292, 29);
            this.calcDir.TabIndex = 1;
            this.calcDir.Text = "Calcular Salário";
            this.calcDir.UseVisualStyleBackColor = true;
            this.calcDir.Visible = false;
            this.calcDir.Click += new System.EventHandler(this.calc_Click);
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir.Location = new System.Drawing.Point(8, 3);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(71, 22);
            this.dir.TabIndex = 2;
            this.dir.TabStop = true;
            this.dir.Text = "Diretor";
            this.dir.UseVisualStyleBackColor = true;
            // 
            // ger
            // 
            this.ger.AutoSize = true;
            this.ger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ger.Location = new System.Drawing.Point(10, 31);
            this.ger.Name = "ger";
            this.ger.Size = new System.Drawing.Size(79, 22);
            this.ger.TabIndex = 3;
            this.ger.TabStop = true;
            this.ger.Text = "Gerente";
            this.ger.UseVisualStyleBackColor = true;
            // 
            // ven
            // 
            this.ven.AutoSize = true;
            this.ven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ven.Location = new System.Drawing.Point(10, 87);
            this.ven.Name = "ven";
            this.ven.Size = new System.Drawing.Size(89, 22);
            this.ven.TabIndex = 4;
            this.ven.TabStop = true;
            this.ven.Text = "Vendedor";
            this.ven.UseVisualStyleBackColor = true;
            this.ven.CheckedChanged += new System.EventHandler(this.ven_CheckedChanged);
            // 
            // dev
            // 
            this.dev.AutoSize = true;
            this.dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev.Location = new System.Drawing.Point(10, 59);
            this.dev.Name = "dev";
            this.dev.Size = new System.Drawing.Size(125, 22);
            this.dev.TabIndex = 5;
            this.dev.TabStop = true;
            this.dev.Text = "Desenvolvedor";
            this.dev.UseVisualStyleBackColor = true;
            this.dev.CheckedChanged += new System.EventHandler(this.dev_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "João",
            "Cristiano",
            "Plínio",
            "Jobert"});
            this.comboBox1.Location = new System.Drawing.Point(55, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione seu nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecione seu cargo:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(262, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Carregar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cargo
            // 
            this.cargo.Controls.Add(this.dir);
            this.cargo.Controls.Add(this.ger);
            this.cargo.Controls.Add(this.dev);
            this.cargo.Controls.Add(this.ven);
            this.cargo.Location = new System.Drawing.Point(55, 105);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(177, 117);
            this.cargo.TabIndex = 10;
            this.cargo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // valorBonus
            // 
            this.valorBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorBonus.Location = new System.Drawing.Point(55, 266);
            this.valorBonus.Name = "valorBonus";
            this.valorBonus.Size = new System.Drawing.Size(288, 20);
            this.valorBonus.TabIndex = 11;
            this.valorBonus.Visible = false;
            this.valorBonus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(55, 247);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(173, 16);
            this.lbB.TabIndex = 12;
            this.lbB.Text = "Digite o valor do bonus:";
            this.lbB.Visible = false;
            // 
            // valorHoras
            // 
            this.valorHoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorHoras.Location = new System.Drawing.Point(55, 267);
            this.valorHoras.Name = "valorHoras";
            this.valorHoras.Size = new System.Drawing.Size(288, 20);
            this.valorHoras.TabIndex = 13;
            this.valorHoras.Visible = false;
            this.valorHoras.TextChanged += new System.EventHandler(this.valorHoras_TextChanged);
            // 
            // valorVendas
            // 
            this.valorVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorVendas.Location = new System.Drawing.Point(54, 267);
            this.valorVendas.Name = "valorVendas";
            this.valorVendas.Size = new System.Drawing.Size(288, 20);
            this.valorVendas.TabIndex = 14;
            this.valorVendas.Visible = false;
            this.valorVendas.TextChanged += new System.EventHandler(this.valorVendas_TextChanged);
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH.Location = new System.Drawing.Point(55, 248);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(277, 15);
            this.lbH.TabIndex = 15;
            this.lbH.Text = "Digite a quantidade de horas trabalhadas:";
            this.lbH.Visible = false;
            // 
            // lbV
            // 
            this.lbV.AutoSize = true;
            this.lbV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV.Location = new System.Drawing.Point(55, 248);
            this.lbV.Name = "lbV";
            this.lbV.Size = new System.Drawing.Size(190, 16);
            this.lbV.TabIndex = 16;
            this.lbV.Text = "Digite o valor das vendas:";
            this.lbV.Visible = false;
            // 
            // calcGer
            // 
            this.calcGer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcGer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcGer.Location = new System.Drawing.Point(54, 311);
            this.calcGer.Name = "calcGer";
            this.calcGer.Size = new System.Drawing.Size(292, 29);
            this.calcGer.TabIndex = 17;
            this.calcGer.Text = "Calcular Salário";
            this.calcGer.UseVisualStyleBackColor = true;
            this.calcGer.Visible = false;
            this.calcGer.Click += new System.EventHandler(this.calcGer_Click);
            // 
            // calcDev
            // 
            this.calcDev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDev.Location = new System.Drawing.Point(55, 311);
            this.calcDev.Name = "calcDev";
            this.calcDev.Size = new System.Drawing.Size(292, 29);
            this.calcDev.TabIndex = 18;
            this.calcDev.Text = "Calcular Salário";
            this.calcDev.UseVisualStyleBackColor = true;
            this.calcDev.Visible = false;
            this.calcDev.Click += new System.EventHandler(this.calcDev_Click);
            // 
            // calcVen
            // 
            this.calcVen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcVen.Location = new System.Drawing.Point(55, 311);
            this.calcVen.Name = "calcVen";
            this.calcVen.Size = new System.Drawing.Size(292, 29);
            this.calcVen.TabIndex = 19;
            this.calcVen.Text = "Calcular Salário";
            this.calcVen.UseVisualStyleBackColor = true;
            this.calcVen.Visible = false;
            this.calcVen.Click += new System.EventHandler(this.calcVen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 368);
            this.Controls.Add(this.calcVen);
            this.Controls.Add(this.calcDev);
            this.Controls.Add(this.calcGer);
            this.Controls.Add(this.lbV);
            this.Controls.Add(this.lbH);
            this.Controls.Add(this.valorVendas);
            this.Controls.Add(this.valorHoras);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.valorBonus);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.calcDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cargo.ResumeLayout(false);
            this.cargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcDir;
        private System.Windows.Forms.RadioButton dir;
        private System.Windows.Forms.RadioButton ger;
        private System.Windows.Forms.RadioButton ven;
        private System.Windows.Forms.RadioButton dev;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel cargo;
        private System.Windows.Forms.TextBox valorBonus;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox valorHoras;
        private System.Windows.Forms.TextBox valorVendas;
        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.Label lbV;
        private System.Windows.Forms.Button calcGer;
        private System.Windows.Forms.Button calcDev;
        private System.Windows.Forms.Button calcVen;
    }
}

