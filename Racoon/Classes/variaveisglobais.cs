using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Classes
{
    class variaveisglobais
    {
        private static string _nivel_acesso;
        public static string nivel_acesso
        {
            get { return _nivel_acesso;  }
            set { _nivel_acesso = value; }
        }

        public static string _nomeusuariologado;
        public static string nomeusuariologado
        {
            get { return _nomeusuariologado; }
            set { _nomeusuariologado = value; }
        }

    }
}
