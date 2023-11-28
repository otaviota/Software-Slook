namespace Mini_Projeto
{
    partial class frmMiniProjetoLocalEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoPesquisa = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.DatagridLE = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridLE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(7, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 29);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(7, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 29);
            this.txtNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(222, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(364, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 0;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObs.Location = new System.Drawing.Point(7, 179);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(444, 198);
            this.txtObs.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btoPesquisa);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.mtxtData);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 392);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btoPesquisa
            // 
            this.btoPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoPesquisa.Location = new System.Drawing.Point(93, 47);
            this.btoPesquisa.Name = "btoPesquisa";
            this.btoPesquisa.Size = new System.Drawing.Size(53, 29);
            this.btoPesquisa.TabIndex = 1;
            this.btoPesquisa.Text = "...";
            this.btoPesquisa.UseVisualStyleBackColor = true;
            this.btoPesquisa.Click += new System.EventHandler(this.btoPesquisa_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(364, 103);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(87, 29);
            this.cboStatus.TabIndex = 4;
            // 
            // mtxtData
            // 
            this.mtxtData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtData.Location = new System.Drawing.Point(222, 103);
            this.mtxtData.Mask = "##/##/####";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.ReadOnly = true;
            this.mtxtData.Size = new System.Drawing.Size(113, 29);
            this.mtxtData.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoCadastrar);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Location = new System.Drawing.Point(12, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 59);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(367, 19);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(84, 34);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(277, 19);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(84, 34);
            this.btoLimpar.TabIndex = 3;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(187, 20);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(84, 34);
            this.btoExcluir.TabIndex = 2;
            this.btoExcluir.Text = "Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click);
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.Location = new System.Drawing.Point(7, 20);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(84, 34);
            this.btoCadastrar.TabIndex = 0;
            this.btoCadastrar.Text = "Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(97, 19);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(84, 34);
            this.btoAlterar.TabIndex = 1;
            this.btoAlterar.Text = "Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DatagridLE);
            this.groupBox2.Controls.Add(this.txtNomePesquisa);
            this.groupBox2.Location = new System.Drawing.Point(488, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 457);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomePesquisa.Location = new System.Drawing.Point(6, 17);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(325, 29);
            this.txtNomePesquisa.TabIndex = 0;
            this.txtNomePesquisa.TextChanged += new System.EventHandler(this.txtNomePesquisa_TextChanged);
            // 
            // DatagridLE
            // 
            this.DatagridLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridLE.Location = new System.Drawing.Point(6, 52);
            this.DatagridLE.Name = "DatagridLE";
            this.DatagridLE.RowTemplate.Height = 25;
            this.DatagridLE.Size = new System.Drawing.Size(325, 399);
            this.DatagridLE.TabIndex = 1;
            this.DatagridLE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridLE_CellClick);
            // 
            // frmMiniProjetoLocalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(841, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMiniProjetoLocalEstoque";
            this.Text = "LOCAL ESTOQUE";
            this.Load += new System.EventHandler(this.frmMiniProjetoLocalEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridLE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtObs;
        private GroupBox groupBox1;
        private ComboBox cboStatus;
        private MaskedTextBox mtxtData;
        private Label label6;
        private GroupBox groupBox3;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoExcluir;
        private Button btoCadastrar;
        private Button btoAlterar;
        private Button btoPesquisa;
        private GroupBox groupBox2;
        private DataGridView DatagridLE;
        private TextBox txtNomePesquisa;
    }
}