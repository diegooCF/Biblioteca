using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        List<Entidades.Autor> listaAutores = new List<Entidades.Autor>();

        //Creo una instancia de Autor (Entidades)
        Entidades.Autor objEntidadAutor = new Entidades.Autor();

        //Creo un objeto de logica
        Logica.Autor objLogicaAutor = new Logica.Autor();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
            //Asignar propiedades
            objEntidadAutor.Codigo = Convert.ToInt32(txtCodigo.Text);
            objEntidadAutor.Apellido = txtApellido.Text;
            objEntidadAutor.Nombre = txtNombre.Text;
            objEntidadAutor.Nacionalidad = cboPaises.SelectedItem.ToString();
            objEntidadAutor.FechaNac = dtpFechaNac.Value;

            //Llamar al metodo agregar
            objLogicaAutor.Agregar(listaAutores, objEntidadAutor);
            MessageBox.Show("Autor agregado correctamente", "Registro satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEdad.Text = "Edad: " + objLogicaAutor.CalcularEdad(objEntidadAutor).ToString();
            
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            //Limpiamos la grilla y lista por si queremos recargarlas
            dgvAutores.DataSource = null;
            dgvAutores.DataSource = listaAutores;
        }
    }
}
