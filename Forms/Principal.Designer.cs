namespace LaravelClient.Forms
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCidade = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.btnPraga = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCultura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCidade
            // 
            this.BtnCidade.Location = new System.Drawing.Point(116, 36);
            this.BtnCidade.Name = "BtnCidade";
            this.BtnCidade.Size = new System.Drawing.Size(75, 23);
            this.BtnCidade.TabIndex = 0;
            this.BtnCidade.Text = "Cidade";
            this.BtnCidade.UseVisualStyleBackColor = true;
            this.BtnCidade.Click += new System.EventHandler(this.BtnCidade_Click);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(225, 36);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnPessoa.TabIndex = 1;
            this.btnPessoa.Text = "Pessoa";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // btnPraga
            // 
            this.btnPraga.Location = new System.Drawing.Point(116, 68);
            this.btnPraga.Name = "btnPraga";
            this.btnPraga.Size = new System.Drawing.Size(75, 23);
            this.btnPraga.TabIndex = 2;
            this.btnPraga.Text = "Praga";
            this.btnPraga.UseVisualStyleBackColor = true;
            this.btnPraga.Click += new System.EventHandler(this.btnPraga_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(225, 71);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(75, 20);
            this.btnProduto.TabIndex = 3;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnCultura
            // 
            this.btnCultura.Location = new System.Drawing.Point(116, 97);
            this.btnCultura.Name = "btnCultura";
            this.btnCultura.Size = new System.Drawing.Size(75, 23);
            this.btnCultura.TabIndex = 4;
            this.btnCultura.Text = "Cultura";
            this.btnCultura.UseVisualStyleBackColor = true;
            this.btnCultura.Click += new System.EventHandler(this.btnCultura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "__________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Receitas";
            // 
            // btnEmitir
            // 
            this.btnEmitir.Location = new System.Drawing.Point(116, 179);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(184, 23);
            this.btnEmitir.TabIndex = 8;
            this.btnEmitir.Text = "Emissão";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 271);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCultura);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnPraga);
            this.Controls.Add(this.btnPessoa);
            this.Controls.Add(this.BtnCidade);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita > Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCidade;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.Button btnPraga;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnCultura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEmitir;
    }
}