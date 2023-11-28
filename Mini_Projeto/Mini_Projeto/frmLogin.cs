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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btoCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string conexao = mdiPrincipal.stringConexao;

       private void testarConexao()
       {
            try
            {
                SqlConnection conn = new SqlConnection(conexao);

                conn.Open();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de conexão" + ex.ToString());
            }
       }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where " +
                 "login_usuario='" + txtLogin.Text + "' and " +
                 "senha_usuario='" + txtSenha.Text + "'";

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader reader;

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mdiPrincipal.idUsuario = reader[0].ToString();  
                    mdiPrincipal.nomeUsuario = reader[1].ToString();
                    mdiPrincipal.loginUsuario = reader[2].ToString();
                    this.Close();   
                }

                else
                {
                    MessageBox.Show("Erro, usuario invalido");  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro cadastrar" + ex.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            testarConexao();
        }
    }
}
