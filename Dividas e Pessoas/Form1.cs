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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    "Na mesma tela é possivel atualizar os \n" +
                    "\nImprimir lista de pessoas: " +
                    "\nPara imprimir a lista inteira de pessoas clique no botão 'Imprimir lista' ", "Ajuda");
            
        }

       
    }
}
