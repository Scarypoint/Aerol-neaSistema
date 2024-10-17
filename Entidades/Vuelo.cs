using Sistema_de_Aerolinea.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Aerolinea.Vuelo
{
    public class Vuelo
    {
        public string NumeroVuelo { get; set; } // Asegúrate de que sea public
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Avion { get; internal set; }
    }
}


        