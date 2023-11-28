namespace Mini_Projeto
{
    partial class mdiPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelacionamentoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCvaloresProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionamentoFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelacionamentoLocalEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelacionamentoFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(736, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuario,
            this.toolStripMenuItem1,
            this.tsmFuncionario,
            this.tsmLocalEstoque,
            this.tsmFornecedor,
            this.toolStripTextBox1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(736, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // tsmUsuario
            // 
            this.tsmUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRelacionamentoUsuarioToolStripMenuItem});
            this.tsmUsuario.Name = "tsmUsuario";
            this.tsmUsuario.Size = new System.Drawing.Size(59, 23);
            this.tsmUsuario.Text = "Usuário";
            this.tsmUsuario.Click += new System.EventHandler(this.tsmUsuario_Click);
            // 
            // tsmRelacionamentoUsuarioToolStripMenuItem
            // 
            this.tsmRelacionamentoUsuarioToolStripMenuItem.Name = "tsmRelacionamentoUsuarioToolStripMenuItem";
            this.tsmRelacionamentoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tsmRelacionamentoUsuarioToolStripMenuItem.Text = "Relacionamento Usuario";
            this.tsmRelacionamentoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tsmRelacionamentoUsuarioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCvaloresProduto});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 23);
            this.toolStripMenuItem1.Text = "Produto";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmCvaloresProduto
            // 
            this.tsmCvaloresProduto.Name = "tsmCvaloresProduto";
            this.tsmCvaloresProduto.Size = new System.Drawing.Size(206, 22);
            this.tsmCvaloresProduto.Text = "Relacionamento Produto";
            this.tsmCvaloresProduto.Click += new System.EventHandler(this.tsmCvaloresProduto_Click);
            // 
            // tsmFuncionario
            // 
            this.tsmFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relacionamentoFuncionarioToolStripMenuItem});
            this.tsmFuncionario.Name = "tsmFuncionario";
            this.tsmFuncionario.Size = new System.Drawing.Size(82, 23);
            this.tsmFuncionario.Text = "Funcionário";
            this.tsmFuncionario.Click += new System.EventHandler(this.tsmFuncionario_Click);
            // 
            // relacionamentoFuncionarioToolStripMenuItem
            // 
            this.relacionamentoFuncionarioToolStripMenuItem.Name = "relacionamentoFuncionarioToolStripMenuItem";
            this.relacionamentoFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.relacionamentoFuncionarioToolStripMenuItem.Text = "Relacionamento Funcionario";
            this.relacionamentoFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.relacionamentoFuncionarioToolStripMenuItem_Click);
            // 
            // tsmLocalEstoque
            // 
            this.tsmLocalEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRelacionamentoLocalEstoqueToolStripMenuItem});
            this.tsmLocalEstoque.Name = "tsmLocalEstoque";
            this.tsmLocalEstoque.Size = new System.Drawing.Size(92, 23);
            this.tsmLocalEstoque.Text = "Local Estoque";
            this.tsmLocalEstoque.Click += new System.EventHandler(this.tsmLocalEstoque_Click);
            // 
            // tsmRelacionamentoLocalEstoqueToolStripMenuItem
            // 
            this.tsmRelacionamentoLocalEstoqueToolStripMenuItem.Name = "tsmRelacionamentoLocalEstoqueToolStripMenuItem";
            this.tsmRelacionamentoLocalEstoqueToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.tsmRelacionamentoLocalEstoqueToolStripMenuItem.Text = "Relacionamento LocalEstoque";
            this.tsmRelacionamentoLocalEstoqueToolStripMenuItem.Click += new System.EventHandler(this.tsmRelacionamentoLocalEstoqueToolStripMenuItem_Click);
            // 
            // tsmFornecedor
            // 
            this.tsmFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRelacionamentoFornecedorToolStripMenuItem});
            this.tsmFornecedor.Name = "tsmFornecedor";
            this.tsmFornecedor.Size = new System.Drawing.Size(79, 23);
            this.tsmFornecedor.Text = "Fornecedor";
            this.tsmFornecedor.Click += new System.EventHandler(this.tsmFornecedor_Click);
            // 
            // tsmRelacionamentoFornecedorToolStripMenuItem
            // 
            this.tsmRelacionamentoFornecedorToolStripMenuItem.Name = "tsmRelacionamentoFornecedorToolStripMenuItem";
            this.tsmRelacionamentoFornecedorToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.tsmRelacionamentoFornecedorToolStripMenuItem.Text = "Relacionamento Fornecedor";
            this.tsmRelacionamentoFornecedorToolStripMenuItem.Click += new System.EventHandler(this.tsmRelacionamentoFornecedorToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Red;
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "SAIR";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mdiPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tsmUsuario;
        private ToolStripMenuItem tsmFuncionario;
        private ToolStripMenuItem tsmLocalEstoque;
        private ToolStripMenuItem tsmFornecedor;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem tsmCvaloresProduto;
        private ToolStripMenuItem relacionamentoFuncionarioToolStripMenuItem;
        private ToolStripMenuItem tsmRelacionamentoUsuarioToolStripMenuItem;
        private ToolStripMenuItem tsmRelacionamentoLocalEstoqueToolStripMenuItem;
        private ToolStripMenuItem tsmRelacionamentoFornecedorToolStripMenuItem;
    }
}



