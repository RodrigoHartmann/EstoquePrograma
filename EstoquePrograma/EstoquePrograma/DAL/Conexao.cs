using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace EstoquePrograma.DAL
{
    public class Conexao
    {
        SqlConnection conexao = new SqlConnection();
        public Conexao()
        {
            //conexao Mysql;
            //conexao.ConnectionString = @"server=localhost; database=test;uid=root;password=; default command timeout=7200;";

            conexao.ConnectionString = @"Data Source=DESKTOP-32G110N;Initial Catalog=SRVTESTE;Integrated Security=True;";
        }

        public SqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }

        }
        public void Limpar()
        {
            conexao.Dispose();
        }
    }
}
