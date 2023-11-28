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
    public partial class frmRelacionamentoUsuario : Form
    {
        public frmRelacionamentoUsuario()
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

                MessageBox.Show("ERRO  " + ex.ToString());
            }
        }
        private void CarregarComboUsuario()
        {
            string sql = "select id_usuario, nome_usuario from usuario";

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

                cboIDUsuario.DisplayMember = "id_usuario";
                cboIDUsuario.DataSource = tabela;

                cboNomeUsuario.DisplayMember = "nome_usuario";
                cboNomeUsuario.DataSource = tabela;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Errro " + ex.ToString());
            }
            finally { conn.Close(); }
        }
        private void frmRelacionamentoUsuario_Load(object sender, EventArgs e)
        {
            testarConexao();
            CarregarComboUsuario();
        }
    }
}
