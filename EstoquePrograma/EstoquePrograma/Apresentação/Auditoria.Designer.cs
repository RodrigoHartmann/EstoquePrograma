namespace EstoquePrograma.Apresentação
{
    partial class Auditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auditoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAuditoria = new System.Windows.Forms.TabPage();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtpesquisar = new System.Windows.Forms.Button();
            this.mtxtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tbAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAuditoria);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tbAuditoria
            // 
            this.tbAuditoria.Controls.Add(this.mtxtDataFinal);
            this.tbAuditoria.Controls.Add(this.mtxtDataInicial);
            this.tbAuditoria.Controls.Add(this.txtpesquisar);
            this.tbAuditoria.Controls.Add(this.lblDataFinal);
            this.tbAuditoria.Controls.Add(this.lblDataInicial);
            this.tbAuditoria.Controls.Add(this.textBox1);
            this.tbAuditoria.Controls.Add(this.lblDescricao);
            this.tbAuditoria.Controls.Add(this.dataGridView1);
            this.tbAuditoria.Location = new System.Drawing.Point(4, 22);
            this.tbAuditoria.Name = "tbAuditoria";
            this.tbAuditoria.Padding = new System.Windows.Forms.Padding(3);
            this.tbAuditoria.Size = new System.Drawing.Size(780, 406);
            this.tbAuditoria.TabIndex = 0;
            this.tbAuditoria.Text = "Auditoria";
            this.tbAuditoria.UseVisualStyleBackColor = true;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(463, 15);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lblDataFinal.TabIndex = 6;
            this.lblDataFinal.Text = "Data Final";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(331, 15);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(60, 13);
            this.lblDataInicial.TabIndex = 5;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 15);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BackColor = System.Drawing.Color.Silver;
            this.txtpesquisar.Location = new System.Drawing.Point(588, 32);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(171, 33);
            this.txtpesquisar.TabIndex = 7;
            this.txtpesquisar.Text = "Pesquisar";
            this.txtpesquisar.UseVisualStyleBackColor = false;
            // 
            // mtxtDataInicial
            // 
            this.mtxtDataInicial.Location = new System.Drawing.Point(334, 44);
            this.mtxtDataInicial.Mask = "00/00/0000";
            this.mtxtDataInicial.Name = "mtxtDataInicial";
            this.mtxtDataInicial.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataInicial.TabIndex = 8;
            this.mtxtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDataFinal
            // 
            this.mtxtDataFinal.Location = new System.Drawing.Point(466, 44);
            this.mtxtDataFinal.Mask = "00/00/0000";
            this.mtxtDataFinal.Name = "mtxtDataFinal";
            this.mtxtDataFinal.Size = new System.Drawing.Size(92, 20);
            this.mtxtDataFinal.TabIndex = 9;
            this.mtxtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.tabControl1.ResumeLayout(false);
            this.tbAuditoria.ResumeLayout(false);
            this.tbAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAuditoria;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mtxtDataFinal;
        private System.Windows.Forms.MaskedTextBox mtxtDataInicial;
        private System.Windows.Forms.Button txtpesquisar;
    }
}