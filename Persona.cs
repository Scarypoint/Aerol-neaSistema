using System;

namespace Aerolinea
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public abstract string MostrarDetalles();
    }
}
