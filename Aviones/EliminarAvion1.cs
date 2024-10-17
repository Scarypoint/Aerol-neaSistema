using Calificaciones.Calificaciones;
using Calificaciones;
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
    public partial class EliminarAvion1 : Form
    {
        public EliminarAvion1()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void EliminarAvion(object sender, EventArgs e)
        {
            string modelo = txtmodelo.Text;  // Asegúrate de usar el TextBox correcto

            // Validar que el usuario ingrese una matrícula
            if (!string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show($"Intentando eliminar el avión con matrícula: {modelo}");  // Mensaje de depuración

                // Llamar al método estático que elimina el avión en la clase 'Central'
                Central.EliminarAvion(modelo);


            }
            else
            {
                MessageBox.Show("Por favor, ingresa la matrícula del avión que deseas eliminar.", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}