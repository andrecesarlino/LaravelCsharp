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
    public partial class PrincipalProduto : Form
    {
        public PrincipalProduto()
        {
            InitializeComponent();
            Atualizatela();
        }
        private async void Atualizatela()
        {
            List<Model.Produto> lista = await ProdutoServices.GetProduto();
            dataGridProduto.DataSource = lista;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Produto.CriarProduto form = new Produto.CriarProduto();
            form.ShowDialog();
            Atualizatela();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Model.Produto produto = (Model.Produto)dataGridProduto.SelectedRows[0].DataBoundItem;
            Produto.AlterarProduto form = new Produto.AlterarProduto(produto);
            form.ShowDialog();
            Atualizatela();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            Model.Produto produto = (Model.Produto)dataGridProduto.SelectedRows[0].DataBoundItem;
            string info = await ProdutoServices.DelProduto(produto);
            if (info == "NoContent")
            {
                MessageBox.Show("Produto excluído com sucesso!");
                Atualizatela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir Produto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
