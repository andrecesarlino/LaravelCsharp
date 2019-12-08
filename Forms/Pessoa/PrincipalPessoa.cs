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

namespace LaravelClient.Forms.Pessoa
{
    public partial class PrincipalPessoa : Form
    {
        public PrincipalPessoa()
        {
            InitializeComponent();
            Atualizatela();
        }

        private async void Atualizatela()
        {
            List<Model.Pessoa> lista = await PessoaServices.GetPessoa();
            dataGridPessoa.DataSource = lista;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Pessoa.CriarPessoa form = new Pessoa.CriarPessoa();
            form.ShowDialog();
            Atualizatela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Model.Pessoa pessoa = (Model.Pessoa)dataGridPessoa.SelectedRows[0].DataBoundItem;
            Pessoa.AlterarPessoa form = new Pessoa.AlterarPessoa(pessoa);
            form.ShowDialog();
            Atualizatela();
        }
        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            Model.Pessoa pessoa = (Model.Pessoa)dataGridPessoa.SelectedRows[0].DataBoundItem;
            string info = await PessoaServices.DelPessoa(pessoa);
            if (info == "NoContent")
            {
                MessageBox.Show("Pessoa excluída com sucesso!");
                Atualizatela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir Pessoa");
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
