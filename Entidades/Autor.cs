using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        //Atributos + Propiedaes
        private int codigo;
        private string apellido;
        private string nombre;
        private string nacionalidad;
        private DateTime fechaNac;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public Autor()
        {
            Nacionalidad = "Argentina";
        }
        public Autor(int pCodigo, string pApellido, string pNombre, string pNacionalidad, DateTime pFechaNac)
        {
            Codigo = pCodigo;
            Apellido = pApellido;
            Nombre = pNombre;
            Nacionalidad = pNacionalidad;
            FechaNac = pFechaNac;
        }
    }
}
