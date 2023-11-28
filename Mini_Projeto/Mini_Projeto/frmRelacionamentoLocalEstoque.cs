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
    public partial class frmRelacionamentoLocalEstoque : Form
    {
        public frmRelacionamentoLocalEstoque()
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

                MessageBox.Show("Eroo " + ex.ToString());
            }
        }

        private void CarregarComboLocalEstoque()
        {
            string sql = "select id_localestoque, nome_localestoque from localestoque";

            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            DataTable tabela = new DataTable();
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                tabela.Load(reader);

                cboIDLocalEstoque.DisplayMember = "id_localestoque";
                cboIDLocalEstoque.DataSource = tabela;

                cboNomeLocalEstoque.DisplayMember = "nome_localestoque";
                cboNomeLocalEstoque.DataSource = tabela;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void frmRelacionamentoLocalEstoque_Load(object sender, EventArgs e)
        {
            testarConexao();
            CarregarComboLocalEstoque();
        }
    }
}
