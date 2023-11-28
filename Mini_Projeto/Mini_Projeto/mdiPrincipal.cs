using System;
using System.Collections.Generic;
using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Projeto
{
    public partial class mdiPrincipal : Form
    {
        private int childFormNumber = 0;

        public mdiPrincipal()
        {
            InitializeComponent();
        }


        public static string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=t14_estoque;" +
            "User ID=sa;" +
            "Password=123456";

        public static string idUsuario;
        public static string nomeUsuario;
        public static string loginUsuario;



        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmMiniProjetoProduto produto = new frmMiniProjetoProduto();

            produto.Show();
            produto.MdiParent = this;
            
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        

        private void tsmUsuario_Click(object sender, EventArgs e)
        {
            frmMiniProjetoUsuario usuario = new frmMiniProjetoUsuario();

            usuario.Show();
            usuario.MdiParent = this;
        }

        private void tsmFuncionario_Click(object sender, EventArgs e)
        {
            frmMiniProjetoFuncionario funcionario = new frmMiniProjetoFuncionario();

            funcionario.Show();
            funcionario.MdiParent = this;
        }

        private void tsmLocalEstoque_Click(object sender, EventArgs e)
        {
            frmMiniProjetoLocalEstoque localEstoque = new frmMiniProjetoLocalEstoque();

            localEstoque.Show();
            localEstoque.MdiParent = this;
        }

        private void tsmFornecedor_Click(object sender, EventArgs e)
        {
            frmMiniProjetoFornecedor fornecedor = new frmMiniProjetoFornecedor();

            fornecedor.Show();
            fornecedor.MdiParent = this;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmCvaloresProduto_Click(object sender, EventArgs e)
        {
            frmRelacionamentoProduto RelProduto = new frmRelacionamentoProduto();
            RelProduto.MdiParent = this;
            RelProduto.Show();
        }

        private void relacionamentoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelacionamentoFuncionario RelFuncionario = new frmRelacionamentoFuncionario();
            RelFuncionario.MdiParent = this;
            RelFuncionario.Show();
        }

        private void tsmRelacionamentoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelacionamentoUsuario RelUsuario = new frmRelacionamentoUsuario();
            RelUsuario.MdiParent = this;
            RelUsuario.Show();
        }

        private void tsmRelacionamentoLocalEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelacionamentoLocalEstoque RelLocalEstoque = new frmRelacionamentoLocalEstoque();
            RelLocalEstoque.MdiParent = this;
            RelLocalEstoque.Show();
        }

        private void tsmRelacionamentoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelacionamentoFornecedor RelFornecedor = new frmRelacionamentoFornecedor();
            RelFornecedor.MdiParent = this;
            RelFornecedor.Show();
        }
    }
}
