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
    public partial class frmRelacionamentoProduto : Form
    {
        public frmRelacionamentoProduto()
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

                MessageBox.Show("Deu erro bro  " + ex.ToString());

            }


        }
            private void CarregarComboProduto()
            {
                string sql = "select id_produto, nome_produto from produto";

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
                    

                    cboIDProduto.DisplayMember = "id_produto";
                    cboIDProduto.DataSource = tabela;

                    cboNomeProduto.DisplayMember = "nome_produto";
                    cboNomeProduto.DataSource = tabela; 


                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROOO     " + ex.ToString());
                    Application.Exit();
                }
                finally { conn.Close(); }
            }

        private void frmRelacionamentoProduto_Load(object sender, EventArgs e)
        {
            testarConexao();
            CarregarComboProduto();
        }
    }
    }
           
        

        

        

        
    

