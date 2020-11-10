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
        String nomePessoa;
        String telefonePessoa;
        String celPessoa;
        String enderecoPessoa;
        String numEndereco;
        String compEndereco;
        String bairroEndereco;
        String divida;
        String parcelas;
        String parcelasPagas;
        String observ;

        SqlConnection conBd;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        string stringSql;

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
            telefonePessoa = textBoxNumTelefone.Text;
            celPessoa = textBoxNumCelular.Text;
            enderecoPessoa = textBoxEndereco.Text;
            numEndereco = textBoxEnderecoNum.Text;
            compEndereco = textBoxEnderecoComp.Text;
            bairroEndereco = textBoxEnderecoBairro.Text;
            divida = textBoxDivida.Text;
            parcelas = textBoxParcelas.Text;
            parcelasPagas = textBoxParcelasPagas.Text;
            observ = richTextBoxObservacao.Text;

            String endereco = enderecoPessoa + ", " + numEndereco + ", " + compEndereco + ", " + bairroEndereco;


            try
            {
                conBd = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dados\banco_dados.mdf;Integrated Security=True;Connect Timeout=30");
                stringSql = "INSERT INTO Pessoas (nome,telefone,celular,endereco,divida,parcelas,parcelas_pagas,observacao) " +
                    "VALUES (@NOME, @TELEFONE, @CELULAR, @ENDERECO, @DIVIDA, @PARCELAS, @PARCELASPAGAS, @OBSERVACAO)";

                comando = new SqlCommand(stringSql, conBd);

                comando.Parameters.AddWithValue("@NOME", nomePessoa);
                comando.Parameters.AddWithValue("@TELEFONE", telefonePessoa);
                comando.Parameters.AddWithValue("@CELULAR", celPessoa);
                comando.Parameters.AddWithValue("@ENDERECO", endereco);
                comando.Parameters.AddWithValue("@DIVIDA", divida);
                comando.Parameters.AddWithValue("@PARCELAS", parcelas);
                comando.Parameters.AddWithValue("@PARCELASPAGAS", parcelasPagas);
                comando.Parameters.AddWithValue("@OBSERVACAO", observ);

                conBd.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conBd.Close();
                comando.Clone();
                conBd = null;
                comando = null;
            }

        }
    }
}
