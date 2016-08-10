using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Autor
    {
        //Servidor, Base de Datos, IS
        private string strConnection = @"Server=A03-PC02/SQLEXPRESS;Database=Biblioteca;Integrated Security=true";
        public string getStrConnection() { return strConnection; }

        //Methods
        public void agregar(Entidades.Autor pAutor)
        {
            
        }
    }
}
