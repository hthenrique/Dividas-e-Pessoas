using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dividas_e_Pessoas
{
    
    public partial class Form2 : Form
    {
        string nomePessoa;
        string telefonePessoa;
        string celPessoa;
        string enderecoPessoa;
        string numEndereco;
        string compEndereco;
        string bairroEndereco;
        string divida;
        string parcelas;
        string parcelasPagas;
        string observ;

        SqlConnection conBd;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            nomePessoa = textBoxNomePessoa.Text;
            telefonePessoa = numTelefone.Text;
            celPessoa = numCelular.Text;
            enderecoPessoa = textBoxEndereco.Text;
            divida = textBoxDivida.Text;
            parcelas = textBoxParcelas.Text;
            parcelasPagas = textBoxParcelasPagas.Text;
            observ = richTextBoxObservacao.Text;

            BancoDadosHelper bdHelper = new BancoDadosHelper();

            string retorno = bdHelper.inserirPessoa(nomePessoa,
                                   telefonePessoa,
                                   celPessoa,
                                   enderecoPessoa,
                                   divida,
                                   parcelas,
                                   parcelasPagas,
                                   observ);

            if (string.IsNullOrEmpty(retorno))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(retorno);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
