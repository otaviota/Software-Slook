namespace Mini_Projeto
{
    partial class frmRelacionamentoFornecedor
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
            this.cboIDFornecedor = new System.Windows.Forms.ComboBox();
            this.cboNomeFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboIDFornecedor
            // 
            this.cboIDFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDFornecedor.FormattingEnabled = true;
            this.cboIDFornecedor.Location = new System.Drawing.Point(12, 151);
            this.cboIDFornecedor.Name = "cboIDFornecedor";
            this.cboIDFornecedor.Size = new System.Drawing.Size(276, 29);
            this.cboIDFornecedor.TabIndex = 12;
            // 
            // cboNomeFornecedor
            // 
            this.cboNomeFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboNomeFornecedor.FormattingEnabled = true;
            this.cboNomeFornecedor.Location = new System.Drawing.Point(15, 41);
            this.cboNomeFornecedor.Name = "cboNomeFornecedor";
            this.cboNomeFornecedor.Size = new System.Drawing.Size(276, 29);
            this.cboNomeFornecedor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID do Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do Fornecedor";
            // 
            // frmRelacionamentoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 222);
            this.Controls.Add(this.cboIDFornecedor);
            this.Controls.Add(this.cboNomeFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRelacionamentoFornecedor";
            this.Text = "Relacionamento Fornecedor";
            this.Load += new System.EventHandler(this.frmRelacionamentoFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboIDFornecedor;
        private ComboBox cboNomeFornecedor;
        private Label label2;
        private Label label1;
    }
}