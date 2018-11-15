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
        private List<registroMantenimiento> logMantenimientos= new List<registroMantenimiento>();

        public List<registroMantenimiento> LogMantenimientos
        {
             get { return logMantenimientos; }
        }
        private List<registroReparacion> logReparaciones = new List<registroReparacion>();

        public List<registroReparacion> LogReparaciones
        {
         get { return logReparaciones; }
        }
        private List<tripulante> tripulacion= new List<tripulante>();

        public List<tripulante> Tripulacion
        {
            get { return tripulacion; }
        }
    }
}