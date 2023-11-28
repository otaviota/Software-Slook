namespace Mini_Projeto
{
    partial class frmRelacionamentoProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboNomeProduto = new System.Windows.Forms.ComboBox();
            this.cboIDProduto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID do produto";
            // 
            // cboNomeProduto
            // 
            this.cboNomeProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboNomeProduto.FormattingEnabled = true;
            this.cboNomeProduto.Location = new System.Drawing.Point(15, 65);
            this.cboNomeProduto.Name = "cboNomeProduto";
            this.cboNomeProduto.Size = new System.Drawing.Size(276, 29);
            this.cboNomeProduto.TabIndex = 1;
            // 
            // cboIDProduto
            // 
            this.cboIDProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDProduto.FormattingEnabled = true;
            this.cboIDProduto.Location = new System.Drawing.Point(12, 179);
            this.cboIDProduto.Name = "cboIDProduto";
            this.cboIDProduto.Size = new System.Drawing.Size(276, 29);
            this.cboIDProduto.TabIndex = 1;
            // 
            // frmRelacionamentoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 238);
            this.Controls.Add(this.cboIDProduto);
            this.Controls.Add(this.cboNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRelacionamentoProduto";
            this.Text = "Relacionamento Produto";
            this.Load += new System.EventHandler(this.frmRelacionamentoProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboNomeProduto;
        private ComboBox cboIDProduto;
    }
}