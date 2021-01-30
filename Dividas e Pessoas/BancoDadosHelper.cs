using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dividas_e_Pessoas
{
    class BancoDadosHelper
    {
        SqlConnection conexaoBd;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        SqlDataReader dataReader;

        string stringSql;
        string bdCaminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dados\banco_dados.mdf;Integrated Security=True;Connect Timeout=30";

        //Inserir pessoa no banco de dados
        public string inserirPessoa(string nomePessoa, 
                                  string telefonePessoa, 
                                  string celPessoa, 
                                  string endereco, 
                                  string divida, 
                                  string parcelas, 
                                  string parcelasPagas, 
                                  string observ)
        {
            
            stringSql = "INSERT INTO Pessoas (nome,telefone,celular,endereco,divida,parcelas,parcelas_pagas,observacao) " +
                    "VALUES (@NOME, @TELEFONE, @CELULAR, @ENDERECO, @DIVIDA, @PARCELAS, @PARCELASPAGAS, @OBSERVACAO)";

            try
            {
                conexaoBd = new SqlConnection(bdCaminho);
                comando = new SqlCommand(stringSql, conexaoBd);
                    
                comando.Parameters.AddWithValue("@NOME", nomePessoa);
                comando.Parameters.AddWithValue("@TELEFONE", telefonePessoa);
                comando.Parameters.AddWithValue("@CELULAR", celPessoa);
                comando.Parameters.AddWithValue("@ENDERECO", endereco);
                comando.Parameters.AddWithValue("@DIVIDA", divida);
                comando.Parameters.AddWithValue("@PARCELAS", parcelas);
                comando.Parameters.AddWithValue("@PARCELASPAGAS", parcelasPagas);
                comando.Parameters.AddWithValue("@OBSERVACAO", observ);

                conexaoBd.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            { 
                return ex.Message.ToString();
            }
            finally
            {
                conexaoBd.Close();
                comando.Clone();
                conexaoBd = null;
                comando = null;
                
            }
            return string.Empty;

        }

        public DataTable consultarBanco()
        {
            string stringSql = "SELECT * FROM Pessoas";
            DataTable dataTable = new DataTable();
            conexaoBd = new SqlConnection(bdCaminho);
            comando = new SqlCommand(stringSql, conexaoBd);

            using (conexaoBd)
            {
                using (comando)
                {
                    conexaoBd.Open();
                    dataReader = comando.ExecuteReader();
                    dataTable.Load(dataReader);
                }
            }
            return dataTable;

        }

        public DataTable consultarPessoa(string id)
        {
            string stringSql = "SELECT * FROM Pessoas WHERE " +id+ "=@Id";

            DataTable dataTable = new DataTable();

            conexaoBd = new SqlConnection(bdCaminho);
            comando = new SqlCommand(stringSql, conexaoBd);
            dataAdapter = new SqlDataAdapter(stringSql, conexaoBd);

            using (conexaoBd)
            {
                using (comando)
                {
                    dataAdapter.SelectCommand.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@id",
                        Value = id
                    });
                    conexaoBd.Open();
                    using (dataReader = dataAdapter.SelectCommand.ExecuteReader())
                    {
                        dataTable.Load(dataReader);
                    }
                }
            }
            return dataTable;

        }

        public string excluirPessoa(string id)
        {
            stringSql = "DELETE FROM Pessoas WHERE id = @ID";
            conexaoBd = new SqlConnection(bdCaminho);
            comando = new SqlCommand(stringSql, conexaoBd);

            try
            {
                using (conexaoBd)
                {
                    using (comando)
                    {
                        comando.Parameters.AddWithValue("@ID", id);
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            return string.Empty;
        }

        public string editarPessoa(string id, string nomePessoa, string telefonePessoa, string celPessoa, string enderecoPessoa, string divida, string parcelas, string parcelasPagas, string observ)
        {
            stringSql = "UPDATE Pessoas SET nome = @NOME, telefone = @TELEFONE, celular = @CELULAR, endereco = @ENDERECO, divida = @DIVIDA, parcelas = @PARCELAS, parcelas_pagas = @PARCELASPAGAS, observacao = @OBSERVACAO " +
                    "WHERE id = @ID";
            conexaoBd = new SqlConnection(bdCaminho);
            comando = new SqlCommand(stringSql, conexaoBd);

            
            try
            {
                conexaoBd = new SqlConnection(bdCaminho);
                comando = new SqlCommand(stringSql, conexaoBd);

                using (conexaoBd)
                {
                    using (comando)
                    {
                        comando.Parameters.AddWithValue("@NOME", nomePessoa);
                        comando.Parameters.AddWithValue("@TELEFONE", telefonePessoa);
                        comando.Parameters.AddWithValue("@CELULAR", celPessoa);
                        comando.Parameters.AddWithValue("@ENDERECO", enderecoPessoa);
                        comando.Parameters.AddWithValue("@DIVIDA", divida);
                        comando.Parameters.AddWithValue("@PARCELAS", parcelas);
                        comando.Parameters.AddWithValue("@PARCELASPAGAS", parcelasPagas);
                        comando.Parameters.AddWithValue("@OBSERVACAO", observ);
                        comando.Parameters.AddWithValue("@ID", id);

                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            return string.Empty;
        }

    }
}
