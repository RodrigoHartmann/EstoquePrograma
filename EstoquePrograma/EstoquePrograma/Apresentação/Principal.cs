using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoquePrograma.Apresentação
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MnAuditoria_Click(object sender, EventArgs e)
        {
            Auditoria auditoria = new Auditoria();
            auditoria.Show();
        }

        private void FuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.Show();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            EntradaMateriais entrada = new EntradaMateriais();
            entrada.Show();
        }

        private void SaídaDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaidaMateriais saida = new SaidaMateriais();
            saida.Show();
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
        }

        private void MnMateriais_Click(object sender, EventArgs e)
        {
            Materiais materiais = new Materiais();
            materiais.Show();
        }

        private void MnArquivo_Click(object sender, EventArgs e)
        {

        }
    }
}
