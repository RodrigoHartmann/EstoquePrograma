namespace EstoquePrograma.Apresentação
{
    partial class Materiais
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvMateriais = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoMaterial = new System.Windows.Forms.Button();
            this.btnExcluirMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AllowDrop = true;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 24);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(307, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TextChanged += new System.EventHandler(this.TxtDescricao_TextChanged);
            // 
            // dgvMateriais
            // 
            this.dgvMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Fabricante,
            this.EAN,
            this.Lote,
            this.Preço,
            this.Validade});
            this.dgvMateriais.Location = new System.Drawing.Point(7, 154);
            this.dgvMateriais.Name = "dgvMateriais";
            this.dgvMateriais.RowHeadersWidth = 4;
            this.dgvMateriais.Size = new System.Drawing.Size(705, 284);
            this.dgvMateriais.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // EAN
            // 
            this.EAN.HeaderText = "EAN";
            this.EAN.Name = "EAN";
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            // 
            // Validade
            // 
            this.Validade.HeaderText = "Validade";
            this.Validade.Name = "Validade";
            // 
            // btnNovoMaterial
            // 
            this.btnNovoMaterial.Location = new System.Drawing.Point(613, 24);
            this.btnNovoMaterial.Name = "btnNovoMaterial";
            this.btnNovoMaterial.Size = new System.Drawing.Size(99, 34);
            this.btnNovoMaterial.TabIndex = 5;
            this.btnNovoMaterial.Text = "Novo";
            this.btnNovoMaterial.UseVisualStyleBackColor = true;
            this.btnNovoMaterial.Click += new System.EventHandler(this.BtnNovoMaterial_Click);
            // 
            // btnExcluirMaterial
            // 
            this.btnExcluirMaterial.Location = new System.Drawing.Point(613, 88);
            this.btnExcluirMaterial.Name = "btnExcluirMaterial";
            this.btnExcluirMaterial.Size = new System.Drawing.Size(99, 34);
            this.btnExcluirMaterial.TabIndex = 6;
            this.btnExcluirMaterial.Text = "Excluir";
            this.btnExcluirMaterial.UseVisualStyleBackColor = true;
            // 
            // Materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.btnExcluirMaterial);
            this.Controls.Add(this.btnNovoMaterial);
            this.Controls.Add(this.dgvMateriais);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Name = "Materiais";
            this.Text = "Materiais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dgvMateriais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.Button btnNovoMaterial;
        private System.Windows.Forms.Button btnExcluirMaterial;
    }
}