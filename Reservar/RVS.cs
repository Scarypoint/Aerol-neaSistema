using Calificaciones;
using Calificaciones.Calificaciones;
using Calificaciones.Entidades;
using Sistema_de_Aerolinea.Entidades;
using Sistema_de_Aerolinea.Vuelo;
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

namespace Sistema_de_Aerolinea.Reservar
{
    public partial class RVS : Form
    {
        public RVS()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RRESERVAS(object sender, EventArgs e)
        {
            try
            {
                // Validar que un pasajero esté seleccionado
                if (comboBoxPasajeros.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un pasajero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el pasajero seleccionado del ComboBox
                Pasajero pasajero = (Pasajero)comboBoxPasajeros.SelectedItem;

                // Validar que haya una fila seleccionada en el DataGridView
                if (dgvreservas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un vuelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el vuelo seleccionado del DataGridView
                DataRowView rowView = (DataRowView)dgvreservas.SelectedRows[0].DataBoundItem;

                // Crear el objeto Vuelo con los datos del DataRowView
                RegistrarVuelos vuelo = new RegistrarVuelos // Cambia a la clase Vuelo
                {

                    Destino = rowView["Destino"].ToString(),
                    FechaSalida = (DateTime)rowView["FechaSalida"], // Asegúrate de que el tipo sea correcto

                };

                // Registrar la reserva en la base de datos
                Central.Reservar(pasajero, vuelo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Vuelos_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar los IDs de reserva en el ComboBox
                var idReservas = Central.ObtenerIdsReservas(); // Cambia esto según tu implementación
                comboBoxIdReserva.DataSource = idReservas; // Asumiendo que es una lista de int o string
                                                           // comboBoxIdReserva.DisplayMember y ValueMember no son necesarios si solo estás usando un listado de int
                                                           // Si es una lista de string, asegúrate de establecer DisplayMember y ValueMember correctamente

                // Cargar los vuelos en el DataGridView
                dgvreservas.DataSource = Central.CargarVuelos();

                // Obtener la lista de pasajeros desde la base de datos o fuente de datos
                List<Pasajero> pasajeros = Central.CargarPasajeros();  // Llama al método para obtener los pasajeros

                // Limpiar el ComboBox antes de agregar los nuevos pasajeros
                comboBoxPasajeros.Items.Clear();

                // Agregar los pasajeros al ComboBox
                foreach (var pasajero in pasajeros)
                {
                    comboBoxPasajeros.Items.Add(pasajero);  // El ComboBox usará el ToString() para mostrar nombre, apellido e ID del pasaporte
                }

                // Seleccionar el primer pasajero si hay alguno disponible
                if (comboBoxPasajeros.Items.Count > 0)
                {
                    comboBoxPasajeros.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar código para manejar la selección de un pasajero
        }

        private void CancelarReserva(object sender, EventArgs e)
        {
            try
            {
                // Validar que un ID de reserva esté seleccionado
                if (comboBoxIdReserva.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un ID de reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el ID de reserva seleccionado
                int idReserva = (int)comboBoxIdReserva.SelectedValue; // Asegúrate de que esto sea del tipo correcto

                // Cancelar la reserva en la base de datos
                Central.CancelarReserva(idReserva); // Implementa este método en la clase Central

                MessageBox.Show("Reserva cancelada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: actualizar el ComboBox o la vista después de cancelar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ㅤㅤㅤㅤㅤ_Click(object sender, EventArgs e)
        {

        }
    }
}
