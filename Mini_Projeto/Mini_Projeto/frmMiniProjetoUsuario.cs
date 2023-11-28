using System.Data;
using System.Data.SqlClient;

namespace Mini_Projeto
{



    public partial class frmMiniProjetoUsuario : Form
    {
        public frmMiniProjetoUsuario()
        {
            InitializeComponent();
        }

        


        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            mtxtData.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";txtObs.Text = "";
            cboStatus.SelectedIndex = -1;
            txtObs.Text = "";

            
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
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
                MessageBox.Show("Erro" + ex.ToString);

            }
        }

        private void frmMiniProjeto_Load(object sender, EventArgs e)
        {
            TestarConexao();
            DatagridCliente();
        }

        string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=t14_estoque;" +
            "User ID=sa;" +
            "Password=123456";  


        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("O campo Nome deve ser preenchido");
                    return;

                }
                if (txtLogin.Text == "")
                    
                {
                    MessageBox.Show("O campo Login deve ser preenchido");
                    return ;
                }
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("O campo Senha deve ser preenchido");
                    return;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            

                string sql = "insert into usuario" +
            "(nome_usuario,login_usuario,senha_usuario,obs_usuario)" +
            "values" + 
            "('" + txtNome.Text + "', '"+txtLogin.Text+ "',  '"+txtSenha.Text+ "', '"+txtObs.Text+"' )";

            
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
            string sql = "delete usuario where ID_usuario = " + txtCodigo.Text;
           

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
            string sql = "update usuario set " +
            //nome_usuario='', login_usuario='', senha_usuario='', obs_usuario=''
            "nome_usuario='" + txtNome.Text + "', login_usuario='" + txtLogin.Text + "', senha_usuario='" + txtSenha.Text + "', obs_usuario='" + txtObs.Text + "'" +
            "where ID_usuario = " + txtCodigo.Text;
            
            


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
            string sql = "select * from usuario where ID_usuario = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType=CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCodigo.Text = reader[0].ToString();
                    txtNome.Text = reader[1].ToString();
                    txtLogin.Text = reader[2].ToString();
                    txtSenha.Text = reader[3].ToString();
                    mtxtData.Text = reader[4].ToString();
                    txtObs.Text = reader[5].ToString();
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

        

        private void DatagridCliente()
        {
            string sql = "select id_usuario as 'ID'," +
                "nome_usuario as 'Nome'," +
                "login_usuario as 'Login'," +
                "senha_usuario as 'Senha'," +
                "data_usuario as 'Data'," +
                "status_usuario as 'Status'," +
                "obs_usuario as 'Observação' " +
                "from usuario where nome_usuario like '%" + txtNomePesquisa.Text + "%'";

            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao); 
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                adapter.Fill(ds);
                DataGridUsuario.DataSource = ds.Tables[0];
                DataGridUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DataGridUsuario.AutoResizeRow(0,DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void DataGridUsuario_CellDoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = DataGridUsuario.CurrentRow.Cells["ID"].Value.ToString();
            btoPesquisa.PerformClick();
        }
        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            DatagridCliente();
        }

    }
}

    
