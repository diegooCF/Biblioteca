using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        //Methods

        //Acostumbrarse a recibir objetos enteros
        /// <summary>
        /// Descripcion: Calcula edad de un autor
        /// Autor: Diego Fernandez - 
        /// Fecha: 13/07
        /// </summary>
        /// <param name="pAutor"></param>
        /// <returns></returns>
        public int CalcularEdad(Entidades.Autor pAutor)
        {
            int intEdad;
            intEdad = DateTime.Today.Year - pAutor.FechaNac.Year;
            return intEdad;
        }

        /// <summary>
        /// Descripcion: Agrega autor a lista generica - 
        /// Autor: Diego Fernandez - 
        /// Fecha: 13/07
        /// </summary>
        /// <param name="pAutores"></param>
        /// <param name="pAutor"></param>
        public void Agregar(List<Entidades.Autor> pAutores, Entidades.Autor pAutor)
        {
            pAutores.Add(pAutor);
        }
    }
}
