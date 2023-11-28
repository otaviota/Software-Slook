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
    public partial class frmMiniProjetoFornecedor : Form
    {


        public frmMiniProjetoFornecedor()
        {
            InitializeComponent();
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

                MessageBox.Show("Erro testar conexao " + ex.ToString());
                Application.Exit();
            }

        }

        private void frmMiniProjetoFornecedor_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGridFornecedor();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCodigo.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtObs.Text = "";
            mtxtCEP.Text = "";
            mtxtCNPJ.Text = "";
            mtxtData.Text = "";
            mtxtNascimento.Text = "";
            mtxtTelefone1.Text = "";
            mtxtTelefone2.Text = "";
            mtxtTelefone3.Text = "";
            mtxtTelefone4.Text = "";
            mtxtUF.Text = "";
            cboStatus.SelectedIndex = -1;
            txtContato.Text = "";
        }

       
        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            DateTime date;

            if (!DateTime.TryParse(mtxtNascimento.Text, out date))
            {
                MessageBox.Show("O campo Nascimento deve conter uma data válida");
                return;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome deve ser preenchido");
                return;
            }

            if (mtxtCNPJ.Mask.Length != 14)
            {
                MessageBox.Show("O campo CNPJ deve ser preenchido completamente");
                return;
            }
            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("O campo Logradouro deve ser preenchido");
                return;
            }
            if (txtNumero.Text == "")
            {
                MessageBox.Show("O campo numero deve ser preenchido");
                return ;
            }
            if (txtContato.Text == "")
            {
                MessageBox.Show("O campo contato deve ser preenchido");
                return;
            }
            if (mtxtCEP.Mask.Length != 9)
            {
                MessageBox.Show("O campo CEP deve ser preenchido totalmente");
                return;
            }
            if (txtBairro.Text == "")
            {
                MessageBox.Show("O campo Bairro deve ser preenchido");
                return;
            }
            if (txtCidade.Text == "")
            {
                MessageBox.Show("O campo cidade deve ser preenchido");
                return;
            }
            if (mtxtTelefone1.Mask.Length != 16)
            {
                MessageBox.Show("O campo Telefone1 deve ser preenchido totalmente");
                return;
            }
            if (mtxtUF.Mask.Length != 2)
            {
                MessageBox.Show("O campo UF deve ser preenchido totalmente");
            }




            string sql = "set dateformat dmy Insert into fornecedor" +
                "(nome_fornecedor, nasc_fornecedor, cnpj_fornecedor, logradouro_fornecedor, numero_fornecedor, cep_fornecedor, bairro_fornecedor, cidade_fornecedor, uf_fornecedor, telefone1_fornecedor, telefone2_fornecedor, telefone3_fornecedor, telefone4_fornecedor, contato_fornecedor, obs_fornecedor)" +
                "values" +
                "('"+txtNome.Text+ "', '"+mtxtNascimento.Text+ "', '"+mtxtCNPJ.Text+ "', '"+txtLogradouro.Text+ "', '"+txtNumero.Text+ "', '"+mtxtCEP.Text+ "', '"+txtBairro.Text+ "', '"+txtCidade.Text+ "', '"+mtxtUF.Text+ "', '"+mtxtTelefone1.Text+ "', '"+mtxtTelefone2.Text+ "', '"+mtxtTelefone3.Text+ "', '"+mtxtTelefone4.Text+ "', '"+txtContato.Text+ "', '"+txtObs.Text+"')";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Cadastrado com sucesso !");
                }

               


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro cadastrar" + ex.ToString());
                txtNumero.Text = "";
                
            }

            finally { conn.Close(); }
        }



        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete fornecedor where id_fornecedor = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Excluido com sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro excluir " + ex.ToString());
            }

            finally { conn.Close(); }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update fornecedor set " +
                "nome_fornecedor= '" + txtNome.Text + "', nasc_fornecedor= '" + mtxtNascimento.Text + "', cnpj_fornecedor= '" + mtxtCNPJ.Text + "', logradouro_fornecedor= '"+txtLogradouro.Text+ "', numero_fornecedor= '"+txtNumero.Text+ "', cep_fornecedor= '"+mtxtCEP.Text+ "', bairro_fornecedor= '"+txtBairro.Text+ "', cidade_fornecedor= '"+txtCidade.Text+ "', uf_fornecedor= '"+mtxtUF.Text+ "', telefone1_fornecedor= '"+mtxtTelefone2.Text+ "', telefone3_fornecedor= '"+mtxtTelefone3.Text+ "', telefone4_fornecedor= '"+mtxtTelefone4.Text+ "', contato_fornecedor= '"+txtContato.Text+ "', obs_fornecedor= '"+txtObs.Text+ "', status_fornecedor= '"+cboStatus.Text+"' " +
                "where id_fornecedor = " + txtCodigo.Text;


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();


            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Alterado com sucesso !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro alterar " + ex.ToString());
            }

            finally { conn.Close(); }
        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from fornecedor where id_fornecedor = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql,conn);
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
                    mtxtNascimento.Text = reader[2].ToString();
                    mtxtData.Text = reader[3].ToString();
                    mtxtCNPJ.Text = reader[4].ToString();
                    txtLogradouro.Text = reader[5].ToString();
                    txtNumero.Text = reader[6].ToString();
                    mtxtCEP.Text = reader[7].ToString();
                    txtBairro.Text = reader[8].ToString();
                    txtCidade.Text = reader[9].ToString();
                    mtxtUF.Text = reader[10].ToString();
                    mtxtTelefone1.Text = reader[11].ToString();
                    mtxtTelefone2.Text = reader[12].ToString();
                    mtxtTelefone3.Text = reader[13].ToString();
                    mtxtTelefone4.Text = reader[14].ToString();
                    txtContato.Text = reader[15].ToString();
                    txtObs.Text = reader[16].ToString();
                    cboStatus.Text = reader[17].ToString();

                }

                else
                {
                    MessageBox.Show("Este código de fornecedor nao existe");
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro Pesquisa " + ex.ToString());
            }

            finally { conn.Close(); }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void mtxtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void mtxtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mtxtNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mtxtTelefone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mtxtTelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mtxtTelefone3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mtxtTelefone4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtxtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CarregarDataGridFornecedor()
        {
            string sql = "select id_fornecedor as 'ID'," +
                "nome_fornecedor as 'Nome'," +
                "nasc_fornecedor as 'Nascimento'," +
                "data_fornecedor as 'Data'," +
                "cnpj_fornecedor as 'CNPJ'," +
                "logradouro_fornecedor as 'Logradouro'," +
                "numero_fornecedor as 'Numero'," +
                "cep_fornecedor as 'CEP'," +
                "bairro_fornecedor as 'Bairro'," +
                "cidade_fornecedor as 'Cidade'," +
                "uf_fornecedor as 'UF'," +
                "telefone1_fornecedor as 'Telefone1'," +
                "telefone2_fornecedor as 'Telefone2'," +
                "telefone3_fornecedor as 'Telefone3'," +
                "telefone4_fornecedor as 'Telefone4'," +
                "contato_fornecedor as 'Contato'," +
                "obs_fornecedor as 'Observação'," +
                "status_fornecedor as 'Status'" +
                "from fornecedor where nome_fornecedor like '%" + txtNomePesquisa.Text + "%'";

            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                
                DataGridFornecedor.DataSource = ds.Tables[0];
                
                DataGridFornecedor.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DataGridFornecedor.AutoResizeRow(0,DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro  " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGridFornecedor();
        }

        private void DataGridFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = DataGridFornecedor.CurrentRow.Cells["ID"].Value.ToString();
            btoPesquisa.PerformClick();
        }
    }
}
