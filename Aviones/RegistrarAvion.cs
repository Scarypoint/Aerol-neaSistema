using Calificaciones.Calificaciones;
using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class RegistrarAvion : Form
    {
        public RegistrarAvion()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registar(object sender, EventArgs e)
        {
            // Validar la capacidad de pasajeros (debe ser un número)
            if (!int.TryParse(txtcapacidad.Text, out int capacidad))
            {
                MessageBox.Show("Por favor, ingrese una capacidad válida de pasajeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos de modelo y matrícula no estén vacíos
            if (string.IsNullOrWhiteSpace(txtmodelo.Text) || string.IsNullOrWhiteSpace(txtmatricula.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Completa toda la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el objeto Avion con los valores ingresados
            Entidades.RegistrarAvion avion = new Entidades.RegistrarAvion
            {
                Modelo = txtmodelo.Text,
                Matricula = txtmatricula.Text,  // Matricula asignada correctamente
                CapacidadPasajeros = capacidad  // Asignar la capacidad numérica
            };

            // Registrar el avión
            Central.RegistrarAvion(avion);

            // Confirmación al usuario
            MessageBox.Show("Avión registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}



        