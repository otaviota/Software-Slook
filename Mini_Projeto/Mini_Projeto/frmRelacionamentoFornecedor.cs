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
    public partial class frmRelacionamentoFornecedor : Form
    {
        public frmRelacionamentoFornecedor()
        {
            InitializeComponent();
        }

        private void testarConexao()
        {
            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao);

            try
            {
                conn.Open();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro  " + ex.ToString());
            }



        }

        private void CarregarComboFornecedor()
        {
            string sql = "select id_fornecedor, nome_fornecedor from fornecedor";

            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            DataTable tabela = new DataTable();
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                tabela.Load(reader);

                cboIDFornecedor.DisplayMember = "id_fornecedor";
                cboIDFornecedor.DataSource = tabela;

                cboNomeFornecedor.DisplayMember = "nome_fornecedor";
                cboNomeFornecedor.DataSource = tabela;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erroooo" + ex.ToString);
            }
            finally { conn.Close(); }


        }

        private void frmRelacionamentoFornecedor_Load(object sender, EventArgs e)
        {
            testarConexao();
            CarregarComboFornecedor();
        }
    }
}
