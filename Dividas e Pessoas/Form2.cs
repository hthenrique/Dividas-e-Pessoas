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

            MessageBox.Show(nomePessoa + "\n" + telefonePessoa + "\n" + celPessoa + "\n" + enderecoPessoa + "\n" + numEndereco + "\n" + divida, "Teste");
        }
    }
}
