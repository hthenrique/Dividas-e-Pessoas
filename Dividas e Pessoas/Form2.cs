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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            String nomePessoa = textBoxNomePessoa.Text;
            String telefonePessoa = textBoxNumTelefone.Text;
            String celPessoa = textBoxNumCelular.Text;
            String enderecoPessoa = textBoxEndereco.Text;
            String numEndereco = textBoxEnderecoNum.Text;
            String compEndereco = textBoxEnderecoComp.Text;
            String divida = textBoxDivida.Text;
            String parcelas = textBoxParcelas.Text;
            String parcelasPagas = textBoxParcelasPagas.Text;
            String observ = richTextBoxObservacao.Text;

            MessageBox.Show(nomePessoa + "\n" + telefonePessoa + "\n" + celPessoa + "\n" + enderecoPessoa + "\n" + numEndereco + "\n" + divida, "Teste");
        }
    }
}
