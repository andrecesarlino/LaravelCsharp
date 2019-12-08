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

namespace LaravelClient.Forms.Cultura
{
    public partial class PrincipalCultura : Form
    {
        public PrincipalCultura()
        {
            InitializeComponent();
            Atualizatela();
        }

        private async void Atualizatela()
        {
            List<Model.Cultura> lista = await CulturaServices.GetCultura();
            dataGridCultura.DataSource = lista;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Cultura.CriarCultura form = new Cultura.CriarCultura();
            form.ShowDialog();
            Atualizatela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Model.Cultura cultura = (Model.Cultura)dataGridCultura.SelectedRows[0].DataBoundItem;
            Cultura.AlterarCultura form = new Cultura.AlterarCultura(cultura);
            form.ShowDialog();
            Atualizatela();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            Model.Cultura cultura = (Model.Cultura)dataGridCultura.SelectedRows[0].DataBoundItem;
            string info = await CulturaServices.DelCultura(cultura);
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
    }
}
