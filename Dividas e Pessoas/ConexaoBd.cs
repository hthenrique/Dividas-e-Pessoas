using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dividas_e_Pessoas
{
    class ConexaoBd
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string strSql;

        public class conexaoBanco
        {
            private string nomePessoa;
            private string telefonePessoa;
            private string celPessoa;
            private string endereco;
            private string divida;
            private string parcelas;
            private string parcelasPagas;
            private string observ;

            public conexaoBanco(string nomePessoa, string telefonePessoa, string celPessoa, string endereco, string divida, string parcelas, string parcelasPagas, string observ)
            {
                this.nomePessoa = nomePessoa;
                this.telefonePessoa = telefonePessoa;
                this.celPessoa = celPessoa;
                this.endereco = endereco;
                this.divida = divida;
                this.parcelas = parcelas;
                this.parcelasPagas = parcelasPagas;
                this.observ = observ;
            }
        }

    }
}
