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
    public partial class Materiais : Form {
        public Materiais() {
            InitializeComponent();
        }

        private void TxtDescricao_TextChanged(object sender, EventArgs e) {
        }

        private void BtnNovoMaterial_Click(object sender, EventArgs e) {
            CadastrodeMaterial material = new CadastrodeMaterial();
            material.Show();
        }
    }
}
