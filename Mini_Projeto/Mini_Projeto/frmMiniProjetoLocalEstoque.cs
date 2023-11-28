using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_Projeto
{
    public partial class frmMiniProjetoLocalEstoque : Form
    {
        public frmMiniProjetoLocalEstoque()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtObs.Text = "";
            mtxtData.Text = "";
            cboStatus.SelectedIndex = -1;
        }

        string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=t14_estoque;" +
            "User ID=sa;" +
            "Password=123456";


        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.ToString());

            }
        }


        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome deve ser preenchido");
                return;
            }


            string sql = "insert into localestoque" +
                "(nome_localestoque, obs_localestoque)" +
                "Values" +
                "('" + txtNome.Text + "', '" + txtObs.Text + "')";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro  " + ex.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete localestoque where id_localestoque = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();


            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Excluído com sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update localestoque set " +
                "nome_localestoque = '" + txtNome.Text + "', obs_localestoque= '" + txtObs.Text + "' where id_localestoque = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open ();


            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Alterado com sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.ToString());

            }

            finally
            {
                conn.Close();
            }

        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from localestoque where id_localestoque = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand (sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCodigo.Text = reader[0].ToString();
                    txtNome.Text = reader[1].ToString();
                    mtxtData.Text = reader[2].ToString();
                    txtObs.Text = reader[3].ToString();
                    cboStatus.Text = reader[4].ToString();
                }
                else
                {
                    MessageBox.Show("O codigo de LocalEstoque nao existe");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.ToString());
            }

            finally { conn.Close(); }
        }

        private void frmMiniProjetoLocalEstoque_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDatagridLE();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CarregarDatagridLE()
        {
            string sql = "select id_localestoque as 'ID'," +
                "nome_localestoque as 'Nome'," +
                "data_localestoque as 'Data'," +
                "obs_localestoque as 'Observação'," +
                "status_localestoque as 'Status'" +
                " from localestoque where nome_localestoque like '%" + txtNomePesquisa.Text + "%'";

            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                adapter.Fill(ds);

                DatagridLE.DataSource = ds.Tables[0];
                DatagridLE.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DatagridLE.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro    " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void DatagridLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = DatagridLE.CurrentRow.Cells["ID"].Value.ToString();
            btoPesquisa.PerformClick();
        }

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDatagridLE();
        }
    }
}