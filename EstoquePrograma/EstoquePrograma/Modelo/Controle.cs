using EstoquePrograma.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoquePrograma.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool Acessar(string usuario, string senha)
        {
            Funcionario login = new Funcionario();
            tem = login.VerificarLogin(usuario, senha);
            if (!login.mensagem.Equals(""))
            {
                this.mensagem = login.mensagem;
            }
            return tem;
        }

        public string Cadastrar(string nome, string endereco, string numero, string usuario, string senha, string data)
        {
            Funcionario login = new Funcionario();
            this.mensagem = login.Cadastrar(nome, endereco, numero, usuario, senha, data);
            if (login.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public string Remover(string nome, string endereco, string numero, string usuario, string senha, string data)
        {
            Funcionario login = new Funcionario();
            this.mensagem = login.Remover(nome, endereco, numero, usuario, senha, data);
            if (login.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    } 
}
