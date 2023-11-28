namespace Mini_Projeto
{
    partial class frmRelacionamentoUsuario
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
            this.cboNomeUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIDUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Usuário";
            // 
            // cboNomeUsuario
            // 
            this.cboNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboNomeUsuario.FormattingEnabled = true;
            this.cboNomeUsuario.Location = new System.Drawing.Point(12, 75);
            this.cboNomeUsuario.Name = "cboNomeUsuario";
            this.cboNomeUsuario.Size = new System.Drawing.Size(249, 33);
            this.cboNomeUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Usuário";
            // 
            // cboIDUsuario
            // 
            this.cboIDUsuario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDUsuario.FormattingEnabled = true;
            this.cboIDUsuario.Location = new System.Drawing.Point(12, 170);
            this.cboIDUsuario.Name = "cboIDUsuario";
            this.cboIDUsuario.Size = new System.Drawing.Size(249, 33);
            this.cboIDUsuario.TabIndex = 1;
            // 
            // frmRelacionamentoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 252);
            this.Controls.Add(this.cboIDUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNomeUsuario);
            this.Controls.Add(this.label1);
            this.Name = "frmRelacionamentoUsuario";
            this.Text = "Relacionamento Usuario";
            this.Load += new System.EventHandler(this.frmRelacionamentoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboNomeUsuario;
        private Label label2;
        private ComboBox cboIDUsuario;
    }
}