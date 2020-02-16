namespace EstoquePrograma.Apresentação
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mnArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDeMateriais = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMateriais = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(293, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // mnArquivo
            // 
            this.mnArquivo.Name = "mnArquivo";
            this.mnArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnArquivo.Text = "Arquivo";
            this.mnArquivo.Click += new System.EventHandler(this.MnArquivo_Click);
            // 
            // mnEstoque
            // 
            this.mnEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAuditoria,
            this.toolStripMenuItem5,
            this.saídaDeMateriais});
            this.mnEstoque.Name = "mnEstoque";
            this.mnEstoque.Size = new System.Drawing.Size(61, 20);
            this.mnEstoque.Text = "Estoque";
            // 
            // mnAuditoria
            // 
            this.mnAuditoria.Name = "mnAuditoria";
            this.mnAuditoria.Size = new System.Drawing.Size(181, 22);
            this.mnAuditoria.Text = "Auditoria";
            this.mnAuditoria.Click += new System.EventHandler(this.MnAuditoria_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem5.Text = "Entrada de Materiais";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // saídaDeMateriais
            // 
            this.saídaDeMateriais.Name = "saídaDeMateriais";
            this.saídaDeMateriais.Size = new System.Drawing.Size(181, 22);
            this.saídaDeMateriais.Text = "Saída de Materiais";
            this.saídaDeMateriais.Click += new System.EventHandler(this.SaídaDeMateriaisToolStripMenuItem_Click);
            // 
            // mnCadastro
            // 
            this.mnCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.mnMateriais});
            this.mnCadastro.Name = "mnCadastro";
            this.mnCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnCadastro.Text = "Cadastro";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.FuncionariosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.FornecedoresToolStripMenuItem_Click);
            // 
            // mnMateriais
            // 
            this.mnMateriais.Name = "mnMateriais";
            this.mnMateriais.Size = new System.Drawing.Size(145, 22);
            this.mnMateriais.Text = "Materiais";
            this.mnMateriais.Click += new System.EventHandler(this.MnMateriais_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivo,
            this.mnEstoque,
            this.mnCadastro});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(846, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 477F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 451);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 25);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // Principal
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(846, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeMateriaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fubncionariosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem mnArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnAuditoria;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem saídaDeMateriais;
        private System.Windows.Forms.ToolStripMenuItem mnCadastro;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnMateriais;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}