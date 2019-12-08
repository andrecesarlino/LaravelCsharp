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
    public partial class AlterarPraga : Form
    {
        Model.Praga praga = null;
        public AlterarPraga(Model.Praga praga)
        {
            this.praga = praga;
            InitializeComponent();
            textBoxID.Text = praga.id.ToString();
            textBoxDescricao.Text = praga.descricao;            
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            praga.descricao = textBoxDescricao.Text;
          
            string info = await PragaServices.PutPraga(praga);
            if (info == "OK")
            {
                MessageBox.Show("Praga alterada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar Praga!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
