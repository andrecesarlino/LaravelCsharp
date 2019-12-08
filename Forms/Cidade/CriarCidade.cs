using LaravelClient.Model;
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


namespace LaravelClient.Forms.Cidade
{
    public partial class CriarCidade : Form
    {
        public CriarCidade()
        {
            InitializeComponent();
        }

        private async void BtnCriarSalvarCidade_Click(object sender, EventArgs e)
        {
            string nome = TxtBoxNomeCidade.Text;
            string cep = TxtBoxCepCidade.Text;
            Model.Cidade cidade = new Model.Cidade();
            cidade.nome = nome;
            cidade.cep = cep;
            string info = await CidadeServices.PostCidade(cidade);
            if (info == "Created")
            {
                MessageBox.Show("Cidade cadastrado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Cidade!");
            }
        }

        private void BtnVoltarCriarCidade_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CriarCidade_Load(object sender, EventArgs e)
        {

        }
    }
}
