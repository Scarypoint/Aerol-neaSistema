using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Aerolinea.Entidades
{
    public class Pasajero
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IDPasaporte { get; set; }

        public Pasajero() { }  // Constructor vacío

        public Pasajero(string nombre, string apellido, string idPasaporte)
        {
            Nombre = nombre;
            Apellido = apellido;
            IDPasaporte = int.Parse(idPasaporte);
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} (ID: {IDPasaporte})";
        }
    }
}


