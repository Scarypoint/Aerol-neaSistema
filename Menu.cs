using Calificaciones;

using Sistema_de_Aerolinea.Pasajeros;
using Sistema_de_Aerolinea.Reservar;
using Sistema_de_Aerolinea.Vuelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Aerolinea
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Aviones(object sender, EventArgs e)
        {
            Aviones reg = new Aviones();

            // Suscribirse al evento FormClosed para recargar los datos en el DataGridView
            reg.FormClosed += (s, args) =>
            {
                // Recargar los datos en el DataGridView al cerrar el formulario de registro
                //gvaviones.DataSource = Central.CargarAviones();
            };

            // Mostrar el formulario de registro
            reg.Show();
        }

        private void Pasajeros(object sender, EventArgs e)
        {
            RP reg = new RP();

            // Suscribirse al evento FormClosed para recargar los datos en el DataGridView
            reg.FormClosed += (s, args) =>
            {
                // Recargar los datos en el DataGridView al cerrar el formulario de registro
                //gvaviones.DataSource = Central.CargarAviones();
            };

            // Mostrar el formulario de registro
            reg.Show();
        }

        private void Vuelos(object sender, EventArgs e)
        {
            {
                RegistrarVuelos reg = new RegistrarVuelos();

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
        private void Reservar(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de reservas
            RVS reg = new RVS(); // Asegúrate de que el constructor no requiera parámetros

            // Suscribirse al evento FormClosed para recargar los datos en el DataGridView
            reg.FormClosed += (s, args) =>
            {
                // Aquí puedes agregar el código para recargar datos, por ejemplo:
                // gvaviones.DataSource = Central.CargarAviones();
            };

            // Mostrar el formulario de reservas
            reg.Show();
        }
    }
}


