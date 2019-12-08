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
    public partial class CriarProduto : Form
    {
        public CriarProduto()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            String marca = textBoxMarca.Text;

            Model.Produto produto = new Model.Produto();
            produto.descricao = descricao;
            produto.marca = marca;

            string info = await ProdutoServices.PostProduto(produto);
            if (info == "Created")
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Produto!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
