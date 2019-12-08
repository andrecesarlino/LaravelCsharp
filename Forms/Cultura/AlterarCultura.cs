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
    public partial class AlterarCultura : Form
    {
        public async void CriaListaPraga()
        {
            List<Model.Praga> lista = await PragaServices.GetPraga();
            comboBoxPraga.DataSource = lista;
        }

        Model.Cultura cultura = null;
        public AlterarCultura(Model.Cultura cultura)
        {
            this.cultura = cultura;
            InitializeComponent();
            CriaListaPraga();
            textBoxID.Text = cultura.id.ToString();
            textBoxDescricao.Text = cultura.descricao;
            comboBoxPraga.Text = cultura.id_praga.ToString();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            cultura.descricao = textBoxDescricao.Text;
            cultura.id_praga = Convert.ToInt32(comboBoxPraga.SelectedIndex);
            string info = await CulturaServices.PutCultura(cultura);
            if (info == "OK")
            {
                MessageBox.Show("Cultura alterada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar Cultura!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
