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
    public partial class AlterarCultura : Form
    {
        Model.Cidade cidade = null;
        public AlterarCultura(Model.Cidade cidade)
        {
            this.cidade = cidade;
            InitializeComponent();
            TxtBoxId.Text = cidade.id.ToString();
            TxtBoxAlterarCep.Text = cidade.cep;
            TxtBoxAlterarCidade.Text = cidade.nome;
            
        }

        private void AlterarCidade_Load(object sender, EventArgs e)
        {
            
        }

        private async void BtnSalvarAlterarCidade_Click(object sender, EventArgs e)
        {
            cidade.nome = TxtBoxAlterarCidade.Text;
            cidade.cep = TxtBoxAlterarCep.Text;
            string info = await CidadeServices.PutCidade(cidade);
            if (info == "OK")
            {
                MessageBox.Show("Cidade alterada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Cidade!");
            }
        }

        private void BtnVoltarAlterarCidade_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
