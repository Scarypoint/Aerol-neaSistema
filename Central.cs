using Aerolinea;
using Calificaciones.Entidades;
using Sistema_de_Aerolinea.Entidades;
using Sistema_de_Aerolinea.Vuelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    namespace Calificaciones
    {
        class Central
        {
            // Cadena de conexión a SQL Server
            static string constrg = "Server=localhost\\SQLEXPRESS;Database=tablita3;User Id=Carlos;Password=77777;TrustServerCertificate=True;";
            private static object nombre;

            // Propiedad que retorna la cadena de conexión
            public static string ConnectionString => constrg;

            // Método para registrar un avion
            public static void RegistrarAvion(Entidades.RegistrarAvion avion)
            {
                // Validar que los campos no estén vacíos o que la capacidad sea válida
                if (string.IsNullOrWhiteSpace(avion.Modelo) ||
                    string.IsNullOrWhiteSpace(avion.Matricula) ||
                    avion.CapacidadPasajeros <= 0)   // Validar que la capacidad sea un valor positivo
                {

                    MessageBox.Show("Todos los campos son obligatorios. Completa toda la información.", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Código para registrar avion en la base de datos
                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    SqlCommand comm = new SqlCommand("INSERT INTO   Aviones (Modelo, Matricula, Capacidad) VALUES (@Modelo, @Matricula, @Capacidad)", conn);
                    comm.Parameters.AddWithValue("@Modelo", avion.Modelo);
                    comm.Parameters.AddWithValue("@Matricula", avion.Matricula);
                    comm.Parameters.AddWithValue("@Capacidad", avion.CapacidadPasajeros);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje de error en un MessageBox
                        MessageBox.Show($"Error al registrar el avion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            public static void EliminarAvion(string modelo)
            {
                // Validar que la matrícula no esté vacía
                if (string.IsNullOrWhiteSpace(modelo))
                {
                    MessageBox.Show("Debes proporcionar la matrícula del avión a eliminar.", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Código para eliminar avión en la base de datos
                using (SqlConnection conn = new SqlConnection(constrg))  // Asegúrate de tener la conexión correcta
                {
                    SqlCommand comm = new SqlCommand("DELETE FROM Aviones WHERE Modelo = @Modelo", conn);
                    comm.Parameters.AddWithValue("@Modelo", modelo);

                    try
                    {
                        conn.Open();
                        int rowsAffected = comm.ExecuteNonQuery(); // Ejecuta la consulta y devuelve el número de filas afectadas

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("El avión ha sido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún avión con la matrícula proporcionada.", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje de error en un MessageBox
                        MessageBox.Show($"Error al eliminar el avión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            // Método para mostrar Aviones
            public static DataTable CargarAviones()
            {
                DataTable Aviones = new DataTable();
                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    SqlCommand comm = new SqlCommand("SELECT * FROM Aviones", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    try
                    {
                        conn.Open();
                        adapter.Fill(Aviones);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar los aviones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return Aviones;
            }

            public static void RegistrarPasajero(Pasajero pasajero)
            {
                // Validar que los campos no estén vacíos o que el IDPasaporte sea válido
                if (string.IsNullOrWhiteSpace(pasajero.Nombre) ||
                    string.IsNullOrWhiteSpace(pasajero.Apellido) ||
                    pasajero.IDPasaporte <= 0)  // Validar que el IDPasaporte sea un valor positivo
                {
                    MessageBox.Show("Todos los campos son obligatorios. Completa toda la información.", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Código para verificar si el pasajero ya existe en la base de datos
                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Pasajeros WHERE Nombre = @Nombre AND Apellido = @Apellido AND IDPasaporte = @IDPasaporte", conn);
                    checkCmd.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                    checkCmd.Parameters.AddWithValue("@Apellido", pasajero.Apellido);
                    checkCmd.Parameters.AddWithValue("@IDPasaporte", pasajero.IDPasaporte);

                    try
                    {
                        conn.Open();

                        // Verificar si ya existe un pasajero con los mismos datos
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            // Si ya existe un pasajero con los mismos datos
                            MessageBox.Show("Este pasajero ya está registrado.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Insertar el pasajero si no está duplicado
                        SqlCommand comm = new SqlCommand("INSERT INTO Pasajeros (Nombre, Apellido, IDPasaporte) VALUES (@Nombre, @Apellido, @IDPasaporte)", conn);
                        comm.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                        comm.Parameters.AddWithValue("@Apellido", pasajero.Apellido);
                        comm.Parameters.AddWithValue("@IDPasaporte", pasajero.IDPasaporte);

                        comm.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Pasajero registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje de error en un MessageBox
                        MessageBox.Show($"Error al registrar el pasajero: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            public static void RegistrarVuelo(Vuelo vuelo, Entidades.RegistrarAvion avionSeleccionado)
            {
                // Validar que los campos no estén vacíos o incorrectos
                if (string.IsNullOrWhiteSpace(vuelo.NumeroVuelo) ||
                    string.IsNullOrWhiteSpace(vuelo.Destino) ||
                    vuelo.FechaSalida <= DateTime.Now)
                {
                    MessageBox.Show("Todos los campos son obligatorios y deben ser válidos. Completa toda la información.", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    conn.Open();

                    // Verificar si ya existe un vuelo con el mismo número de vuelo
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Vuelos WHERE NumeroVuelo = @NumeroVuelo", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@NumeroVuelo", vuelo.NumeroVuelo);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Este vuelo ya está registrado.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insertar el vuelo si no está duplicado
                    using (SqlCommand comm = new SqlCommand("INSERT INTO Vuelos (NumeroVuelo, Destino, FechaSalida, Avion) VALUES (@NumeroVuelo, @Destino, @FechaSalida, @Avion)", conn))
                    {
                        comm.Parameters.AddWithValue("@NumeroVuelo", vuelo.NumeroVuelo);
                        comm.Parameters.AddWithValue("@Destino", vuelo.Destino);
                        comm.Parameters.AddWithValue("@FechaSalida", vuelo.FechaSalida);
                        comm.Parameters.AddWithValue("@Avion", vuelo.Avion); // Agregar el modelo del avión

                        try
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Vuelo registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al registrar el vuelo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }


            internal static List<Entidades.RegistrarAvion> ObtenerAvionesDisponibles(string text)
            {
                List<Entidades.RegistrarAvion> aviones = new List<Entidades.RegistrarAvion>();

                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Modelo, Matricula, Capacidad FROM Aviones", conn);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Entidades.RegistrarAvion avion = new Entidades.RegistrarAvion
                            {
                                Modelo = reader["Modelo"].ToString(),
                                Matricula = reader["Matricula"].ToString(),
                                CapacidadPasajeros = Convert.ToInt32(reader["Capacidad"])
                            };
                            aviones.Add(avion);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener aviones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return aviones;
            }

            public static void CancelarVuelo(string numeroVuelo)
            {
                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    conn.Open();

                    // Verificar si el vuelo existe
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Vuelos WHERE NumeroVuelo = @NumeroVuelo", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@NumeroVuelo", numeroVuelo);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("No se encontró un vuelo con ese número.", "Vuelo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Cancelar el vuelo
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Vuelos WHERE NumeroVuelo = @NumeroVuelo", conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@NumeroVuelo", numeroVuelo);

                        try
                        {
                            deleteCmd.ExecuteNonQuery();
                            MessageBox.Show("Vuelo cancelado exitosamente.", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cancelar el vuelo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            internal static object CargarVuelos()
            {
                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    conn.Open();

                    // Crear el comando para seleccionar los datos de la tabla Vuelos
                    using (SqlCommand comm = new SqlCommand("SELECT NumeroVuelo, Destino, FechaSalida, Avion FROM Vuelos", conn))
                    {
                        try
                        {
                            // Ejecutar la consulta y obtener los datos
                            SqlDataAdapter adapter = new SqlDataAdapter(comm);
                            DataTable dtVuelos = new DataTable();
                            adapter.Fill(dtVuelos); // Llenar el DataTable con los resultados de la consulta

                            return dtVuelos; // Devolver el DataTable con los vuelos cargados
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar los datos de los vuelos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null; // Retornar null en caso de error
                        }
                    }
                }
            }
            public static List<Pasajero> CargarPasajeros()
            {
                List<Pasajero> pasajeros = new List<Pasajero>();

                using (SqlConnection conn = new SqlConnection(constrg))
                {
                    conn.Open();
                    string query = "SELECT Nombre, Apellido, IDPasaporte FROM Pasajeros";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pasajero pasajero = new Pasajero(
                                    reader["Nombre"].ToString(),
                                    reader["Apellido"].ToString(),
                                    reader["IDPasaporte"].ToString()
                                );
                                pasajeros.Add(pasajero);
                            }
                        }
                    }
                }

                return pasajeros;
            }


            public static void Reservar(Pasajero pasajero, RegistrarVuelos vuelo, Aviones avion)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Comenzar una transacción
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Registrar la reserva
                            string queryReserva = @"
                INSERT INTO Reservas (Nombre, Apellido, IDPasaporte, Destino, FechaSalida) 
                VALUES (@Nombre, @Apellido, @IDPasaporte, @Destino, @FechaSalida, @Avion)";

                            using (SqlCommand cmdReserva = new SqlCommand(queryReserva, conn, transaction))
                            {
                                cmdReserva.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                                cmdReserva.Parameters.AddWithValue("@Apellido", pasajero.Apellido);
                                cmdReserva.Parameters.AddWithValue("@IDPasaporte", pasajero.IDPasaporte);
                                cmdReserva.Parameters.AddWithValue("@Destino", vuelo.Destino);
                                cmdReserva.Parameters.AddWithValue("@FechaSalida", vuelo.FechaSalida);
                                cmdReserva.Parameters.AddWithValue("@Modelo", vuelo.Avion);


                                cmdReserva.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            transaction.Commit();
                            MessageBox.Show("Reserva registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Si ocurre un error, revertir la transacción
                            transaction.Rollback();
                            MessageBox.Show($"Error al registrar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            internal static void Reservar(Pasajero pasajero, RegistrarVuelos vuelo)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Comenzar una transacción
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Registrar la reserva
                            string queryReserva = @"
                INSERT INTO Reservas (Nombre, Apellido, IDPasaporte, Destino, FechaSalida) 
                VALUES (@Nombre, @Apellido, @IDPasaporte, @Destino, @FechaSalida)";

                            using (SqlCommand cmdReserva = new SqlCommand(queryReserva, conn, transaction))
                            {
                                cmdReserva.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                                cmdReserva.Parameters.AddWithValue("@Apellido", pasajero.Apellido);
                                cmdReserva.Parameters.AddWithValue("@IDPasaporte", pasajero.IDPasaporte);
                                cmdReserva.Parameters.AddWithValue("@Destino", vuelo.Destino);
                                cmdReserva.Parameters.AddWithValue("@FechaSalida", vuelo.FechaSalida);



                                cmdReserva.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            transaction.Commit();
                            MessageBox.Show("Reserva registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Si ocurre un error, revertir la transacción
                            transaction.Rollback();
                            MessageBox.Show($"Error al registrar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            public static void CancelarReserva(int idReserva)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Comenzar una transacción
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Cancelar la reserva
                            string queryCancelar = @"
                DELETE FROM Reservas 
                WHERE Id = @Id";

                            using (SqlCommand cmdCancelar = new SqlCommand(queryCancelar, conn, transaction))
                            {
                                cmdCancelar.Parameters.AddWithValue("@Id", idReserva);
                                cmdCancelar.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            transaction.Commit();
                            MessageBox.Show("Reserva cancelada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Si ocurre un error, revertir la transacción
                            transaction.Rollback();
                            MessageBox.Show($"Error al cancelar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            public static List<int> ObtenerIdsReservas()
            {
                List<int> idsReservas = new List<int>();

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id FROM Reservas"; // Selecciona solo el campo Id

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar cada ID a la lista
                                idsReservas.Add(reader.GetInt32(0)); // Asegúrate de que sea el tipo correcto
                            }
                        }
                    }
                }

                return idsReservas; // Retornar la lista de IDs
            }

            public static void EliminarPasajero(int idPasaporte)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Pasajeros WHERE IDPasaporte = @IDPasaporte";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDPasaporte", idPasaporte);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}















