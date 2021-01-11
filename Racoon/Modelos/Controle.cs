using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racoon.DAO;

namespace Racoon.Modelos
{
    class Controle
    {

        public bool tem;
        public String mensagem = "";
        public String verificarnivel = "";

        public bool acessar(String login, String senha)
        {
            LoginDAOComandos loginDAO = new LoginDAOComandos();
            tem = loginDAO.verificarLogin(login, senha);
            if (!loginDAO.mensagem.Equals(""))
            {
                this.mensagem = loginDAO.mensagem;
            }
            return tem;
        }
    }
}
