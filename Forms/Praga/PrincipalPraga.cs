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

namespace LaravelClient.Forms.Praga
{
    public partial class PrincipalPraga : Form
    {
        public PrincipalPraga()
        {
            InitializeComponent();
            Atualizatela();
        }

        private async void Atualizatela()
        {
            List<Model.Praga> lista = await PragaServices.GetPraga();
            dataGridPraga.DataSource = lista;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Praga.CriarPraga form = new Praga.CriarPraga();
            form.ShowDialog();
            Atualizatela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Model.Praga praga = (Model.Praga)dataGridPraga.SelectedRows[0].DataBoundItem;
            Praga.AlterarPraga form = new Praga.AlterarPraga(praga);
            form.ShowDialog();
            Atualizatela();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            Model.Praga praga = (Model.Praga)dataGridPraga.SelectedRows[0].DataBoundItem;
            string info = await PragaServices.DelPraga(praga);
            if (info == "NoContent")
            {
                MessageBox.Show("Cultura excluída com sucesso!");
                Atualizatela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir Cultura");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
