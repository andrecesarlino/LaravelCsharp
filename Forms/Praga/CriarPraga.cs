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
    public partial class CriarPraga : Form
    {
        public CriarPraga()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            
            Model.Praga praga = new Model.Praga();
            praga.descricao = descricao;
            
            string info = await PragaServices.PostPraga(praga);
            if (info == "Created")
            {
                MessageBox.Show("Praga cadastrada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Praga!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
