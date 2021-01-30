using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dividas_e_Pessoas
{
    public partial class Editar_Pessoa : Form
    {
        string pessoaId;
        string nomePessoa;
        string telefonePessoa;
        string celPessoa;
        string enderecoPessoa;
        string dividaPessoa;
        string parcelasPessoa;
        string parcelasPagas;
        string observ;


        public Editar_Pessoa(string id, string nome, string telefone, string celular, string endereco, string divida, string parcelas, string parcelas_pagas, string observacao)
        {
            InitializeComponent();
            pessoaId = id;
            nomePessoa = nome;
            telefonePessoa = telefone;
            celPessoa = celular;
            enderecoPessoa = endereco;
            dividaPessoa = divida;
            parcelasPessoa = parcelas;
            parcelasPagas = parcelas_pagas;
            observ = observacao;

        }

        private void Editar_Pessoa_Load(object sender, EventArgs e)
        {
            
            if (nomePessoa == "")
            {
                MessageBox.Show("Vazio");
                this.Close();
            }
            else
            {
                BancoDadosHelper bdHelper = new BancoDadosHelper();
                DataTable data = bdHelper.consultarPessoa(pessoaId);
                carregarPessoa();
            }

        }

        private void carregarPessoa()
        {
            textBoxNomePessoa.Text = nomePessoa;
            numTelefone.Text = telefonePessoa;
            numCelular.Text = celPessoa;
            textBoxEndereco.Text = enderecoPessoa;
            textBoxDivida.Text = dividaPessoa;
            textBoxParcelas.Text = parcelasPessoa;
            textBoxParcelasPagas.Text = parcelasPagas;
            richTextBoxObservacao.Text = observ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomePessoa = textBoxNomePessoa.Text;
            string telefonePessoa = numTelefone.Text;
            string celPessoa = numCelular.Text;
            string enderecoPessoa = textBoxEndereco.Text;
            string divida = textBoxDivida.Text;
            string parcelas = textBoxParcelas.Text;
            string parcelasPagas = textBoxParcelasPagas.Text;
            string observ = richTextBoxObservacao.Text;

            BancoDadosHelper bdHelper = new BancoDadosHelper();

            string cadastrar = bdHelper.editarPessoa(pessoaId,
                                   nomePessoa,
                                   telefonePessoa,
                                   celPessoa,
                                   enderecoPessoa,
                                   divida,
                                   parcelas,
                                   parcelasPagas,
                                   observ);

            if (string.IsNullOrEmpty(cadastrar))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(cadastrar);
            }
        }

        private void excluirPessoa_Click(object sender, EventArgs e)
        {
            BancoDadosHelper bdHelper = new BancoDadosHelper();
            string excluir = bdHelper.excluirPessoa(pessoaId);

            if (string.IsNullOrEmpty(excluir))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(excluir);
            }
        }
    }
}
