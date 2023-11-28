namespace Mini_Projeto
{
    partial class frmRelacionamentoFuncionario
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
            this.cboIDFuncionario = new System.Windows.Forms.ComboBox();
            this.cboNomeFuncionario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboIDFuncionario
            // 
            this.cboIDFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDFuncionario.FormattingEnabled = true;
            this.cboIDFuncionario.Location = new System.Drawing.Point(9, 165);
            this.cboIDFuncionario.Name = "cboIDFuncionario";
            this.cboIDFuncionario.Size = new System.Drawing.Size(276, 29);
            this.cboIDFuncionario.TabIndex = 4;
            // 
            // cboNomeFuncionario
            // 
            this.cboNomeFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboNomeFuncionario.FormattingEnabled = true;
            this.cboNomeFuncionario.Location = new System.Drawing.Point(12, 55);
            this.cboNomeFuncionario.Name = "cboNomeFuncionario";
            this.cboNomeFuncionario.Size = new System.Drawing.Size(276, 29);
            this.cboNomeFuncionario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID do funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do funcionario";
            // 
            // frmRelacionamentoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 227);
            this.Controls.Add(this.cboIDFuncionario);
            this.Controls.Add(this.cboNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRelacionamentoFuncionario";
            this.Text = "Relacionamento Funcionario";
            this.Load += new System.EventHandler(this.frmRelacionamentoFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboIDFuncionario;
        private ComboBox cboNomeFuncionario;
        private Label label2;
        private Label label1;
    }
}