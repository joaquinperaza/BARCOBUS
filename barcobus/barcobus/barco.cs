using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class barco
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int capacidadPasajeros;

        public int CapacidadPasajeros
        {
            get { return capacidadPasajeros; }
            set { capacidadPasajeros = value; }
        }
        private int capacidadTripulantes;

        public int CapacidadTripulantes
        {
            get { return capacidadTripulantes; }
            set { capacidadTripulantes = value; }
        }

     
    }
}