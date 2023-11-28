namespace Mini_Projeto
{
    partial class frmMiniProjetoProduto
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmrQtde = new System.Windows.Forms.NumericUpDown();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVvenda = new System.Windows.Forms.TextBox();
            this.txtVcusto = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoPesquisa = new System.Windows.Forms.Button();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataGridProduto = new System.Windows.Forms.DataGridView();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtde)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoCadastrar);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Location = new System.Drawing.Point(19, 607);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(544, 19);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(84, 34);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(454, 19);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(84, 34);
            this.btoLimpar.TabIndex = 3;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(364, 20);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(84, 34);
            this.btoExcluir.TabIndex = 2;
            this.btoExcluir.Text = "Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click);
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.Location = new System.Drawing.Point(184, 20);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(84, 34);
            this.btoCadastrar.TabIndex = 0;
            this.btoCadastrar.Text = "Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(274, 19);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(84, 34);
            this.btoAlterar.TabIndex = 1;
            this.btoAlterar.Text = "Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmrQtde);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVvenda);
            this.groupBox2.Controls.Add(this.txtVcusto);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(19, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 437);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // nmrQtde
            // 
            this.nmrQtde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmrQtde.Location = new System.Drawing.Point(454, 62);
            this.nmrQtde.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrQtde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQtde.Name = "nmrQtde";
            this.nmrQtde.Size = new System.Drawing.Size(174, 29);
            this.nmrQtde.TabIndex = 1;
            this.nmrQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(454, 137);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(174, 29);
            this.cboStatus.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(454, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(242, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor de venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor de custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(454, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObs.Location = new System.Drawing.Point(6, 212);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(622, 223);
            this.txtObs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // txtVvenda
            // 
            this.txtVvenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVvenda.Location = new System.Drawing.Point(242, 137);
            this.txtVvenda.Name = "txtVvenda";
            this.txtVvenda.Size = new System.Drawing.Size(182, 29);
            this.txtVvenda.TabIndex = 3;
            this.txtVvenda.Enter += new System.EventHandler(this.txtVvenda_Enter);
            this.txtVvenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVvenda_KeyPress);
            this.txtVvenda.Leave += new System.EventHandler(this.txtVvenda_Leave);
            // 
            // txtVcusto
            // 
            this.txtVcusto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVcusto.Location = new System.Drawing.Point(6, 137);
            this.txtVcusto.Name = "txtVcusto";
            this.txtVcusto.Size = new System.Drawing.Size(182, 29);
            this.txtVcusto.TabIndex = 2;
            this.txtVcusto.TextChanged += new System.EventHandler(this.txtVcusto_TextChanged);
            this.txtVcusto.Enter += new System.EventHandler(this.txtVcusto_Enter);
            this.txtVcusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVcusto_KeyPress);
            this.txtVcusto.Leave += new System.EventHandler(this.txtVcusto_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(6, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 29);
            this.txtNome.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btoPesquisa);
            this.groupBox1.Controls.Add(this.mtxtData);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btoPesquisa
            // 
            this.btoPesquisa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoPesquisa.Location = new System.Drawing.Point(253, 62);
            this.btoPesquisa.Name = "btoPesquisa";
            this.btoPesquisa.Size = new System.Drawing.Size(49, 34);
            this.btoPesquisa.TabIndex = 1;
            this.btoPesquisa.Text = "...";
            this.btoPesquisa.UseVisualStyleBackColor = true;
            this.btoPesquisa.Click += new System.EventHandler(this.btoPesquisa_Click);
            // 
            // mtxtData
            // 
            this.mtxtData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtData.Location = new System.Drawing.Point(387, 62);
            this.mtxtData.Mask = "##/##/####";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.ReadOnly = true;
            this.mtxtData.Size = new System.Drawing.Size(241, 34);
            this.mtxtData.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(6, 62);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(241, 34);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(387, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataGridProduto);
            this.groupBox4.Controls.Add(this.txtNomePesquisa);
            this.groupBox4.Location = new System.Drawing.Point(679, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 654);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // DataGridProduto
            // 
            this.DataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProduto.Location = new System.Drawing.Point(6, 152);
            this.DataGridProduto.Name = "DataGridProduto";
            this.DataGridProduto.RowTemplate.Height = 25;
            this.DataGridProduto.Size = new System.Drawing.Size(348, 496);
            this.DataGridProduto.TabIndex = 1;
            this.DataGridProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProduto_CellClick);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomePesquisa.Location = new System.Drawing.Point(6, 62);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(348, 34);
            this.txtNomePesquisa.TabIndex = 0;
            this.txtNomePesquisa.TextChanged += new System.EventHandler(this.txtNomePesquisa_TextChanged);
            // 
            // frmMiniProjetoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1051, 678);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmMiniProjetoProduto";
            this.Text = "PRODUTO";
            this.Load += new System.EventHandler(this.frmMiniProjetoProduto_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQtde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoExcluir;
        private Button btoCadastrar;
        private Button btoAlterar;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox txtObs;
        private Label label3;
        private TextBox txtNome;
        private NumericUpDown nmrQtde;
        private ComboBox cboStatus;
        private Label label8;
        private GroupBox groupBox1;
        private Button btoPesquisa;
        private MaskedTextBox mtxtData;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private TextBox txtVvenda;
        private TextBox txtVcusto;
        private GroupBox groupBox4;
        private DataGridView DataGridProduto;
        private TextBox txtNomePesquisa;
    }
}