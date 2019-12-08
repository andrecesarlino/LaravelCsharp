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
    public partial class CriarPessoa : Form
    {
        public CriarPessoa()
        {
            InitializeComponent();
            CriaListaCidade();
        }
        public async void CriaListaCidade()
        {
            List<Model.Cidade> lista = await CidadeServices.GetCidade();
            comboBoxCidade.DataSource = lista;
        }

        private  async void btnSalvar_Click(object sender, EventArgs e)
        {

            List<Model.Cidade> lista = await CidadeServices.GetCidade();

            string nome = textBoxNomePessoa.Text;
            string endereco = textBoxEnderecoPessoa.Text;
           
            Model.Pessoa pessoa = new Model.Pessoa();
            pessoa.nome = nome;
            pessoa.endereco = endereco;
            pessoa.id_cidade=Convert.ToInt32(comboBoxCidade.SelectedIndex);

            string info = await PessoaServices.PostPessoa(pessoa);
            if (info == "Created")
            {
                MessageBox.Show("Pessoa cadastrada com sucesso!");
                Close();

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Pessoa!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
