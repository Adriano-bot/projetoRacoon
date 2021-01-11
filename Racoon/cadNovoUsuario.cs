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

namespace Racoon
{
    public partial class cadNovoUsuario : Form
    {
        public cadNovoUsuario()
        {
            InitializeComponent();
        }

        private void cadNovoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "select distinct SETOR from USUARIOS";
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.cmbSetor.DataSource = dt;
                this.cmbSetor.ValueMember = "SETOR";
            }
            catch (SqlException)
            {

                throw;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConfSenha.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";
            cmbSetor.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand com = new SqlCommand();

            if (txtSenha.Text == txtConfSenha.Text)
            {
                try
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                    cn.Open();
                    com.Connection = cn;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO USUARIOS(USUARIO, SENHA, CONFSENHA, SETOR, NIVEL_ACESSO) VALUES(@usuario, @senha, @confsenha, @setor, @nivel_acesso);";
                    com.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    com.Parameters.AddWithValue("@senha", txtSenha.Text);
                    com.Parameters.AddWithValue("@confsenha", txtConfSenha.Text);
                    com.Parameters.AddWithValue("@setor", cmbSetor.Text);
                    com.Parameters.AddWithValue("@nivel_acesso", cmbSetor.Text);
                    int recordsAffected = com.ExecuteNonQuery();
                }
                catch (SqlException)
                {

                    throw;
                }
                MessageBox.Show("O usuário foi criado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfSenha.Text = "";
                txtSenha.Text = "";
                txtUsuario.Text = "";
                cmbSetor.Text = "";

            }
            else
            {
                MessageBox.Show("As senhas não coincidem, por favor verifique-as", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
