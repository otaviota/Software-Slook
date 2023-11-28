namespace Mini_Projeto
{
    partial class frmMiniProjetoFornecedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btoPesquisa = new System.Windows.Forms.Button();
            this.mtxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.mtxtTelefone4 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtUF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.DataGridFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtData);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btoPesquisa);
            this.groupBox1.Controls.Add(this.mtxtNascimento);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mtxtData
            // 
            this.mtxtData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtData.Location = new System.Drawing.Point(575, 62);
            this.mtxtData.Mask = "##/##/####";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.ReadOnly = true;
            this.mtxtData.Size = new System.Drawing.Size(213, 34);
            this.mtxtData.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(575, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Data";
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
            // mtxtNascimento
            // 
            this.mtxtNascimento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtNascimento.Location = new System.Drawing.Point(318, 62);
            this.mtxtNascimento.Mask = "##/##/####";
            this.mtxtNascimento.Name = "mtxtNascimento";
            this.mtxtNascimento.Size = new System.Drawing.Size(241, 34);
            this.mtxtNascimento.TabIndex = 2;
            this.mtxtNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtNascimento_KeyPress);
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
            this.label2.Location = new System.Drawing.Point(318, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nascimento";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoCadastrar);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Location = new System.Drawing.Point(12, 734);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(704, 19);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(84, 34);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(614, 19);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(84, 34);
            this.btoLimpar.TabIndex = 3;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(524, 20);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(84, 34);
            this.btoExcluir.TabIndex = 2;
            this.btoExcluir.Text = "Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click);
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.Location = new System.Drawing.Point(344, 20);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(84, 34);
            this.btoCadastrar.TabIndex = 0;
            this.btoCadastrar.Text = "Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(434, 19);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(84, 34);
            this.btoAlterar.TabIndex = 1;
            this.btoAlterar.Text = "Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.mtxtTelefone4);
            this.groupBox2.Controls.Add(this.mtxtUF);
            this.groupBox2.Controls.Add(this.mtxtTelefone2);
            this.groupBox2.Controls.Add(this.mtxtTelefone3);
            this.groupBox2.Controls.Add(this.mtxtTelefone1);
            this.groupBox2.Controls.Add(this.mtxtCEP);
            this.groupBox2.Controls.Add(this.mtxtCNPJ);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtContato);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 581);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(570, 200);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 29);
            this.cboStatus.TabIndex = 11;
            // 
            // mtxtTelefone4
            // 
            this.mtxtTelefone4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtTelefone4.Location = new System.Drawing.Point(202, 269);
            this.mtxtTelefone4.Mask = "## ## # ########";
            this.mtxtTelefone4.Name = "mtxtTelefone4";
            this.mtxtTelefone4.Size = new System.Drawing.Size(174, 29);
            this.mtxtTelefone4.TabIndex = 13;
            this.mtxtTelefone4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTelefone4_KeyPress);
            // 
            // mtxtUF
            // 
            this.mtxtUF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtUF.Location = new System.Drawing.Point(382, 200);
            this.mtxtUF.Mask = "LL";
            this.mtxtUF.Name = "mtxtUF";
            this.mtxtUF.Size = new System.Drawing.Size(86, 29);
            this.mtxtUF.TabIndex = 10;
            this.mtxtUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtUF_KeyPress);
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtTelefone2.Location = new System.Drawing.Point(202, 200);
            this.mtxtTelefone2.Mask = "## ## # ########";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(174, 29);
            this.mtxtTelefone2.TabIndex = 9;
            this.mtxtTelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTelefone2_KeyPress);
            // 
            // mtxtTelefone3
            // 
            this.mtxtTelefone3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtTelefone3.Location = new System.Drawing.Point(6, 269);
            this.mtxtTelefone3.Mask = "## ## # ########";
            this.mtxtTelefone3.Name = "mtxtTelefone3";
            this.mtxtTelefone3.Size = new System.Drawing.Size(182, 29);
            this.mtxtTelefone3.TabIndex = 12;
            this.mtxtTelefone3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTelefone3_KeyPress);
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtTelefone1.Location = new System.Drawing.Point(6, 200);
            this.mtxtTelefone1.Mask = "## ## # ########";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(182, 29);
            this.mtxtTelefone1.TabIndex = 8;
            this.mtxtTelefone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTelefone1_KeyPress);
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtCEP.Location = new System.Drawing.Point(194, 137);
            this.mtxtCEP.Mask = "#####-###";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(182, 29);
            this.mtxtCEP.TabIndex = 5;
            this.mtxtCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCEP_MaskInputRejected);
            this.mtxtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCEP_KeyPress);
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtCNPJ.Location = new System.Drawing.Point(194, 62);
            this.mtxtCNPJ.Mask = "###.###.###-##";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(182, 29);
            this.mtxtCNPJ.TabIndex = 1;
            this.mtxtCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCNPJ_MaskInputRejected);
            this.mtxtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCNPJ_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(570, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(382, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(194, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(202, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "CNPJ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Observações";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(6, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "Contato";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObs.Location = new System.Drawing.Point(6, 348);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(782, 221);
            this.txtObs.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(202, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 28);
            this.label17.TabIndex = 0;
            this.label17.Text = "Telefone 4";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(570, 62);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(182, 29);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(202, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "Telefone 2";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.Location = new System.Drawing.Point(382, 62);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(182, 29);
            this.txtLogradouro.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "Telefone 3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(570, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 28);
            this.label18.TabIndex = 0;
            this.label18.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(382, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(570, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(382, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefone ";
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
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(570, 137);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(182, 29);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(382, 137);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(182, 29);
            this.txtBairro.TabIndex = 6;
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContato.Location = new System.Drawing.Point(6, 137);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(182, 29);
            this.txtContato.TabIndex = 4;
            this.txtContato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContato_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(6, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 29);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNomePesquisa);
            this.groupBox4.Controls.Add(this.DataGridFornecedor);
            this.groupBox4.Location = new System.Drawing.Point(826, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(619, 787);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomePesquisa.Location = new System.Drawing.Point(6, 62);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(607, 34);
            this.txtNomePesquisa.TabIndex = 1;
            this.txtNomePesquisa.TextChanged += new System.EventHandler(this.txtNomePesquisa_TextChanged);
            // 
            // DataGridFornecedor
            // 
            this.DataGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFornecedor.Location = new System.Drawing.Point(6, 141);
            this.DataGridFornecedor.Name = "DataGridFornecedor";
            this.DataGridFornecedor.RowTemplate.Height = 25;
            this.DataGridFornecedor.Size = new System.Drawing.Size(607, 569);
            this.DataGridFornecedor.TabIndex = 0;
            this.DataGridFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFornecedor_CellClick);
            // 
            // frmMiniProjetoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(1461, 803);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmMiniProjetoFornecedor";
            this.Text = "FORNECEDOR";
            this.Load += new System.EventHandler(this.frmMiniProjetoFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtxtData;
        private Label label9;
        private Button btoPesquisa;
        private MaskedTextBox mtxtNascimento;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoExcluir;
        private Button btoCadastrar;
        private Button btoAlterar;
        private GroupBox groupBox2;
        private ComboBox cboStatus;
        private MaskedTextBox mtxtTelefone4;
        private MaskedTextBox mtxtUF;
        private MaskedTextBox mtxtTelefone2;
        private MaskedTextBox mtxtTelefone3;
        private MaskedTextBox mtxtTelefone1;
        private MaskedTextBox mtxtCEP;
        private MaskedTextBox mtxtCNPJ;
        private Label label11;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox txtObs;
        private Label label17;
        private TextBox txtNumero;
        private Label label16;
        private TextBox txtLogradouro;
        private Label label15;
        private Label label18;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label3;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtNome;
        private Label label19;
        private TextBox txtContato;
        private Label label6;
        private GroupBox groupBox4;
        private TextBox txtNomePesquisa;
        private DataGridView DataGridFornecedor;
    }
}