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
using Racoon.Modelos;
using Racoon.Classes;

namespace Racoon
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void abrirNovoChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoChamado frmcmd = new frmNovoChamado();
            frmcmd.ShowDialog();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a sessão?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            label1.Text = ("Conectado como: " + variaveisglobais.nomeusuariologado);

            if (!(variaveisglobais.nivel_acesso == "ADMIN" || variaveisglobais.nivel_acesso == "TI"))
            {
                btnAtualizar.Visible = false;
                btnApagar.Visible = false;
                usuáriosToolStripMenuItem.Visible = false;
            }
            try
            {
                cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "select * from chamados";
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dgvChamados.DataSource = dt;
            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
            cn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.CommandText = "select * from chamados";
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.dgvChamados.DataSource = dt;
            cn.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Este procedimento irá apagar TODOS os chamados, você realmente deseja fazer isto?", "EXCLUIR TUDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection();
                SqlCommand com = new SqlCommand();
                DataTable dt = new DataTable();

                try
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                    cn.Open();
                    com.Connection = cn;
                    com.CommandText = "truncate table chamados";
                    SqlDataReader dr = com.ExecuteReader();
                    dt.Load(dr);
                    this.dgvChamados.DataSource = dt;
                }
                catch (SqlException)
                {

                    throw;
                }
                finally
                {
                    cn.Close();
                }

                try
                {
                    cn.Open();
                    com.Connection = cn;
                    com.CommandText = "select * from chamados";
                    SqlDataReader dr = com.ExecuteReader();
                    dt.Load(dr);
                    this.dgvChamados.DataSource = dt;
                }
                catch (SqlException)
                {

                    throw;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!(variaveisglobais.nivel_acesso == "ADMIN" || variaveisglobais.nivel_acesso == "TI"))
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "select * from chamados WHERE nome = @login";
                com.Parameters.AddWithValue("@login", variaveisglobais.nomeusuariologado);
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dgvChamados.DataSource = dt;
                cn.Close();
            }
            else
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "select * from chamados";
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dgvChamados.DataSource = dt;
                cn.Close();
            }
        }

        private void criarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(variaveisglobais.nivel_acesso == "ADMIN" || variaveisglobais.nivel_acesso == "TI"))
            {
                MessageBox.Show("Desculpe, você não possui permissão para acessar esta função.", "Sem Permissão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cadNovoUsuario cadnovousuario = new cadNovoUsuario();
                cadnovousuario.ShowDialog();
            }
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frmaltsenha = new frmAlterarSenha();
            frmaltsenha.ShowDialog();
        }
    }
}
