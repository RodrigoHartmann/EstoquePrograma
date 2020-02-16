using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EstoquePrograma.DAL
{
    class Funcionario
    {
        public bool tem = false;
        public string mensagem = "";
        static DataTable tabela = new DataTable();
        SqlCommand comando = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dados;

        public bool VerificarLogin(string usuario, string senha)
        {
            comando.CommandText = "select * from Pessoas where Usuario = @usuario and Senha = @senha";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@Senha", senha);
            try
            {
                comando.Connection = conexao.Conectar();
                dados = comando.ExecuteReader();
                if (dados.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException erro)
            {

                this.mensagem = "Erro do banco de dados!" + erro;
            }
            return tem;
        }

        public string Cadastrar(string nome, string endereco, string numero, string usuario, string senha, string data)
        {
            tem = false;
            comando.CommandText = "INSERT INTO Pessoas(Nome,Endereco,Numero,Usuario,Senha,Data) VALUES (@nome,@endereco,@numero,@usuario,@senha,@data)";
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@endereco", endereco);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@data", data);
            try
            {
                comando.Connection = conexao.Conectar();
                comando.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                tem = true;
            }
            catch (SqlException erro)
            {

                this.mensagem = "Erro do banco de dados" + erro;
            }
            return mensagem;
        }

        public static DataTable Consultar()
        {
            Conexao conexao = new Conexao();
            conexao.Conectar();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT Nome,Endereco,Data,Numero,Usuario,Data from Pessoas ORDER by Pessoas.Nome ASC";
            try
            {
                comando.Connection = conexao.Conectar();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.HasRows)
                {
                    tabela.Load(dados);
                }
                else
                {
                    MessageBox.Show("Nenhum Dado Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Conectar ao Banco de dados " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Desconectar();
                conexao.Limpar();
            }

            return Funcionario.tabela;
        }

        public string Remover(string nome, string endereco, string telefone, string usuario, string senha, string data)
        {
            tem = false;
            comando.CommandText = "INSERT INTO Pessoas(Nome, Endereco, Numero,Usuario,Senha,Data) VALUES (@nome,@endereco,@Telefone,@usuario,@senha,@data)";
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@endereco", endereco);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@data", data);
            try
            {
                comando.Connection = conexao.Conectar();
                comando.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Removido com sucesso!";
                tem = true;
            }
            catch (SqlException erro)
            {

                this.mensagem = "Erro do banco de dados" + erro;
            }
            return mensagem;
        }
    }
}
