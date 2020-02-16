using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EstoquePrograma.Modelo;
using EstoquePrograma.DAL;
using System.Data.SqlClient;

namespace EstoquePrograma.Apresentação {
    public partial class Funcionarios : Form {
        public Funcionarios() {
            InitializeComponent();
        }

        Controle controle = new Controle();
        private void BtnCadastrar_Click(object sender, EventArgs e) {
            Controle controle = new Controle();
            if (txtNome.Text == "" || txtEndereco.Text == "" || txtUsuarioSistema.Text == "" || txtNumero.Text == "" || txtSenhaSistema.Text == "" || txtData.Text == "") {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string data = DateTime.Now.ToString("yyy-MM-dd");
                string mensagem = controle.Cadastrar(txtNome.Text, txtEndereco.Text, txtNumero.Text, txtUsuarioSistema.Text, txtSenhaSistema.Text, data);
                if (controle.tem) {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show(controle.mensagem);
                }
            }
        }

        private void Funcionarios_Load(object sender, EventArgs e) {
            dgvFuncionarios.AutoGenerateColumns = false;
            dgvFuncionarios.DataSource = Funcionario.Consultar();
        }

        private void BtnRemover_Click(object sender, EventArgs e) {
        }
    }
}
