using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racoon.Modelos;
using Racoon.DAO;
using Racoon.Classes;
using System.Data.SqlClient;

namespace Racoon
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUsuario.Text,txtSenha.Text);


            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection();
                        cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                        cn.Open();
                        SqlCommand com = new SqlCommand();
                        com.Connection = cn;
                        com.CommandText = "select nivel_acesso from usuarios where usuario = @login";
                        com.Parameters.AddWithValue("@login", txtUsuario.Text);
                        SqlDataReader dr = com.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DataRow datr = dt.Rows[0];
                        string media = datr[0].ToString();
                        variaveisglobais.nivel_acesso = media;
                        cn.Close();
                    }
                    catch (SqlException)
                    {

                        throw;
                    }

                    try
                    {
                        SqlConnection cn = new SqlConnection();
                        cn.ConnectionString = @"Data Source=DESKTOP-0IM3RJ0\SQLSERVERNV2014;Initial Catalog=mastertable;Integrated Security=True";
                        cn.Open();
                        SqlCommand com = new SqlCommand();
                        com.Connection = cn;
                        com.CommandText = "select usuario from usuarios where usuario = @login";
                        com.Parameters.AddWithValue("@login", txtUsuario.Text);
                        SqlDataReader dr = com.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DataRow datr = dt.Rows[0];
                        string media = datr[0].ToString();
                        variaveisglobais.nomeusuariologado = media;
                        cn.Close();
                    }
                    catch (SqlException)
                    {

                        throw;
                    }

                    this.Hide();
                    frmMenu menu = new frmMenu();
                    menu.ShowDialog();
                    this.Close();

                }
                else
                {
                    if (txtUsuario.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("Você não pode deixar campos vazios!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login não encontrado, por favor verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
               
            }
        }
    }
}
