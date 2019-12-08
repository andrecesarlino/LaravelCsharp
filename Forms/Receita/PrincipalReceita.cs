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

namespace LaravelClient.Forms.Receita
{
    public partial class PrincipalReceita : Form
    {
        public PrincipalReceita()
        {
            InitializeComponent();
            CriaListas();
        }

        public async void CriaListas()
        {
            List<Model.Pessoa> listaPessoa = await PessoaServices.GetPessoa();
            List<Model.Cultura> listaCultura = await CulturaServices.GetCultura();
            List<Model.Produto> listaProduto = await ProdutoServices.GetProduto();
            comboBoxCliente.DataSource = listaPessoa;
            comboBoxProduto.DataSource = listaProduto;
            comboBoxCultura.DataSource = listaCultura;
        }


        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBoxNumero.Text);
            int id_pessoa = Convert.ToInt32(comboBoxCliente.SelectedIndex);
            int id_cultura = Convert.ToInt32(comboBoxCultura.SelectedIndex);
            int id_produto = Convert.ToInt32(comboBoxProduto.SelectedIndex);
            int quantidade = Convert.ToInt32(textBoxQuantidade.Text);

            Model.Receita receita = new Model.Receita();
            receita.numero = numero;
            receita.id_pessoa = id_pessoa;
            receita.id_cultura =id_cultura;

            string info = await ReceitaServices.PostReceita(receita);
            
            Model.ReceitaProduto receitaproduto = new Model.ReceitaProduto();
            //receitaproduto.id_receita = Convert.ToInt32(textBoxNumero.Text);
            receitaproduto.id_receita = 26;
            receitaproduto.id_produto = id_produto;
            receitaproduto.quantidade = quantidade;

            string info2 = await ReceitaProdutoServices.PostReceitaProduto(receitaproduto);
            if (info == "Created")
            {
                MessageBox.Show("Receita cadastrada com sucesso!");                
                Close();
                
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Receita!");
            }

            if (info2 == "Created")
            {
                MessageBox.Show("Produto incluido com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
                MessageBox.Show(receita.numero.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
