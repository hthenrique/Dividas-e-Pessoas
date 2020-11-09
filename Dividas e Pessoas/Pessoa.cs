using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividas_e_Pessoas
{
    class CRUD_Pessoa
    {
        private int id { get; set; }
        private string nome { get; set; }
        private int telefone { get; set; }
        private int celular { get; set; }
        private string endereco { get; set; }
        private float divida { get; set; }
        private int parcelas { get; set; }
        private int parcelasPagas { get; set; }
        private string observ { get; set; }

        public CRUD_Pessoa(int id, string nome, int telefone, int celular, string endereco, float divida, int parcelas, int parcelasPagas, string observ)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.celular = celular;
            this.endereco = endereco;
            this.divida = divida;
            this.parcelas = parcelas;
            this.parcelasPagas = parcelasPagas;
            this.observ = observ;
        }

    }
}
