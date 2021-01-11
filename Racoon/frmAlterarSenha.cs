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
using Racoon.Classes;

namespace Racoon
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {
            txtUser.Text = variaveisglobais.nomeusuariologado;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
            cn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.CommandType = CommandType.Text;
            com.CommandText = "UPDATE USUARIOS SET SENHA = @SENHA, CONFSENHA = @CONFSENHA WHERE USUARIO = @USUARIO";
            com.Parameters.AddWithValue("@USUARIO", txtUser.Text);
            com.Parameters.AddWithValue("@SENHA", txtNovaSenha.Text);
            com.Parameters.AddWithValue("@CONFSENHA", txtConfNovaSenha.Text);

            if (!(txtUser.Text == "" || txtNovaSenha.Text == "" || txtConfNovaSenha.Text == ""))
            {
                MessageBox.Show("Sua Senha Foi Alterada Com Sucesso!", "Alterando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {                    
                    int r = com.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("ERRO NA INSERCAO do banco");
                }
                finally
                {
                    cn.Close();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Você não pode deixar espaços em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
