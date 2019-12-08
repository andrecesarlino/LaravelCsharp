using LaravelClient.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaravelClient.Forms.Produto
{
    public partial class AlterarProduto : Form
    {
        Model.Produto produto = null;
        public AlterarProduto(Model.Produto produto)
        {
            this.produto = produto;
            InitializeComponent();
            textBoxID.Text = produto.id.ToString();
            textBoxDescricao.Text = produto.descricao;
            textBoxMarca.Text = produto.marca;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            produto.descricao = textBoxDescricao.Text;
            produto.marca = textBoxMarca.Text;

            string info = await ProdutoServices.PutProduto(produto);
            if (info == "OK")
            {
                MessageBox.Show("Produto alterado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar Produto!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
