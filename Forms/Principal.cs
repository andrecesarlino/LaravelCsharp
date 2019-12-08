using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaravelClient.Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnCidade_Click(object sender, EventArgs e)
        {
            Cidade.PrincipalCidade form = new Cidade.PrincipalCidade();
            form.ShowDialog();
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.PrincipalPessoa form = new Pessoa.PrincipalPessoa();
            form.ShowDialog();
        }

        private void btnCultura_Click(object sender, EventArgs e)
        {
            Cultura.PrincipalCultura form = new Cultura.PrincipalCultura();
            form.ShowDialog();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            Receita.PrincipalReceita form = new Receita.PrincipalReceita();
            form.ShowDialog();
        }

        private void btnPraga_Click(object sender, EventArgs e)
        {
            Praga.PrincipalPraga form = new Praga.PrincipalPraga();
            form.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Produto.PrincipalProduto form = new Produto.PrincipalProduto();
            form.ShowDialog();
        }
    }
}
