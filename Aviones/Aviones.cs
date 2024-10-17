using Calificaciones.Calificaciones;
using Sistema_de_Aerolinea;
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
using Sistema_de_Aerolinea.Pasajeros;


namespace Calificaciones
{
    public partial class Aviones : Form
    {
        

        public Aviones()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AgregarAvion(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegistrarAvion
            RegistrarAvion reg = new RegistrarAvion();

            // Suscribirse al evento FormClosed para recargar los datos en el DataGridView
            reg.FormClosed += (s, args) =>
            {
                // Recargar los datos en el DataGridView al cerrar el formulario de registro
                gvaviones.DataSource = Central.CargarAviones();
            };

            // Mostrar el formulario de registro
            reg.Show(); // Esto abrirá RegistrarAvion sin bloquear el formulario actual
        }

        private void Aviones_Load(object sender, EventArgs e)
        {
            gvaviones.DataSource = Central.CargarAviones();
        }


        private void EliminarAvion2(object sender, EventArgs e)
        {
            // Crear una instancia del formulario EliminarAvion1
            EliminarAvion1 eliminarForm = new EliminarAvion1();

            // Mostrar el formulario
            eliminarForm.Show(); // Esto abrirá EliminarAvion1 sin bloquear el formulario actual
                                 // o puedes usar eliminarForm.ShowDialog(); si quieres abrirlo como un diálogo
                                 // Recargar los datos en el DataGridView después de cerrar el formulario de registro
            gvaviones.DataSource = Central.CargarAviones();
            // Suscribirse al evento FormClosed para recargar los datos
            eliminarForm.FormClosed += (s, args) =>
            {
                // Recargar los datos en el DataGridView al cerrar el formulario de eliminación
                gvaviones.DataSource = Central.CargarAviones();
            };

            // Mostrar el formulario de eliminación
            eliminarForm.Show();
        }

        private void gvaviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}










        