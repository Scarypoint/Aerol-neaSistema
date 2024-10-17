using Calificaciones.Calificaciones;
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
    public partial class EliminarP : Form
    {
        public EliminarP()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de pasajeros desde la base de datos
                List<Pasajero> pasajeros = Central.CargarPasajeros();  // Llama al método para obtener los pasajeros

                // Limpiar el ComboBox antes de agregar los nuevos pasajeros
                comboBoxEliminarPasajero.Items.Clear();

                // Agregar los pasajeros al ComboBox
                foreach (var pasajero in pasajeros)
                {
                    comboBoxEliminarPasajero.Items.Add(pasajero);  // El ComboBox usará el ToString() para mostrar nombre, apellido e ID del pasaporte
                }

                // Seleccionar el primer pasajero si hay alguno disponible
                if (comboBoxEliminarPasajero.Items.Count > 0)
                {
                    comboBoxEliminarPasajero.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pasajeros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPasajeros(object sender, EventArgs e)
        {
            try
            {
                // Validar que un pasajero esté seleccionado
                if (comboBoxEliminarPasajero.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un pasajero a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el pasajero seleccionado del ComboBox
                Pasajero pasajero = (Pasajero)comboBoxEliminarPasajero.SelectedItem;

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar a {pasajero.Nombre} {pasajero.Apellido}?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al método de la clase Central para eliminar el pasajero
                    Central.EliminarPasajero(pasajero.IDPasaporte); // Asegúrate de que este método esté implementado

                    // Actualizar el ComboBox
                    comboBoxEliminarPasajero.Items.Remove(pasajero);
                    MessageBox.Show("Pasajero eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el pasajero: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}