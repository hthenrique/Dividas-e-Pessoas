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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            BancoDadosHelper bdHelper = new BancoDadosHelper();
            listaPessoas.DataSource = bdHelper.consultarBanco();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Iniciar tela de cadastro de pessoa
            Form2 form2 = new Form2();
            form2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Mostrar caixa de mensagem de ajuda
                MessageBox.Show("Visualizar ou Editar Pessoa: " +
                    "\nPara visualizar a pessoa cadastrada, clique duas vezes sobre o nome dela, será aberto uma janela com as informações salvas." +
                    "Na mesma tela é possivel atualizar os cadastros\n" +
                    "\nImprimir lista de pessoas: " +
                    "\nPara imprimir a lista inteira de pessoas clique no botão 'Imprimir lista' ", "Ajuda");
            
        }

        private void atualizarLista_Click(object sender, EventArgs e)
        {
            BancoDadosHelper bdHelper = new BancoDadosHelper();
            listaPessoas.DataSource = bdHelper.consultarBanco();
        }

        public static DataGridViewRow selectedRow { get; set; }
        private void editarPessoa(object sender, DataGridViewCellEventArgs e)
        {
            
         
            listaPessoas.CurrentRow.Selected = true;

            string id = listaPessoas.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            string nome = listaPessoas.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            string telefone = listaPessoas.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            string celular = listaPessoas.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            string endereco = listaPessoas.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            string divida = listaPessoas.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            string parcelas = listaPessoas.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            string parcelas_pagas = listaPessoas.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            string observacao = listaPessoas.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();

            Editar_Pessoa editar_Pessoa = new Editar_Pessoa(id, nome, telefone, celular, endereco, divida, parcelas, parcelas_pagas, observacao);
            editar_Pessoa.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
