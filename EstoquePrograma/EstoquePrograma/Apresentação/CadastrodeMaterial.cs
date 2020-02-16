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

namespace EstoquePrograma.Apresentação {
    public partial class CadastrodeMaterial : Form {
        public CadastrodeMaterial() {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e) {
            ControleProduto produto = new ControleProduto();
            if (txtDescricao.Text == "" || txtFabricante.Text == "" || txtEAN.Text == "") {

            }
        }
    }
}
