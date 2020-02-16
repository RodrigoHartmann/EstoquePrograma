using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstoquePrograma.DAL;

namespace EstoquePrograma.Modelo {
    public class ControleProduto {
        public bool tem;
        public string mensagem = "";

        public string Cadastrar(string descricao, string fabricante, Int64 ean, string lote, float preco, DateTime data) {
            Material cadastro = new Material();
            this.mensagem = cadastro.Cadastrar(descricao, fabricante, ean, lote, preco, data);
            if (cadastro.tem) {
                this.tem = true;
            }
            return mensagem;
        }

        public string Remover(string descricao, string fabricante, Int64 ean, string lote, float preco, DateTime data) {
            Funcionario login = new Funcionario();
            //this.mensagem = login.Remover(descricao, fabricante, ean, lote, preco, data);
            if (login.tem) {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
