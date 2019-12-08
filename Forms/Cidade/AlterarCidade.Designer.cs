namespace LaravelClient.Forms.Cidade
{
    partial class AlterarCultura
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
            this.BtnSalvarAlterarCidade = new System.Windows.Forms.Button();
            this.BtnVoltarAlterarCidade = new System.Windows.Forms.Button();
            this.TxtBoxAlterarCep = new System.Windows.Forms.TextBox();
            this.TxtBoxAlterarCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalvarAlterarCidade
            // 
            this.BtnSalvarAlterarCidade.Location = new System.Drawing.Point(12, 179);
            this.BtnSalvarAlterarCidade.Name = "BtnSalvarAlterarCidade";
            this.BtnSalvarAlterarCidade.Size = new System.Drawing.Size(133, 23);
            this.BtnSalvarAlterarCidade.TabIndex = 0;
            this.BtnSalvarAlterarCidade.Text = "Salvar";
            this.BtnSalvarAlterarCidade.UseVisualStyleBackColor = true;
            this.BtnSalvarAlterarCidade.Click += new System.EventHandler(this.BtnSalvarAlterarCidade_Click);
            // 
            // BtnVoltarAlterarCidade
            // 
            this.BtnVoltarAlterarCidade.Location = new System.Drawing.Point(194, 179);
            this.BtnVoltarAlterarCidade.Name = "BtnVoltarAlterarCidade";
            this.BtnVoltarAlterarCidade.Size = new System.Drawing.Size(133, 23);
            this.BtnVoltarAlterarCidade.TabIndex = 1;
            this.BtnVoltarAlterarCidade.Text = "Voltar";
            this.BtnVoltarAlterarCidade.UseVisualStyleBackColor = true;
            this.BtnVoltarAlterarCidade.Click += new System.EventHandler(this.BtnVoltarAlterarCidade_Click);
            // 
            // TxtBoxAlterarCep
            // 
            this.TxtBoxAlterarCep.Location = new System.Drawing.Point(12, 115);
            this.TxtBoxAlterarCep.MaxLength = 8;
            this.TxtBoxAlterarCep.Name = "TxtBoxAlterarCep";
            this.TxtBoxAlterarCep.Size = new System.Drawing.Size(133, 20);
            this.TxtBoxAlterarCep.TabIndex = 2;
            // 
            // TxtBoxAlterarCidade
            // 
            this.TxtBoxAlterarCidade.Location = new System.Drawing.Point(12, 67);
            this.TxtBoxAlterarCidade.Name = "TxtBoxAlterarCidade";
            this.TxtBoxAlterarCidade.Size = new System.Drawing.Size(315, 20);
            this.TxtBoxAlterarCidade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CEP";
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.Location = new System.Drawing.Point(12, 28);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.ReadOnly = true;
            this.TxtBoxId.Size = new System.Drawing.Size(37, 20);
            this.TxtBoxId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // AlterarCultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxAlterarCidade);
            this.Controls.Add(this.TxtBoxAlterarCep);
            this.Controls.Add(this.BtnVoltarAlterarCidade);
            this.Controls.Add(this.BtnSalvarAlterarCidade);
            this.Name = "AlterarCultura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita > Alterar > Cidade";
            this.Load += new System.EventHandler(this.AlterarCidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvarAlterarCidade;
        private System.Windows.Forms.Button BtnVoltarAlterarCidade;
        private System.Windows.Forms.TextBox TxtBoxAlterarCep;
        private System.Windows.Forms.TextBox TxtBoxAlterarCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxId;
        private System.Windows.Forms.Label label3;
    }
}