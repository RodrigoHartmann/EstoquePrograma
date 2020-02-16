using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoquePrograma.Modelo;
using EstoquePrograma.Apresentação;

namespace EstoquePrograma {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (txtUsuario.Text == "" || txtSenha.Text == "") {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Controle controle = new Controle();
                controle.Acessar(txtUsuario.Text, txtSenha.Text);
                if (controle.mensagem.Equals("")) {
                    if (controle.tem) {
                        this.Hide();
                        Principal principal = new Principal();
                        principal.Show();

                    }
                    else {
                        MessageBox.Show("Usuário não localizado, Verifique o usuário e senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    MessageBox.Show(controle.mensagem);
                }
            }
        }
    }
}

