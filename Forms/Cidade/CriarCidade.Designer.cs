namespace LaravelClient.Forms.Cidade
{
    partial class CriarCidade
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
            this.BtnCriarSalvarCidade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNomeCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxCepCidade = new System.Windows.Forms.TextBox();
            this.BtnVoltarCriarCidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCriarSalvarCidade
            // 
            this.BtnCriarSalvarCidade.Location = new System.Drawing.Point(12, 179);
            this.BtnCriarSalvarCidade.Name = "BtnCriarSalvarCidade";
            this.BtnCriarSalvarCidade.Size = new System.Drawing.Size(133, 23);
            this.BtnCriarSalvarCidade.TabIndex = 0;
            this.BtnCriarSalvarCidade.Text = "Salvar";
            this.BtnCriarSalvarCidade.UseVisualStyleBackColor = true;
            this.BtnCriarSalvarCidade.Click += new System.EventHandler(this.BtnCriarSalvarCidade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da cidade:";
            // 
            // TxtBoxNomeCidade
            // 
            this.TxtBoxNomeCidade.Location = new System.Drawing.Point(12, 40);
            this.TxtBoxNomeCidade.Name = "TxtBoxNomeCidade";
            this.TxtBoxNomeCidade.Size = new System.Drawing.Size(325, 20);
            this.TxtBoxNomeCidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP:";
            // 
            // TxtBoxCepCidade
            // 
            this.TxtBoxCepCidade.Location = new System.Drawing.Point(12, 109);
            this.TxtBoxCepCidade.MaxLength = 8;
            this.TxtBoxCepCidade.Name = "TxtBoxCepCidade";
            this.TxtBoxCepCidade.Size = new System.Drawing.Size(155, 20);
            this.TxtBoxCepCidade.TabIndex = 4;
            // 
            // BtnVoltarCriarCidade
            // 
            this.BtnVoltarCriarCidade.Location = new System.Drawing.Point(204, 179);
            this.BtnVoltarCriarCidade.Name = "BtnVoltarCriarCidade";
            this.BtnVoltarCriarCidade.Size = new System.Drawing.Size(133, 23);
            this.BtnVoltarCriarCidade.TabIndex = 5;
            this.BtnVoltarCriarCidade.Text = "Voltar";
            this.BtnVoltarCriarCidade.UseVisualStyleBackColor = true;
            this.BtnVoltarCriarCidade.Click += new System.EventHandler(this.BtnVoltarCriarCidade_Click);
            // 
            // CriarCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 243);
            this.Controls.Add(this.BtnVoltarCriarCidade);
            this.Controls.Add(this.TxtBoxCepCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxNomeCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCriarSalvarCidade);
            this.Name = "CriarCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita >Criar > Cidade";
            this.Load += new System.EventHandler(this.CriarCidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCriarSalvarCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxNomeCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxCepCidade;
        private System.Windows.Forms.Button BtnVoltarCriarCidade;
    }
}