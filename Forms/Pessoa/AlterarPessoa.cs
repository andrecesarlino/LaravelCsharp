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
    public partial class AlterarPessoa : Form
    {
        public async void CriaListaCidade()
        {
            List<Model.Cidade> lista = await CidadeServices.GetCidade();
            comboBoxCidade.DataSource = lista;
        }

        Model.Pessoa pessoa = null;
        public AlterarPessoa(Model.Pessoa pessoa)
        {
            this.pessoa = pessoa;
            InitializeComponent();
            CriaListaCidade();
            textBoxId.Text = pessoa.id.ToString();
            textBoxNomePessoa.Text = pessoa.nome;
            textBoxEndereco.Text = pessoa.endereco;
            comboBoxCidade.Text = pessoa.id_cidade.ToString();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            pessoa.nome = textBoxNomePessoa.Text;
            pessoa.endereco = textBoxEndereco.Text;
            pessoa.id_cidade = Convert.ToInt32(comboBoxCidade.SelectedIndex);

            string info = await PessoaServices.PutPessoa(pessoa);
            if (info == "OK")
            {
                MessageBox.Show("Pessoa alterada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Pessoa!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
