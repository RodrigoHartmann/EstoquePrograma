namespace EstoquePrograma.Apresentação
{
    partial class Funcionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.tbFuncionarios = new System.Windows.Forms.TabControl();
            this.tbpFuncionarios = new System.Windows.Forms.TabPage();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Função = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenhaSistema = new System.Windows.Forms.TextBox();
            this.txtUsuarioSistema = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSenhaSistema = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.tbFuncionarios.SuspendLayout();
            this.tbpFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.tbpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFuncionarios
            // 
            this.tbFuncionarios.Controls.Add(this.tbpFuncionarios);
            this.tbFuncionarios.Controls.Add(this.tbpCadastro);
            this.tbFuncionarios.Location = new System.Drawing.Point(1, 4);
            this.tbFuncionarios.Name = "tbFuncionarios";
            this.tbFuncionarios.SelectedIndex = 0;
            this.tbFuncionarios.Size = new System.Drawing.Size(778, 375);
            this.tbFuncionarios.TabIndex = 0;
            // 
            // tbpFuncionarios
            // 
            this.tbpFuncionarios.Controls.Add(this.dgvFuncionarios);
            this.tbpFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tbpFuncionarios.Name = "tbpFuncionarios";
            this.tbpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFuncionarios.Size = new System.Drawing.Size(770, 349);
            this.tbpFuncionarios.TabIndex = 0;
            this.tbpFuncionarios.Text = "Funcionarios";
            this.tbpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Função,
            this.Column1,
            this.data});
            this.dgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionarios.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvFuncionarios.Location = new System.Drawing.Point(3, 3);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowHeadersWidth = 4;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(764, 343);
            this.dgvFuncionarios.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Função
            // 
            this.Função.HeaderText = "Função";
            this.Função.Name = "Função";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "usuario";
            this.Column1.HeaderText = "Usuário";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.BackColor = System.Drawing.Color.Silver;
            this.tbpCadastro.Controls.Add(this.txtNumero);
            this.tbpCadastro.Controls.Add(this.txtData);
            this.tbpCadastro.Controls.Add(this.btnCadastrar);
            this.tbpCadastro.Controls.Add(this.txtSenhaSistema);
            this.tbpCadastro.Controls.Add(this.txtUsuarioSistema);
            this.tbpCadastro.Controls.Add(this.txtEndereco);
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.lblData);
            this.tbpCadastro.Controls.Add(this.lblSenhaSistema);
            this.tbpCadastro.Controls.Add(this.lblSistema);
            this.tbpCadastro.Controls.Add(this.lblNumero);
            this.tbpCadastro.Controls.Add(this.lblEndereco);
            this.tbpCadastro.Controls.Add(this.lblNome);
            this.tbpCadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(770, 349);
            this.tbpCadastro.TabIndex = 1;
            this.tbpCadastro.Text = "Cadastro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(260, 93);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(62, 27);
            this.txtNumero.TabIndex = 16;
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(537, 127);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(114, 27);
            this.txtData.TabIndex = 15;
            this.txtData.Value = new System.DateTime(2019, 10, 1, 12, 24, 13, 0);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(251, 273);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(268, 39);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // txtSenhaSistema
            // 
            this.txtSenhaSistema.Location = new System.Drawing.Point(537, 75);
            this.txtSenhaSistema.Name = "txtSenhaSistema";
            this.txtSenhaSistema.Size = new System.Drawing.Size(227, 27);
            this.txtSenhaSistema.TabIndex = 10;
            // 
            // txtUsuarioSistema
            // 
            this.txtUsuarioSistema.Location = new System.Drawing.Point(537, 24);
            this.txtUsuarioSistema.Name = "txtUsuarioSistema";
            this.txtUsuarioSistema.Size = new System.Drawing.Size(227, 27);
            this.txtUsuarioSistema.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(5, 93);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(227, 27);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(6, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 27);
            this.txtNome.TabIndex = 6;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(534, 106);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 18);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblSenhaSistema
            // 
            this.lblSenhaSistema.AutoSize = true;
            this.lblSenhaSistema.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaSistema.Location = new System.Drawing.Point(534, 54);
            this.lblSenhaSistema.Name = "lblSenhaSistema";
            this.lblSenhaSistema.Size = new System.Drawing.Size(46, 18);
            this.lblSenhaSistema.TabIndex = 4;
            this.lblSenhaSistema.Text = "Senha";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(534, 3);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(55, 18);
            this.lblSistema.TabIndex = 3;
            this.lblSistema.Text = "Usuário";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(257, 72);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(59, 18);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(3, 72);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(66, 18);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(7, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(12, 406);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(172, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 437);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.tbFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.tbFuncionarios.ResumeLayout(false);
            this.tbpFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbFuncionarios;
        private System.Windows.Forms.TabPage tbpFuncionarios;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSenhaSistema;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSenhaSistema;
        private System.Windows.Forms.TextBox txtUsuarioSistema;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Função;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}