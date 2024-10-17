using Calificaciones;
using Calificaciones.Calificaciones;
using Calificaciones.Entidades;
using Sistema_de_Aerolinea.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Aerolinea.Pasajeros
{
    public partial class RP : Form
    {
        public RP()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registrar(object sender, EventArgs e)
        {
            // Validar el ID del pasaporte (debe ser un número)
            if (!int.TryParse(txtidp.Text, out int idPasaporte))
            {
                MessageBox.Show("Por favor, ingrese un ID de pasaporte válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos de nombre y apellido no estén vacíos
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtapellido.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Completa toda la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el objeto Pasajero con los valores ingresados usando el constructor
            Pasajero pasajero = new Pasajero(txtnombre.Text, txtapellido.Text, idPasaporte.ToString());

            // Registrar el pasajero en la clase Central
            Central.RegistrarPasajero(pasajero);  // Asegúrate de que este método exista
        }

        private void EliminarPasajero(object sender, EventArgs e)
        {
            {
                EliminarP reg = new EliminarP();

                // Suscribirse al evento FormClosed para recargar los datos en el DataGridView
                reg.FormClosed += (s, args) =>
                {
                    // Recargar los datos en el DataGridView al cerrar el formulario de registro
                    //gvaviones.DataSource = Central.CargarAviones();
                };

                // Mostrar el formulario de registro
                reg.Show();
            }
        }
    }
}


