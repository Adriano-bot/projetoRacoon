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
using Racoon;
using Racoon.Classes;

namespace Racoon
{
    public partial class frmNovoChamado : Form
    {
        public frmNovoChamado()
        {
            InitializeComponent();
        }

        private void frmNovoChamado_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();

            txtNome.Text = variaveisglobais.nomeusuariologado; //recebe nome do usuario logado e insere na txtnome

            try
            {
                cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "select distinct setor from usuarios where usuario = @login";
                com.Parameters.AddWithValue("@login", txtNome.Text);
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.cmbSetor.DataSource = dt;
                this.cmbSetor.ValueMember = "setor";
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações estão corretas?", "Enviar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandType = CommandType.Text;
                com.CommandText = "INSERT INTO chamados(nome, setor, descricao) VALUES(@nome, @setor, @descricao);";
                com.Parameters.AddWithValue("@nome", txtNome.Text);
                com.Parameters.AddWithValue("@setor", cmbSetor.Text);
                com.Parameters.AddWithValue("@descricao", rtbProblema.Text);

                if (! (txtNome.Text == "" || cmbSetor.Text == "" || rtbProblema.Text == ""))
                {
                    MessageBox.Show("O Chamado foi aberto com sucesso!", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

                }
                else
                {
                    MessageBox.Show("Você não pode deixar campos vazios!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }
    }
}
