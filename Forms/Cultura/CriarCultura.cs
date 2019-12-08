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
    public partial class CriarCultura : Form
    {
        public CriarCultura()
        {
            InitializeComponent();
            CriaListaPraga();
        }

        public async void CriaListaPraga()
        {
            List<Model.Praga> lista = await PragaServices.GetPraga();
            comboBoxPraga.DataSource = lista;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            int id_praga = Convert.ToInt32(comboBoxPraga.SelectedIndex);

            Model.Cultura cultura = new Model.Cultura();
            cultura.descricao = descricao;
            cultura.id_praga = id_praga;
            string info = await CulturaServices.PostCultura(cultura);

            if (info == "Created")
            {
                MessageBox.Show("Cultura cadastrada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Cultura!");
                MessageBox.Show(info);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
