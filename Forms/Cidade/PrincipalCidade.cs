using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaravelClient.Model;
using LaravelClient.Controller;

namespace LaravelClient.Forms.Cidade
{
    public partial class PrincipalCidade : Form
    {
        public PrincipalCidade()
        {
            InitializeComponent();
            Atualizatela();
        }

        private async void Atualizatela()
        {
            List<Model.Cidade> lista = await CidadeServices.GetCidade();
            GridCidade.DataSource = lista;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CriarCidade form = new CriarCidade();
            form.ShowDialog();
            Atualizatela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Model.Cidade cidade = (Model.Cidade)GridCidade.SelectedRows[0].DataBoundItem;
            AlterarCultura form = new AlterarCultura(cidade);
            form.ShowDialog();
            Atualizatela();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            Model.Cidade cidade = (Model.Cidade)GridCidade.SelectedRows[0].DataBoundItem;
            string info = await CidadeServices.DelCidade(cidade);
            if (info == "NoContent")
            {
                MessageBox.Show("Cidade excluída com sucesso!");
                Atualizatela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir cidade");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
