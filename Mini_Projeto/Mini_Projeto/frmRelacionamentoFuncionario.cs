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
    public partial class frmRelacionamentoFuncionario : Form
    {
        public frmRelacionamentoFuncionario()
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

                MessageBox.Show("Erooou  " + ex.ToString());
            }
        }

        private void CarregarComboFuncionario()
        {
            string sql = "Select id_funcionario, nome_funcionario from funcionario";

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

                cboIDFuncionario.DisplayMember = "id_funcionario";  
                cboIDFuncionario.DataSource = tabela;

                cboNomeFuncionario.DisplayMember = "nome_funcionario";
                cboNomeFuncionario.DataSource = tabela;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro   " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void frmRelacionamentoFuncionario_Load(object sender, EventArgs e)
        {
            testarConexao();
            CarregarComboFuncionario();
        }
    }
}
