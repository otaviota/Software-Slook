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
    public partial class frmMiniProjetoFuncionario : Form
    {
        public frmMiniProjetoFuncionario()
        {
            InitializeComponent();
        }


        

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCodigo.Text = "";
            txtComp.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtObs.Text = "";
            mtxtCEP.Text = "";
            mtxtCPF.Text = "";
            mtxtData.Text = "";
            mtxtNascimento.Text = "";
            mtxtTelefone1.Text = "";
            mtxtTelefone2.Text = "";
            mtxtTelefone3.Text = "";
            mtxtTelefone4.Text = "";
            mtxtUF.Text = "";
            cboStatus.SelectedIndex = -1;

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

                MessageBox.Show ("Erro" + ex.ToString());
            }
        }

        private void frmMiniProjetoFuncionario_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDatagridFuncionario();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome deve ser preenchido");
                return;
            }

            if (txtNumero.Text == "")
            {
                MessageBox.Show("O campo Numero deve ser preenchido");
                return;
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("O campo Bairro deve ser preenchido");
                return;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("O campo Cidade deve ser preenchido");
                return;

            }

            if (txtComp.Text == "")
            {
                MessageBox.Show("O campo Complemento deve ser preenchido");
                return;
            }

            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("O campo Logradouro deve ser preenchido");
                return;
            }

            if (mtxtCEP.Text == "")
            {
                MessageBox.Show("O campo CEP deve ser preenchido");
                return;
            }
            if (mtxtCEP.Mask.Length != 9)
            {
                MessageBox.Show("O campo CEP deve ser preenchido completamente");
                return ;
            }

            if (mtxtCPF.Text == "")
            {
                MessageBox.Show("O campo CPF deve ser preenchido");
                return;
            }
            if (mtxtCPF.Mask.Length != 14)
            {
                MessageBox.Show("O campo CPF deve ser preenchido completamente");
                return;
            }
            
            //if (mtxtNascimento.Text == "")
            //{
            //    MessageBox.Show("O campo nascimento deve ser preenchido");
            //    return;
            //}

            DateTime data;

            if (!DateTime.TryParse(mtxtNascimento.Text, out data))
            {
                MessageBox.Show("O campo Nascimento deve conter uma data válida");
                return;
            }

            if (mtxtTelefone1.Text == "")
            {
                MessageBox.Show("O campo Telefone 1 deve ser preenchido");
                return;
            }
            if (mtxtTelefone1.Mask.Length != 16)
            {
                MessageBox.Show("O campo telefone1 deve ser preenchido completamente");
                return;
            }

            if (mtxtUF.Text == "")
            {
                MessageBox.Show("O campo UF deve ser preenchido");
                return;
            }
            if (mtxtUF.Mask.Length != 2)
            {
                MessageBox.Show("O campo UF deve ser preenchido completamente");
                return;
            }


                       

            string sql = "set dateformat dmy insert into funcionario" +
                 "(nome_funcionario, nasc_funcionario, cpf_funcionario, logradouro_funcionario, numero_funcionario, comp_funcionario, cep_funcionario, bairro_funcionario, cidade_funcionario, uf_funcionario, telefone1_funcionario, telefone2_funcionario, telefone3_funcionario, telefone4_funcionario, obs_funcionario)" +
                 "values" +
                 " ('" + txtNome.Text + "', '"+mtxtNascimento.Text+ "', '"+mtxtCPF.Text+ "', '"+txtLogradouro.Text+ "', '"+txtNumero.Text+ "','"+txtComp.Text+ "', '"+mtxtCEP.Text+ "', '"+txtBairro.Text+ "', '"+txtCidade.Text+ "', '"+mtxtUF.Text+ "', '"+mtxtTelefone1.Text+ "', '"+mtxtTelefone2.Text+ "', '"+mtxtTelefone3.Text+ "', '"+mtxtTelefone4.Text+ "', '"+txtObs.Text+ "') ";
            
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

               MessageBox.Show ("Erro" + ex.ToString());

            }

            finally
            {
                conn.Close();
            }
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
                string sql = "delete funcionario where id_funcionario = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand (sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open ();

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

                MessageBox.Show ("Erro, " + ex.ToString());
            }

            finally
            {
                conn.Close ();
            }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
                string sql = "update funcionario set " +
                "nome_funcionario = '"+txtNome.Text+"', nasc_funcionario= '"+mtxtNascimento.Text+ "', cpf_funcionario= '"+mtxtCPF.Text+ "', logradouro_funcionario= '"+txtLogradouro.Text+ "', numero_funcionario= '"+txtNumero.Text+ "', comp_funcionario= '"+txtComp.Text+ "',  cep_funcionario= '"+mtxtCEP.Text+ "', bairro_funcionario= '"+txtBairro.Text+ "', cidade_funcionario= '"+txtCidade.Text+ "', uf_funcionario= '"+mtxtUF.Text+ "', telefone1_funcionario= '"+mtxtTelefone1.Text+ "', telefone2_funcionario= '" + mtxtTelefone2.Text + "', telefone3_funcionario= '" + mtxtTelefone3.Text + "', telefone4_funcionario= '" + mtxtTelefone4.Text + "', obs_funcionario= '"+txtObs.Text+"' " +
                "where id_funcionario = " + txtCodigo.Text;

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

                MessageBox.Show("Erro" + ex.ToString());
                conn.Close ();
            }
            finally
            {
                conn.Close ();
            }
        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
                string sql = "select * from funcionario where id_funcionario = " + txtCodigo.Text;

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
                    mtxtNascimento.Text = reader[2].ToString();
                    mtxtData.Text = reader[3].ToString();
                    mtxtCPF.Text = reader[4].ToString();
                    txtLogradouro.Text = reader[5].ToString();
                    txtNumero.Text = reader[6].ToString();
                    txtComp.Text = reader[7].ToString();
                    mtxtCEP.Text = reader[8].ToString();
                    txtBairro.Text = reader[9].ToString();
                    txtCidade.Text = reader[10].ToString();
                    mtxtUF.Text = reader[11].ToString();
                    mtxtTelefone1.Text = reader[12].ToString();
                    mtxtTelefone2.Text = reader[13].ToString();
                    mtxtTelefone3.Text = reader[14].ToString();
                    mtxtTelefone4.Text = reader[15].ToString();
                    txtObs.Text = reader[16].ToString();
                    cboStatus.Text = reader[17].ToString();
                }
                else
                {
                    MessageBox.Show("Código de usuário inexistente");
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

        private void mtxtNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mtxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && !char.IsSeparator(e.KeyChar))
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

        private void mtxtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CarregarDatagridFuncionario()
        {
            string sql = "select id_funcionario as 'ID'," +
                "nome_funcionario as 'Nome'," +
                "nasc_funcionario as 'Nascimento'," +
                "data_funcionario as 'Data'," +
                "cpf_funcionario as 'CPF'," +
                "logradouro_funcionario as 'Logradouro'," +
                "numero_funcionario as 'Numero'," +
                "comp_funcionario as 'Complemento'," +
                "cep_funcionario as 'CEP'," +
                "bairro_funcionario as 'Bairro'," +
                "cidade_funcionario as 'Cidade'," +
                "uf_funcionario as 'UF'," +
                "telefone1_funcionario as 'Telefone 1'," +
                "telefone2_funcionario as 'Telefone 2'," +
                "telefone3_funcionario as 'Telefone 3'," +
                "telefone4_funcionario as 'Telefone 4'," +
                "obs_funcionario as 'Observação'," +
                "status_funcionario as 'Status'" +
                " from funcionario where nome_funcionario like '%" + txtNomePesquisa.Text + "%'";


            SqlConnection conn = new SqlConnection(mdiPrincipal.stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            conn.Open();


            try
            {
                adapter.Fill(ds);
                
                DataGridFuncionario.DataSource = ds.Tables[0];
                DataGridFuncionario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DataGridFuncionario.AutoResizeRow(0,DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

            }
            catch (Exception ex)
            {           

                MessageBox.Show("Erro    " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDatagridFuncionario();
        }

        private void DataGridFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = DataGridFuncionario.CurrentRow.Cells["ID"].Value.ToString();
            btoPesquisa.PerformClick();
        }

        private void DataGridFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
