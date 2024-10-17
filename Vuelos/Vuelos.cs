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

namespace Sistema_de_Aerolinea.Vuelo
{
       
        public partial class RegistrarVuelos : Form
        {
        public object Destino { get; internal set; }
        public object FechaSalida { get; internal set; }
        public object Avion { get; internal set; }
        public string Modelo { get; internal set; }

        public RegistrarVuelos()
            {
                InitializeComponent();

                // Centrar el formulario en la pantalla
                this.StartPosition = FormStartPosition.CenterScreen;

                // Cargar aviones disponibles al iniciar
                CargarAvionesDisponibles();
            }

            // Botón de registrar vuelo
            public void Registrar(object sender, EventArgs e)
            {
                // Validar que los campos de número de vuelo y destino no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNumeroVuelo.Text) || string.IsNullOrWhiteSpace(txtDestino.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios. Completa toda la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar la fecha de salida
                if (dtpFechaSalida.Value <= DateTime.Now)
                {
                    MessageBox.Show("La fecha de salida debe ser posterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto Vuelo con los valores ingresados
                Vuelo vuelo = new Vuelo
                {
                    NumeroVuelo = txtNumeroVuelo.Text,
                    Destino = txtDestino.Text,
                    FechaSalida = dtpFechaSalida.Value,
                    Avion = comboBoxAviones.SelectedItem?.ToString() // Obtener el avión seleccionado
                };

                RegistrarAvion avionSeleccionado = (RegistrarAvion)comboBoxAviones.SelectedItem; // Asegúrate de que no sea nulo

                // Registrar el vuelo en la base de datos
                Central.RegistrarVuelo(vuelo, avionSeleccionado);
            }

            private void CargarAvionesDisponibles()
            {
                // Cargar aviones disponibles desde la base de datos según el destino
                List<RegistrarAvion> aviones = Central.ObtenerAvionesDisponibles(txtDestino.Text);
                comboBoxAviones.Items.Clear();

                foreach (var avion in aviones)
                {
                    comboBoxAviones.Items.Add(avion); // Asegúrate de que la clase Avion tenga un método ToString que devuelva el modelo o matrícula
                }

                // Seleccionar el primer avión como predeterminado si hay aviones disponibles
                if (comboBoxAviones.Items.Count > 0)
                {
                    comboBoxAviones.SelectedIndex = 0; // Selecciona el primer elemento
                }
            }

            private void Cancelar(object sender, EventArgs e)
            {
                // Verificar si el campo de número de vuelo no está vacío
                if (string.IsNullOrWhiteSpace(txtNumeroVuelo.Text))
                {
                    MessageBox.Show("Por favor, ingresa el número de vuelo que deseas cancelar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el número de vuelo desde el campo de texto
                string numeroVuelo = txtNumeroVuelo.Text;

                // Cancelar el vuelo en la base de datos
                Central.CancelarVuelo(numeroVuelo);
            }

            private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
            {
                // Aquí puedes agregar lógica cuando la fecha de salida cambie
            }

            private void label4_Click(object sender, EventArgs e)
            {
                // Evento para el clic del label, si es necesario
            }

        private void RegistrarVuelos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
    }




