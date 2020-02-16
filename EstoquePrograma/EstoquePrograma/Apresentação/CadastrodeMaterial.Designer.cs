namespace EstoquePrograma.Apresentação
{
    partial class CadastrodeMaterial
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDescricao2 = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblEan = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.mtxtValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(94, 190);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(242, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblDescricao2
            // 
            this.lblDescricao2.AutoSize = true;
            this.lblDescricao2.Location = new System.Drawing.Point(13, 13);
            this.lblDescricao2.Name = "lblDescricao2";
            this.lblDescricao2.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao2.TabIndex = 2;
            this.lblDescricao2.Text = "Descrição";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(271, 9);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 3;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Location = new System.Drawing.Point(13, 63);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(88, 13);
            this.lblEan.TabIndex = 4;
            this.lblEan.Text = "Código de Barras";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(271, 72);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(28, 13);
            this.lblLote.TabIndex = 5;
            this.lblLote.Text = "Lote";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 130);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(271, 130);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(48, 13);
            this.lblValidade.TabIndex = 7;
            this.lblValidade.Text = "Validade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 30);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(229, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(274, 30);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(194, 20);
            this.txtFabricante.TabIndex = 9;
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(16, 89);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(229, 20);
            this.txtEAN.TabIndex = 10;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(274, 88);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(114, 20);
            this.txtLote.TabIndex = 11;
            // 
            // mtxtValidade
            // 
            this.mtxtValidade.Location = new System.Drawing.Point(274, 145);
            this.mtxtValidade.Mask = "00/00/0000";
            this.mtxtValidade.Name = "mtxtValidade";
            this.mtxtValidade.Size = new System.Drawing.Size(100, 20);
            this.mtxtValidade.TabIndex = 13;
            this.mtxtValidade.ValidatingType = typeof(System.DateTime);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 145);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(52, 20);
            this.txtPreco.TabIndex = 14;
            // 
            // CadastrodeMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 247);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.mtxtValidade);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.lblEan);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblDescricao2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Name = "CadastrodeMaterial";
            this.Text = "Cadastro de Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescricao2;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.MaskedTextBox mtxtValidade;
        private System.Windows.Forms.TextBox txtPreco;
    }
}