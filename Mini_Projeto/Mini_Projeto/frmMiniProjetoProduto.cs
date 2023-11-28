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
    public partial class frmMiniProjetoProduto : Form
    {
        public frmMiniProjetoProduto()
        {
            InitializeComponent();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtObs.Text = "";
            txtVcusto.Text = "";
            txtVvenda.Text = "";
            nmrQtde.Text = "";
            cboStatus.SelectedIndex = -1;
            mtxtData.Text = "";
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
            
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

        private void frmMiniProjetoProduto_Load(object sender, EventArgs e)
                {
                    TestarConexao();
                    CarregarDataGridProduto();
                }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo nome deve ser preenchido");
                return;
            }
            if (txtVcusto.Text == "")
            {
                MessageBox.Show("O campo valor de custo deve ser preenchido");
                return;

            }
            if (txtVvenda.Text == "")
            {
                MessageBox.Show("O campo Valor de venda deve ser preenchido");
                return;
            }
            

            string vCusto = txtVcusto.Text;

            vCusto = vCusto.Replace("R$ ", "");
            vCusto = vCusto.Replace(",", "."); 

            string vVenda = txtVvenda.Text;

            vVenda = vVenda.Replace("R$ ", "");
            vVenda = vVenda.Replace(",", ".");
            
            
            string sql = "insert into produto" +
            "(nome_produto,qtde_produto,vcusto_produto,vvenda_produto,obs_produto)" +
            "values" +
            "('" + txtNome.Text + "', '" + nmrQtde.Text + "', '" + vCusto + "', '" + vVenda + "', '" + txtObs.Text + "')";


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro coisado com sucesso");
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





        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete produto where ID_produto = " + txtCodigo.Text;


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Exluiu com sucesso");
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
            string sql = "update produto set " +
            
            "nome_produto='" + txtNome.Text + "', qtde_produto='" + nmrQtde.Text + "', Vcusto_produto='" + txtVcusto.Text + "'" +
            "where id_produto = " + txtCodigo.Text;




            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

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

                MessageBox.Show("Erro" + ex.ToString());

            }
            finally
            {
                conn.Close();
            }
        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from produto where id_produto = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
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
                    nmrQtde.Text = reader[3].ToString();
                    txtVcusto.Text = reader[4].ToString();
                    txtVvenda.Text = reader[5].ToString();
                    txtObs.Text = reader[6].ToString();
                    cboStatus.Text = reader[6].ToString();
                }
                else
                {
                    MessageBox.Show("Código do usuário inexistente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVcusto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVcusto_Enter(object sender, EventArgs e)
        {
            txtVcusto.Text = txtVcusto.Text.Replace("R$", "");
        }

        private void txtVcusto_Leave(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtVcusto.Text, out valor))
            {
                txtVcusto.Text = valor.ToString("C");   

            }

            else
            {
                txtVcusto.Text = "";
            }
        }

        private void txtVvenda_Leave(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtVvenda.Text, out valor))
            {
                txtVvenda.Text = valor.ToString("C");
            }


        }

        private void txtVvenda_Enter(object sender, EventArgs e)
        {
            txtVvenda.Text = txtVvenda.Text.Replace("R$", "");
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVcusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void txtVvenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CarregarDataGridProduto()
        {
            string sql = "select id_produto as 'ID'," +
                "nome_produto as 'Nome'," +
                "data_produto as 'Data'," +
                "qtde_produto as 'Quantidade'," +
                "vcusto_produto as 'Valor de Custo'," +
                "vvenda_produto as 'Valor de Venda'," +
                "obs_produto as 'Observação'," +
                "status_produto as 'Statuss'" +
                " from produto where nome_produto like '%" + txtNomePesquisa.Text + "%'";


            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                adapter.Fill(ds);
                DataGridProduto.DataSource = ds.Tables[0];
                DataGridProduto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DataGridProduto.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro  " + ex.ToString());

            }
            finally { conn.Close(); }



        }

        private void DataGridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = DataGridProduto.CurrentRow.Cells["ID"].Value.ToString();
            btoPesquisa.PerformClick();
        }

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGridProduto();
        }
    }
}
