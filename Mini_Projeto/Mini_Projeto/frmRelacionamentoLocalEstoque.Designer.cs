namespace Mini_Projeto
{
    partial class frmRelacionamentoLocalEstoque
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
            this.cboIDLocalEstoque = new System.Windows.Forms.ComboBox();
            this.cboNomeLocalEstoque = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboIDLocalEstoque
            // 
            this.cboIDLocalEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDLocalEstoque.FormattingEnabled = true;
            this.cboIDLocalEstoque.Location = new System.Drawing.Point(9, 192);
            this.cboIDLocalEstoque.Name = "cboIDLocalEstoque";
            this.cboIDLocalEstoque.Size = new System.Drawing.Size(276, 29);
            this.cboIDLocalEstoque.TabIndex = 8;
            // 
            // cboNomeLocalEstoque
            // 
            this.cboNomeLocalEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboNomeLocalEstoque.FormattingEnabled = true;
            this.cboNomeLocalEstoque.Location = new System.Drawing.Point(12, 82);
            this.cboNomeLocalEstoque.Name = "cboNomeLocalEstoque";
            this.cboNomeLocalEstoque.Size = new System.Drawing.Size(276, 29);
            this.cboNomeLocalEstoque.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID do Local de Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Local de Estoque";
            // 
            // frmRelacionamentoLocalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 283);
            this.Controls.Add(this.cboIDLocalEstoque);
            this.Controls.Add(this.cboNomeLocalEstoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRelacionamentoLocalEstoque";
            this.Text = "Relacionamento LocalEstoque";
            this.Load += new System.EventHandler(this.frmRelacionamentoLocalEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboIDLocalEstoque;
        private ComboBox cboNomeLocalEstoque;
        private Label label2;
        private Label label1;
    }
}